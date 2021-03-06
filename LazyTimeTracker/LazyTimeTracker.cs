﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace LazyTimeTracker
{
    public partial class LazyTimeTracker : Form
    {
        public static IList<TimeEntry> timeEntries = new System.ComponentModel.BindingList<TimeEntry>();
        public LazyTimeTracker()
        {
            InitializeComponent();
        }

        private void LazyTimeTracker_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            LoadSettingsObjects();
            LoadObjectsForDay(monthCalendar1.SelectionStart);
            dataGridView1.DataSource = timeEntries;
        }

        private void neuerEintragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void TaskIcon_DoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == true)
            {
                this.Hide();
            } else
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void LazyTimeTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void LazyTimeTracker_FormResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog(this);
            SaveSettingsObjects();
        }

        private void monthCalender1_DateSelected(object sender, DateRangeEventArgs e)
        {
            //Load the JSON with the entries
            LoadObjectsForDay(monthCalendar1.SelectionStart);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedEntries();
        }

        private void CopyDay_Click(object sender, EventArgs e)
        {
            SelectAndCopyToClipboard();
        }

        private void copyDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAndCopyToClipboard();
        }

        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedEntries();
        }

        //Helper Functions
        #region helper-functions

        private void AddEntry()
        {
            NewTimeEntry newTimeEntry = new NewTimeEntry(monthCalendar1.SelectionStart);
            newTimeEntry.ShowDialog(this);
            dataGridView1.Update();
            SaveObjectsForDay(monthCalendar1.SelectionStart);
        }

        private void DeleteSelectedEntries()
        {
            if (MessageBox.Show("Really delete?", "Quenstion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                dataGridView1.Update();
                SaveObjectsForDay(monthCalendar1.SelectionStart);
            }
        }

        private void SelectAndCopyToClipboard()
        {
            if (dataGridView1.Rows.Count > 0) { 
            dataGridView1.SelectAll();
            Clipboard.SetDataObject(dataGridView1.GetClipboardContent(), false);
            MessageBox.Show("Make sure you have " + dataGridView1.Rows.Count.ToString() + " rows in SAP available before pasting.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LoadObjectsForDay(DateTime DateSelected)
        {
            
            string entriesDirectoryPath =
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "LazyTimeTracker" +
                Path.DirectorySeparatorChar + "data" +
                Path.DirectorySeparatorChar + DateSelected.Year.ToString() +
                Path.DirectorySeparatorChar + DateSelected.Month.ToString();

            string entriesPath =
                entriesDirectoryPath +
                Path.DirectorySeparatorChar + DateSelected.Day.ToString() + ".json";

            if (File.Exists(entriesPath))
            {
                FileStream fsTimeEntries =
                new FileStream(
                    entriesPath,
                    FileMode.Open,
                    FileAccess.Read);

                StreamReader srTimeEntriesFs = new StreamReader(fsTimeEntries);

                string timeEntriesObjects = srTimeEntriesFs.ReadToEnd();
                timeEntries = System.Text.Json.JsonSerializer.Deserialize<BindingList<TimeEntry>>(timeEntriesObjects);

                srTimeEntriesFs.Close();
                dataGridView1.DataSource = timeEntries;
                dataGridView1.Update();

            }
            else
            {
                timeEntries.Clear();
                dataGridView1.Update();
            }
        }

        public void LoadSettingsObjects()
        {
            
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "LazyTimeTracker" +
                Path.DirectorySeparatorChar + "data";
            if (File.Exists(dataDirectory + Path.DirectorySeparatorChar + "bookingElements.json"))
            {
                FileStream fsBookingElements =
                new FileStream(
                    dataDirectory + Path.DirectorySeparatorChar + "bookingElements.json",
                    FileMode.Open,
                    FileAccess.Read);

                StreamReader srBookingElements = new StreamReader(fsBookingElements);

                string settingsObjectString = srBookingElements.ReadToEnd();
                Program.mySettings.bookingElements = System.Text.Json.JsonSerializer.Deserialize<BindingList<BookingElement>>(settingsObjectString);

                srBookingElements.Close();
            }

            if (File.Exists(dataDirectory + Path.DirectorySeparatorChar + "invoiceElements.json"))
            {
                FileStream fsInvoiceElements =
                new FileStream(
                    dataDirectory + Path.DirectorySeparatorChar + "invoiceElements.json",
                    FileMode.Open,
                    FileAccess.Read);

                StreamReader srInvoiceElements = new StreamReader(fsInvoiceElements);

                string invoiceObjectString = srInvoiceElements.ReadToEnd();
                Program.mySettings.Einkaufsbelege = System.Text.Json.JsonSerializer.Deserialize<BindingList<string>>(invoiceObjectString);

                srInvoiceElements.Close();
            }
        }

        public void SaveSettingsObjects()
        {
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "LazyTimeTracker" +
                 Path.DirectorySeparatorChar + "data";
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }
            //Buchungselemente sichern
            FileStream fsBookingElements =
                new FileStream(
                    dataDirectory +
                    Path.DirectorySeparatorChar + "bookingElements.json",
                    FileMode.OpenOrCreate,
                    FileAccess.Write);

            StreamWriter swBookingElementsFs = new StreamWriter(fsBookingElements);

            fsBookingElements.SetLength(0);
            swBookingElementsFs.Write(System.Text.Json.JsonSerializer.Serialize(Program.mySettings.bookingElements));
            swBookingElementsFs.Close();

            //Einkaufsbelege sichern
            FileStream fsInvoiceElements =
                new FileStream(
                    dataDirectory +
                     Path.DirectorySeparatorChar + "invoiceElements.json",
                    FileMode.OpenOrCreate,
                    FileAccess.Write);

            StreamWriter swInvoiceElements = new StreamWriter(fsInvoiceElements);

            fsInvoiceElements.SetLength(0);
            swInvoiceElements.Write(System.Text.Json.JsonSerializer.Serialize(Program.mySettings.Einkaufsbelege));
            swInvoiceElements.Close();
        }

        public void SaveObjectsForDay(DateTime DateSelected)
        {
            string entriesDirectoryPath =
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + "LazyTimeTracker" +
                Path.DirectorySeparatorChar + "data" +
                Path.DirectorySeparatorChar + DateSelected.Year.ToString() +
                Path.DirectorySeparatorChar + DateSelected.Month.ToString();

            string entriesPath =
                entriesDirectoryPath +
                Path.DirectorySeparatorChar + DateSelected.Day.ToString() + ".json";

            if (!Directory.Exists(entriesDirectoryPath))
            {
                Directory.CreateDirectory(entriesDirectoryPath);
            }

            FileStream fsTimeEntries =
                new FileStream(
                    entriesPath,
                    FileMode.OpenOrCreate,
                    FileAccess.Write);

            StreamWriter swTimeEntriesFs = new StreamWriter(fsTimeEntries);

            fsTimeEntries.SetLength(0);
            swTimeEntriesFs.Write(System.Text.Json.JsonSerializer.Serialize(timeEntries));
            swTimeEntriesFs.Close();
        }


        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyTimeTracker
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingElement temp = new BookingElement("Name", "Nummer", "LstArt");
            TimeEntryEditor timeEntryEditor = new TimeEntryEditor(temp, false);
            timeEntryEditor.ShowDialog(this);
            listBox1.Update();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Program.mySettings.bookingElements;
            listEinkaufsbelege.DataSource = Program.mySettings.Einkaufsbelege;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.mySettings.bookingElements.Remove((BookingElement)listBox1.SelectedItem);
                listBox1.Update();
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeEntryEditor timeEntryEditor = new TimeEntryEditor((BookingElement)listBox1.SelectedItem, true);
            timeEntryEditor.ShowDialog(this);
            listBox1.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.mySettings.Einkaufsbelege.Add(txtEinkaufsbeleg.Text);
            txtEinkaufsbeleg.Text = "";
            listEinkaufsbelege.Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.mySettings.Einkaufsbelege.Remove((string)listEinkaufsbelege.SelectedItem);
                listBox1.Update();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                //// The path to the key where Windows looks for startup applications
                //Microsoft.Win32.RegistryKey rkApp = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                //                    @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                ////Path to launch shortcut
                //string startPath = Environment.GetFolderPath(Environment.SpecialFolder.Programs)
                //                   + @"\YourPublisher\YourSuite\YourProduct.appref-ms";

                //rkApp.SetValue("YourProduct", startPath);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + System.IO.Path.DirectorySeparatorChar + "LazyTimeTracker" +
                System.IO.Path.DirectorySeparatorChar + "data";
            System.Diagnostics.Process.Start("explorer.exe", dataDirectory);

        }
    }
}

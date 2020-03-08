using System;
using System.Windows.Forms;

namespace LazyTimeTracker
{
    public partial class NewTimeEntry : Form
    {
        DateTime targetDate;
        bool txtStartValid = false;
        bool txtEndValid = false;
        public NewTimeEntry(DateTime TargetDate)
        {
            targetDate = TargetDate;
            InitializeComponent();
        }

        private void NewTimeEntry_Load(object sender, EventArgs e)
        {
            project.DataSource = Program.mySettings.bookingElements;
            einkaufsbeleg.DataSource = Program.mySettings.Einkaufsbelege;
            txtStart.ValidatingType = typeof(DateTime);
            txtEnd.ValidatingType = typeof(DateTime);
            btnSave.Enabled = false;
        }

        private void txtStart_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput) {
                MaskedTextBox mtb = (MaskedTextBox)sender;
                mtb.BackColor = System.Drawing.Color.LightCoral;
                if (mtb.Name == "txtStart")
                {
                    txtStartValid = false;
                } else if (mtb.Name == "txtEnd")
                {
                    txtEndValid = false;
                }
            } else
            {
                MaskedTextBox mtb = (MaskedTextBox)sender;
                mtb.BackColor =  System.Drawing.Color.LightGreen;
                if (mtb.Name == "txtStart")
                {
                    txtStartValid = true;
                }
                else if (mtb.Name == "txtEnd")
                {
                    txtEndValid = true;
                }
            }

            if (txtStartValid && txtEndValid)
            {
                btnSave.Enabled = true;
            } else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtStart_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate { SetMaskedTextBoxSelectAll((MaskedTextBox)sender); });
        }

        private void SetMaskedTextBoxSelectAll(MaskedTextBox txtbox)
        {
            txtbox.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAndClose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SaveAndClose();
            }
        }

        private void SaveAndClose()
        {
            DateTime DateTimeBegin = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day, DateTime.Parse(txtStart.Text).Hour, DateTime.Parse(txtStart.Text).Minute, 0);
            DateTime DateTimeEnd = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day, DateTime.Parse(txtEnd.Text).Hour, DateTime.Parse(txtEnd.Text).Minute, 0);

            TimeEntry timeEntry = new TimeEntry(DateTimeBegin, DateTimeEnd, (BookingElement)project.SelectedItem, (string)einkaufsbeleg.SelectedItem, txtDescription.Text);
            LazyTimeTracker.timeEntries.Add(timeEntry);
            this.Close();
        }
    }
}


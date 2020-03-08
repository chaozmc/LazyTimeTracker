using System;
using System.Windows.Forms;

namespace LazyTimeTracker
{
    public partial class NewTimeEntry : Form
    {
        DateTime targetDate;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DateTimeBegin = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day, DateTime.Parse(txtStart.Text).Hour, DateTime.Parse(txtStart.Text).Minute, 0);
            DateTime DateTimeEnd = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day, DateTime.Parse(txtEnd.Text).Hour, DateTime.Parse(txtEnd.Text).Minute, 0);

            TimeEntry timeEntry = new TimeEntry(DateTimeBegin, DateTimeEnd, (BookingElement)project.SelectedItem, (string)einkaufsbeleg.SelectedItem, txtDescription.Text);
            LazyTimeTracker.timeEntries.Add(timeEntry);
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtStart.Text);
        }

        private void txtStart_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput) {
                MaskedTextBox mtb = (MaskedTextBox)sender;
                mtb.BackColor = System.Drawing.Color.LightCoral;
            } else
            {
                MaskedTextBox mtb = (MaskedTextBox)sender;
                mtb.BackColor =  System.Drawing.Color.LightGreen;
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
    }
}


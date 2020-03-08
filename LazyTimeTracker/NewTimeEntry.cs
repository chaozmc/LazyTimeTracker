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
            hourStart.Value = DateTime.Now.Hour;
            minStart.Value = DateTime.Now.Minute;
            hourEnd.Value = DateTime.Now.Hour;
            minEnd.Value = DateTime.Now.Minute;

        }

        private void hourStart_Enter(object sender, EventArgs e)
        {
            hourStart.Select(0, hourStart.Text.Length);
        }

        private void minStart_Enter(object sender, EventArgs e)
        {
            minStart.Select(0, minStart.Text.Length);
        }

        private void hourEnd_Enter(object sender, EventArgs e)
        {
            hourEnd.Select(0, hourEnd.Text.Length);
        }

        private void minEnd_Enter(object sender, EventArgs e)
        {
            minEnd.Select(0, minEnd.Text.Length);
        }

        private void einkaufsbeleg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DateTimeBegin = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day, (int)hourStart.Value, (int)minStart.Value, 0);
            DateTime DateTimeEnd = new DateTime(targetDate.Year, targetDate.Month, targetDate.Day, (int)hourEnd.Value, (int)minEnd.Value, 0);

            TimeEntry timeEntry = new TimeEntry(DateTimeBegin, DateTimeEnd, (BookingElement)project.SelectedItem, (string)einkaufsbeleg.SelectedItem, txtDescription.Text);
            LazyTimeTracker.timeEntries.Add(timeEntry);
            this.Close();

        }
    }
}


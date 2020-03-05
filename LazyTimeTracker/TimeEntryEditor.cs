using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class TimeEntryEditor : Form
    {
        BookingElement BookingElementIRepresent;

        public TimeEntryEditor(BookingElement bookingElement)
        {
            InitializeComponent();
            BookingElementIRepresent = bookingElement;
        }

        private void TimeEntryEditor_Load(object sender, EventArgs e)
        {
            txtBuchungsElement.Text = BookingElementIRepresent.TimeElement;
            txtHRElement.Text = BookingElementIRepresent.HRElement;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingElementIRepresent.TimeElement = txtBuchungsElement.Text;
            BookingElementIRepresent.HRElement = txtHRElement.Text;
            Program.bookingElements.Add(BookingElementIRepresent);
            this.Close();
        }
    }
}

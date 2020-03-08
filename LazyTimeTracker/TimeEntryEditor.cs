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
    public partial class TimeEntryEditor : Form
    {
        private BookingElement BookingElementIRepresent;
        private bool Edit;
        public TimeEntryEditor(BookingElement bookingElement, bool edit)
        {
            InitializeComponent();
            BookingElementIRepresent = bookingElement;
            Edit = edit;
        }

        private void TimeEntryEditor_Load(object sender, EventArgs e)
        {
            txtName.Text = BookingElementIRepresent.DisplayName;
            txtBuchungsElement.Text = BookingElementIRepresent.TimeElement;
            txtHRElement.Text = BookingElementIRepresent.HRElement;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingElementIRepresent.TimeElement = txtBuchungsElement.Text;
            BookingElementIRepresent.HRElement = txtHRElement.Text;
            BookingElementIRepresent.DisplayName = txtName.Text;
            if (!Edit)
            {
                Program.mySettings.bookingElements.Add(BookingElementIRepresent);
            } else
            {
                Program.mySettings.bookingElements.Remove(BookingElementIRepresent);
                Program.mySettings.bookingElements.Add(BookingElementIRepresent);
            }
            this.Close();
        }
    }
}

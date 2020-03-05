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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookingElement temp = new BookingElement("9034243812904839201", "HR36369");
            TimeEntryEditor timeEntryEditor = new TimeEntryEditor(temp);
            timeEntryEditor.ShowDialog(this);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Program.bookingElements;
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (BookingElement BE in Program.bookingElements)
            {
                listBox1.Items.Add(BE);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}

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
            BookingElement temp = new BookingElement("HAAI", "9034243812904839201", "HR36369");
            TimeEntryEditor timeEntryEditor = new TimeEntryEditor(temp, false);
            timeEntryEditor.ShowDialog(this);
            listBox1.Update();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Program.bookingElements;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Program.bookingElements.Remove((BookingElement)listBox1.SelectedItem);
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
    }
}

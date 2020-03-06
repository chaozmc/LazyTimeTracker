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
    public partial class LazyTimeTracker : Form
    {
        public LazyTimeTracker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewTimeEntry newTimeEntry = new NewTimeEntry();
            newTimeEntry.ShowDialog(this);
        }

        private void projekteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.Show();
        }

        private void LazyTimeTracker_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
        }

        private void neuerEintragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTimeEntry newTimeEntry = new NewTimeEntry();
            newTimeEntry.ShowDialog(this);
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
    }
}

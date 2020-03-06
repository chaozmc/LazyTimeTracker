﻿using System;
using System.Windows.Forms;

namespace LazyTimeTracker
{
    public partial class NewTimeEntry : Form
    {
        public NewTimeEntry()
        {
            InitializeComponent();
        }

        private void NewTimeEntry_Load(object sender, EventArgs e)
        {
            project.DataSource = Program.bookingElements;
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
    }
}


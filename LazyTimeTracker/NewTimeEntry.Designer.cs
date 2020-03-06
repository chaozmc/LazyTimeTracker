namespace LazyTimeTracker
{
    partial class NewTimeEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTimeEntry));
            this.hourStart = new System.Windows.Forms.NumericUpDown();
            this.minStart = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.minEnd = new System.Windows.Forms.NumericUpDown();
            this.hourEnd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hourStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // hourStart
            // 
            this.hourStart.BackColor = System.Drawing.Color.LightGreen;
            this.hourStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourStart.Location = new System.Drawing.Point(12, 12);
            this.hourStart.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourStart.Name = "hourStart";
            this.hourStart.Size = new System.Drawing.Size(139, 116);
            this.hourStart.TabIndex = 0;
            this.hourStart.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.hourStart.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourStart.Enter += new System.EventHandler(this.hourStart_Enter);
            // 
            // minStart
            // 
            this.minStart.BackColor = System.Drawing.Color.LightGreen;
            this.minStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minStart.Location = new System.Drawing.Point(177, 12);
            this.minStart.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minStart.Name = "minStart";
            this.minStart.Size = new System.Drawing.Size(133, 116);
            this.minStart.TabIndex = 1;
            this.minStart.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minStart.Enter += new System.EventHandler(this.minStart_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 108);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // minEnd
            // 
            this.minEnd.BackColor = System.Drawing.Color.LightCoral;
            this.minEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minEnd.Location = new System.Drawing.Point(564, 12);
            this.minEnd.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minEnd.Name = "minEnd";
            this.minEnd.Size = new System.Drawing.Size(130, 116);
            this.minEnd.TabIndex = 4;
            this.minEnd.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minEnd.Enter += new System.EventHandler(this.minEnd_Enter);
            // 
            // hourEnd
            // 
            this.hourEnd.BackColor = System.Drawing.Color.LightCoral;
            this.hourEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourEnd.Location = new System.Drawing.Point(399, 12);
            this.hourEnd.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourEnd.Name = "hourEnd";
            this.hourEnd.Size = new System.Drawing.Size(134, 116);
            this.hourEnd.TabIndex = 3;
            this.hourEnd.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.hourEnd.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourEnd.Enter += new System.EventHandler(this.hourEnd_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 108);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 108);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // project
            // 
            this.project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.project.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project.FormattingEnabled = true;
            this.project.Items.AddRange(new object[] {
            "HAAI <HR343434 | 482390489203483290489>"});
            this.project.Location = new System.Drawing.Point(12, 160);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(682, 63);
            this.project.TabIndex = 7;
            // 
            // NewTimeEntry
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(708, 389);
            this.Controls.Add(this.project);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minEnd);
            this.Controls.Add(this.hourEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minStart);
            this.Controls.Add(this.hourStart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTimeEntry";
            this.Text = "Neuer Eintrag";
            this.Load += new System.EventHandler(this.NewTimeEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hourStart;
        private System.Windows.Forms.NumericUpDown minStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minEnd;
        private System.Windows.Forms.NumericUpDown hourEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox project;
    }
}
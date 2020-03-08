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
            this.label3 = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.ComboBox();
            this.einkaufsbeleg = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.MaskedTextBox();
            this.txtEnd = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 14);
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
            // einkaufsbeleg
            // 
            this.einkaufsbeleg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.einkaufsbeleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.einkaufsbeleg.FormattingEnabled = true;
            this.einkaufsbeleg.Location = new System.Drawing.Point(12, 238);
            this.einkaufsbeleg.Name = "einkaufsbeleg";
            this.einkaufsbeleg.Size = new System.Drawing.Size(682, 63);
            this.einkaufsbeleg.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(12, 313);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(682, 49);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtStart
            // 
            this.txtStart.BeepOnError = true;
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(12, 11);
            this.txtStart.Mask = "00:00";
            this.txtStart.Name = "txtStart";
            this.txtStart.RejectInputOnFirstFailure = true;
            this.txtStart.Size = new System.Drawing.Size(249, 116);
            this.txtStart.TabIndex = 1;
            this.txtStart.ValidatingType = typeof(System.DateTime);
            this.txtStart.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.txtStart_TypeValidationCompleted);
            this.txtStart.Enter += new System.EventHandler(this.txtStart_Enter);
            // 
            // txtEnd
            // 
            this.txtEnd.BeepOnError = true;
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(445, 11);
            this.txtEnd.Mask = "00:00";
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.RejectInputOnFirstFailure = true;
            this.txtEnd.Size = new System.Drawing.Size(249, 116);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.ValidatingType = typeof(System.DateTime);
            this.txtEnd.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.txtStart_TypeValidationCompleted);
            this.txtEnd.Enter += new System.EventHandler(this.txtStart_Enter);
            // 
            // NewTimeEntry
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(708, 413);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.einkaufsbeleg);
            this.Controls.Add(this.project);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTimeEntry";
            this.Text = "Neuer Eintrag";
            this.Load += new System.EventHandler(this.NewTimeEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox project;
        private System.Windows.Forms.ComboBox einkaufsbeleg;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox txtStart;
        private System.Windows.Forms.MaskedTextBox txtEnd;
    }
}
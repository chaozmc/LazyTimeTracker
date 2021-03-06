﻿namespace LazyTimeTracker
{
    partial class LazyTimeTracker
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LazyTimeTracker));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cm1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.neuerEintragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVortag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbAnArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuftragsbezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHRElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLeistungsart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBemerkung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBookingElement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CopyDay = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cm1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cm1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Lazy Time Tracker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskIcon_DoubleClick);
            // 
            // cm1
            // 
            this.cm1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuerEintragToolStripMenuItem});
            this.cm1.Name = "cm1";
            this.cm1.Size = new System.Drawing.Size(147, 26);
            // 
            // neuerEintragToolStripMenuItem
            // 
            this.neuerEintragToolStripMenuItem.Name = "neuerEintragToolStripMenuItem";
            this.neuerEintragToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.neuerEintragToolStripMenuItem.Text = "Neuer Eintrag";
            this.neuerEintragToolStripMenuItem.Click += new System.EventHandler(this.neuerEintragToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyDay,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "&Menü";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(9, 33);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ScrollChange = 1;
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalender1_DateSelected);
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddEntry.Location = new System.Drawing.Point(9, 207);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(221, 42);
            this.btnAddEntry.TabIndex = 3;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(12, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnStart,
            this.ColumnEnd,
            this.ColumnVortag,
            this.ColumnAbAnArt,
            this.ColumnTimeElement,
            this.ColumnAuftragsbezeichnung,
            this.ColumnHRElement,
            this.ColumnLeistungsart,
            this.ColumnInvoice,
            this.ColumnBemerkung,
            this.ColumnBookingElement});
            this.dataGridView1.ContextMenuStrip = this.cmMain;
            this.dataGridView1.Location = new System.Drawing.Point(242, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(952, 245);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Start";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EndTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "End";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TimeElement";
            this.dataGridViewTextBoxColumn3.HeaderText = "TimeElement";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HRElement";
            this.dataGridViewTextBoxColumn4.HeaderText = "HRElement";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Invoice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Einkaufsbeleg";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bemerkung";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // columnStart
            // 
            this.columnStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.columnStart.DataPropertyName = "StartTime";
            this.columnStart.HeaderText = "Start";
            this.columnStart.MinimumWidth = 6;
            this.columnStart.Name = "columnStart";
            this.columnStart.ReadOnly = true;
            this.columnStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnStart.Width = 35;
            // 
            // ColumnEnd
            // 
            this.ColumnEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnEnd.DataPropertyName = "EndTime";
            this.ColumnEnd.HeaderText = "End";
            this.ColumnEnd.MinimumWidth = 6;
            this.ColumnEnd.Name = "ColumnEnd";
            this.ColumnEnd.ReadOnly = true;
            this.ColumnEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnEnd.Width = 32;
            // 
            // ColumnVortag
            // 
            this.ColumnVortag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnVortag.DataPropertyName = "Vortag";
            this.ColumnVortag.HeaderText = "Vortag";
            this.ColumnVortag.Name = "ColumnVortag";
            this.ColumnVortag.ReadOnly = true;
            this.ColumnVortag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnVortag.Width = 44;
            // 
            // ColumnAbAnArt
            // 
            this.ColumnAbAnArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnAbAnArt.DataPropertyName = "AbAnArt";
            this.ColumnAbAnArt.HeaderText = "AbAnArt";
            this.ColumnAbAnArt.Name = "ColumnAbAnArt";
            this.ColumnAbAnArt.ReadOnly = true;
            this.ColumnAbAnArt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnAbAnArt.Width = 52;
            // 
            // ColumnTimeElement
            // 
            this.ColumnTimeElement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnTimeElement.DataPropertyName = "TimeElement";
            this.ColumnTimeElement.HeaderText = "TimeElement";
            this.ColumnTimeElement.MinimumWidth = 6;
            this.ColumnTimeElement.Name = "ColumnTimeElement";
            this.ColumnTimeElement.ReadOnly = true;
            this.ColumnTimeElement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnTimeElement.Width = 74;
            // 
            // ColumnAuftragsbezeichnung
            // 
            this.ColumnAuftragsbezeichnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnAuftragsbezeichnung.DataPropertyName = "Auftragsbezeichnung";
            this.ColumnAuftragsbezeichnung.HeaderText = "Auftragsbezeichnung";
            this.ColumnAuftragsbezeichnung.Name = "ColumnAuftragsbezeichnung";
            this.ColumnAuftragsbezeichnung.ReadOnly = true;
            this.ColumnAuftragsbezeichnung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnAuftragsbezeichnung.Width = 113;
            // 
            // ColumnHRElement
            // 
            this.ColumnHRElement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnHRElement.DataPropertyName = "LstArt";
            this.ColumnHRElement.HeaderText = "LstArt";
            this.ColumnHRElement.MinimumWidth = 6;
            this.ColumnHRElement.Name = "ColumnHRElement";
            this.ColumnHRElement.ReadOnly = true;
            this.ColumnHRElement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnHRElement.Width = 40;
            // 
            // ColumnLeistungsart
            // 
            this.ColumnLeistungsart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnLeistungsart.DataPropertyName = "Leistungsart";
            this.ColumnLeistungsart.HeaderText = "Leistungsart";
            this.ColumnLeistungsart.Name = "ColumnLeistungsart";
            this.ColumnLeistungsart.ReadOnly = true;
            this.ColumnLeistungsart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnLeistungsart.Width = 70;
            // 
            // ColumnInvoice
            // 
            this.ColumnInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnInvoice.DataPropertyName = "Invoice";
            this.ColumnInvoice.HeaderText = "Einkaufsbeleg";
            this.ColumnInvoice.MinimumWidth = 6;
            this.ColumnInvoice.Name = "ColumnInvoice";
            this.ColumnInvoice.ReadOnly = true;
            this.ColumnInvoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnInvoice.Width = 80;
            // 
            // ColumnBemerkung
            // 
            this.ColumnBemerkung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnBemerkung.DataPropertyName = "Description";
            this.ColumnBemerkung.HeaderText = "Bemerkung";
            this.ColumnBemerkung.MinimumWidth = 6;
            this.ColumnBemerkung.Name = "ColumnBemerkung";
            this.ColumnBemerkung.ReadOnly = true;
            this.ColumnBemerkung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnBemerkung.Width = 67;
            // 
            // ColumnBookingElement
            // 
            this.ColumnBookingElement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColumnBookingElement.DataPropertyName = "BookingElement";
            this.ColumnBookingElement.HeaderText = "BookingElement";
            this.ColumnBookingElement.MinimumWidth = 6;
            this.ColumnBookingElement.Name = "ColumnBookingElement";
            this.ColumnBookingElement.ReadOnly = true;
            this.ColumnBookingElement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnBookingElement.Visible = false;
            this.ColumnBookingElement.Width = 90;
            // 
            // CopyDay
            // 
            this.CopyDay.Name = "CopyDay";
            this.CopyDay.Size = new System.Drawing.Size(180, 22);
            this.CopyDay.Text = "Copy Day";
            this.CopyDay.Click += new System.EventHandler(this.CopyDay_Click);
            // 
            // cmMain
            // 
            this.cmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.addEntryToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem});
            this.cmMain.Name = "cmMain";
            this.cmMain.Size = new System.Drawing.Size(181, 98);
            // 
            // copyDataToolStripMenuItem
            // 
            this.copyDataToolStripMenuItem.Name = "copyDataToolStripMenuItem";
            this.copyDataToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyDataToolStripMenuItem.Text = "Copy Data";
            this.copyDataToolStripMenuItem.Click += new System.EventHandler(this.copyDataToolStripMenuItem_Click);
            // 
            // addEntryToolStripMenuItem
            // 
            this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
            this.addEntryToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addEntryToolStripMenuItem.Text = "Add Entry";
            this.addEntryToolStripMenuItem.Click += new System.EventHandler(this.addEntryToolStripMenuItem_Click);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // LazyTimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1206, 289);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LazyTimeTracker";
            this.Text = "TimeTracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LazyTimeTracker_FormClosing);
            this.Load += new System.EventHandler(this.LazyTimeTracker_Load);
            this.Resize += new System.EventHandler(this.LazyTimeTracker_FormResize);
            this.cm1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip cm1;
        private System.Windows.Forms.ToolStripMenuItem neuerEintragToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVortag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAbAnArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuftragsbezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHRElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLeistungsart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBemerkung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBookingElement;
        private System.Windows.Forms.ToolStripMenuItem CopyDay;
        private System.Windows.Forms.ContextMenuStrip cmMain;
        private System.Windows.Forms.ToolStripMenuItem copyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
    }
}


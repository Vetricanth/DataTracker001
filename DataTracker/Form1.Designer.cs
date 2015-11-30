namespace DataTracker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.detailColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.completedColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateSubmittedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importanceColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageAppendRow = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPercentPaid = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.dtpSubmittionDate = new System.Windows.Forms.DateTimePicker();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbCompletion = new System.Windows.Forms.ComboBox();
            this.cbImportance = new System.Windows.Forms.ComboBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.hourlyUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isOnclickToToggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPageAppendRow.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageAppendRow);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.dgv);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(950, 262);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Info!";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.typeColumn,
            this.detailColumn,
            this.completedColumn,
            this.dateSubmittedColumn,
            this.importanceColumn,
            this.paidColumn,
            this.priceColumn,
            this.dueDateColumn});
            this.dgv.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(944, 256);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Items.AddRange(new object[] {
            "Comission",
            "Gift",
            "Trade"});
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // detailColumn
            // 
            this.detailColumn.HeaderText = "Detail";
            this.detailColumn.Name = "detailColumn";
            this.detailColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // completedColumn
            // 
            this.completedColumn.HeaderText = "Completed";
            this.completedColumn.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "35%",
            "40%",
            "45%",
            "50%",
            "55%",
            "60%",
            "65%",
            "70%",
            "75%",
            "80%",
            "85%",
            "90%",
            "95%",
            "100%"});
            this.completedColumn.Name = "completedColumn";
            this.completedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.completedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dateSubmittedColumn
            // 
            this.dateSubmittedColumn.HeaderText = "Date Submitted";
            this.dateSubmittedColumn.Name = "dateSubmittedColumn";
            // 
            // importanceColumn
            // 
            this.importanceColumn.HeaderText = "Importance";
            this.importanceColumn.Items.AddRange(new object[] {
            "HIGH",
            "Normal",
            "low"});
            this.importanceColumn.Name = "importanceColumn";
            this.importanceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.importanceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // paidColumn
            // 
            this.paidColumn.HeaderText = "Paid Ammount";
            this.paidColumn.Name = "paidColumn";
            this.paidColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            // 
            // dueDateColumn
            // 
            this.dueDateColumn.HeaderText = "Due";
            this.dueDateColumn.Name = "dueDateColumn";
            // 
            // tabPageAppendRow
            // 
            this.tabPageAppendRow.Controls.Add(this.label10);
            this.tabPageAppendRow.Controls.Add(this.cbPercentPaid);
            this.tabPageAppendRow.Controls.Add(this.priceBox);
            this.tabPageAppendRow.Controls.Add(this.dtpSubmittionDate);
            this.tabPageAppendRow.Controls.Add(this.dtp);
            this.tabPageAppendRow.Controls.Add(this.cbCompletion);
            this.tabPageAppendRow.Controls.Add(this.cbImportance);
            this.tabPageAppendRow.Controls.Add(this.btnDetails);
            this.tabPageAppendRow.Controls.Add(this.cbType);
            this.tabPageAppendRow.Controls.Add(this.nameBox);
            this.tabPageAppendRow.Controls.Add(this.btnClear);
            this.tabPageAppendRow.Controls.Add(this.btnAdd);
            this.tabPageAppendRow.Controls.Add(this.label9);
            this.tabPageAppendRow.Controls.Add(this.label8);
            this.tabPageAppendRow.Controls.Add(this.label7);
            this.tabPageAppendRow.Controls.Add(this.label6);
            this.tabPageAppendRow.Controls.Add(this.label5);
            this.tabPageAppendRow.Controls.Add(this.label4);
            this.tabPageAppendRow.Controls.Add(this.label3);
            this.tabPageAppendRow.Controls.Add(this.label2);
            this.tabPageAppendRow.Controls.Add(this.label1);
            this.tabPageAppendRow.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppendRow.Name = "tabPageAppendRow";
            this.tabPageAppendRow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppendRow.Size = new System.Drawing.Size(950, 262);
            this.tabPageAppendRow.TabIndex = 1;
            this.tabPageAppendRow.Text = "Add A Row!";
            this.tabPageAppendRow.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 65);
            this.label10.TabIndex = 25;
            this.label10.Text = "Please do not use \" | \", \" } \", or \" ` \" (The thing under \" ~ \")\r\n\r\nIt /will/ bre" +
    "ak the application\r\n\r\nDo not delete DataTracker.yiff in your documents folder, i" +
    "t\'s whre the data is saved.\r\n";
            // 
            // cbPercentPaid
            // 
            this.cbPercentPaid.Location = new System.Drawing.Point(347, 22);
            this.cbPercentPaid.Name = "cbPercentPaid";
            this.cbPercentPaid.Size = new System.Drawing.Size(100, 20);
            this.cbPercentPaid.TabIndex = 24;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(453, 22);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 23;
            this.priceBox.Text = "$0.00";
            // 
            // dtpSubmittionDate
            // 
            this.dtpSubmittionDate.Location = new System.Drawing.Point(9, 60);
            this.dtpSubmittionDate.Name = "dtpSubmittionDate";
            this.dtpSubmittionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSubmittionDate.TabIndex = 22;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(215, 60);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 21;
            // 
            // cbCompletion
            // 
            this.cbCompletion.FormattingEnabled = true;
            this.cbCompletion.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "35%",
            "40%",
            "45%",
            "50%",
            "55%",
            "60%",
            "65%",
            "70%",
            "75%",
            "80%",
            "85%",
            "90%",
            "95%",
            "100%"});
            this.cbCompletion.Location = new System.Drawing.Point(700, 20);
            this.cbCompletion.Name = "cbCompletion";
            this.cbCompletion.Size = new System.Drawing.Size(135, 21);
            this.cbCompletion.TabIndex = 16;
            // 
            // cbImportance
            // 
            this.cbImportance.FormattingEnabled = true;
            this.cbImportance.Items.AddRange(new object[] {
            "HIGH",
            "Normal",
            "low"});
            this.cbImportance.Location = new System.Drawing.Point(241, 20);
            this.cbImportance.Name = "cbImportance";
            this.cbImportance.Size = new System.Drawing.Size(100, 21);
            this.cbImportance.TabIndex = 14;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(159, 19);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(76, 23);
            this.btnDetails.TabIndex = 13;
            this.btnDetails.Text = "Click me";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Comission",
            "Gift",
            "Trade"});
            this.cbType.Location = new System.Drawing.Point(559, 20);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(135, 21);
            this.cbType.TabIndex = 12;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(9, 19);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 20);
            this.nameBox.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(498, 184);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(417, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estimated Completion Date:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Comission Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "$ paid so far";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Importance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Submitted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount completed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdateToolStripMenuItem,
            this.hourlyUpdatesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 70);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 3600000;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // hourlyUpdatesToolStripMenuItem
            // 
            this.hourlyUpdatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isOnclickToToggleToolStripMenuItem});
            this.hourlyUpdatesToolStripMenuItem.Name = "hourlyUpdatesToolStripMenuItem";
            this.hourlyUpdatesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.hourlyUpdatesToolStripMenuItem.Text = "Hourly Updates";
            // 
            // isOnclickToToggleToolStripMenuItem
            // 
            this.isOnclickToToggleToolStripMenuItem.Name = "isOnclickToToggleToolStripMenuItem";
            this.isOnclickToToggleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.isOnclickToToggleToolStripMenuItem.Text = "is on(click to toggle)";
            this.isOnclickToToggleToolStripMenuItem.Click += new System.EventHandler(this.isOnclickToToggleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 288);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Uhhhhhh, you shouldn\'t see this.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPageAppendRow.ResumeLayout(false);
            this.tabPageAppendRow.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPageAppendRow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cbCompletion;
        private System.Windows.Forms.ComboBox cbImportance;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpSubmittionDate;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox cbPercentPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewButtonColumn detailColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn completedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSubmittedColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn importanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        public System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ToolStripMenuItem hourlyUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isOnclickToToggleToolStripMenuItem;
    }
}


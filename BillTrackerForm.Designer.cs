namespace BillTracker
{
    partial class BillTrackerForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radShowHighlighted = new System.Windows.Forms.RadioButton();
            this.radShowAll = new System.Windows.Forms.RadioButton();
            this.lstBills = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calenderBills = new System.Windows.Forms.MonthCalendar();
            this.btMenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.groupBill = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAverageDue = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIsPaid = new System.Windows.Forms.Label();
            this.lblLastPayment = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblBillType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnEditBill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSplit = new System.Windows.Forms.Label();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkElectricEntered = new System.Windows.Forms.CheckBox();
            this.chkGarbageEntered = new System.Windows.Forms.CheckBox();
            this.chkCableEntered = new System.Windows.Forms.CheckBox();
            this.chkWaterEntered = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.btMenuStrip.SuspendLayout();
            this.groupBill.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radShowHighlighted);
            this.groupBox1.Controls.Add(this.radShowAll);
            this.groupBox1.Controls.Add(this.lstBills);
            this.groupBox1.Controls.Add(this.calenderBills);
            this.groupBox1.Location = new System.Drawing.Point(12, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // radShowHighlighted
            // 
            this.radShowHighlighted.AutoSize = true;
            this.radShowHighlighted.Location = new System.Drawing.Point(514, 189);
            this.radShowHighlighted.Name = "radShowHighlighted";
            this.radShowHighlighted.Size = new System.Drawing.Size(134, 17);
            this.radShowHighlighted.TabIndex = 8;
            this.radShowHighlighted.TabStop = true;
            this.radShowHighlighted.Text = "Show Highlighted Date";
            this.radShowHighlighted.UseVisualStyleBackColor = true;
            this.radShowHighlighted.CheckedChanged += new System.EventHandler(this.radShowHighlighted_CheckedChanged);
            // 
            // radShowAll
            // 
            this.radShowAll.AutoSize = true;
            this.radShowAll.Checked = true;
            this.radShowAll.Location = new System.Drawing.Point(415, 189);
            this.radShowAll.Name = "radShowAll";
            this.radShowAll.Size = new System.Drawing.Size(87, 17);
            this.radShowAll.TabIndex = 8;
            this.radShowAll.TabStop = true;
            this.radShowAll.Text = "Show All Bills";
            this.radShowAll.UseVisualStyleBackColor = true;
            this.radShowAll.CheckedChanged += new System.EventHandler(this.radShowAll_CheckedChanged);
            // 
            // lstBills
            // 
            this.lstBills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstBills.FullRowSelect = true;
            this.lstBills.Location = new System.Drawing.Point(6, 19);
            this.lstBills.Name = "lstBills";
            this.lstBills.Size = new System.Drawing.Size(397, 158);
            this.lstBills.TabIndex = 5;
            this.lstBills.UseCompatibleStateImageBehavior = false;
            this.lstBills.View = System.Windows.Forms.View.Details;
            this.lstBills.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstBills_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bill Type";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount Due";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Due Date";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Is Paid?";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Overdue?";
            this.columnHeader5.Width = 59;
            // 
            // calenderBills
            // 
            this.calenderBills.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.calenderBills.Location = new System.Drawing.Point(415, 15);
            this.calenderBills.Name = "calenderBills";
            this.calenderBills.ShowToday = false;
            this.calenderBills.TabIndex = 4;
            this.calenderBills.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calenderBills_DateChanged);
            // 
            // btMenuStrip
            // 
            this.btMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.btMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.btMenuStrip.Name = "btMenuStrip";
            this.btMenuStrip.Size = new System.Drawing.Size(672, 24);
            this.btMenuStrip.TabIndex = 1;
            this.btMenuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.Location = new System.Drawing.Point(6, 10);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(190, 34);
            this.btnAddBill.TabIndex = 1;
            this.btnAddBill.Text = "Add New Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // groupBill
            // 
            this.groupBill.Controls.Add(this.label7);
            this.groupBill.Controls.Add(this.label6);
            this.groupBill.Controls.Add(this.lblAverageDue);
            this.groupBill.Controls.Add(this.lblId);
            this.groupBill.Controls.Add(this.lblIsPaid);
            this.groupBill.Controls.Add(this.lblLastPayment);
            this.groupBill.Controls.Add(this.lblDueDate);
            this.groupBill.Controls.Add(this.lblAmountDue);
            this.groupBill.Controls.Add(this.lblBillType);
            this.groupBill.Controls.Add(this.label5);
            this.groupBill.Controls.Add(this.lblOverdue);
            this.groupBill.Controls.Add(this.label4);
            this.groupBill.Controls.Add(this.label3);
            this.groupBill.Controls.Add(this.lblBillId);
            this.groupBill.Controls.Add(this.label2);
            this.groupBill.Location = new System.Drawing.Point(12, 27);
            this.groupBill.Name = "groupBill";
            this.groupBill.Size = new System.Drawing.Size(450, 255);
            this.groupBill.TabIndex = 5;
            this.groupBill.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Last Payment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Average Due:";
            // 
            // lblAverageDue
            // 
            this.lblAverageDue.AutoSize = true;
            this.lblAverageDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageDue.Location = new System.Drawing.Point(324, 83);
            this.lblAverageDue.Name = "lblAverageDue";
            this.lblAverageDue.Size = new System.Drawing.Size(0, 20);
            this.lblAverageDue.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(324, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 6;
            // 
            // lblIsPaid
            // 
            this.lblIsPaid.AutoSize = true;
            this.lblIsPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsPaid.Location = new System.Drawing.Point(102, 174);
            this.lblIsPaid.Name = "lblIsPaid";
            this.lblIsPaid.Size = new System.Drawing.Size(0, 20);
            this.lblIsPaid.TabIndex = 6;
            // 
            // lblLastPayment
            // 
            this.lblLastPayment.AutoSize = true;
            this.lblLastPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPayment.Location = new System.Drawing.Point(318, 129);
            this.lblLastPayment.Name = "lblLastPayment";
            this.lblLastPayment.Size = new System.Drawing.Size(0, 20);
            this.lblLastPayment.TabIndex = 6;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(102, 129);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(0, 20);
            this.lblDueDate.TabIndex = 6;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(102, 83);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(0, 20);
            this.lblAmountDue.TabIndex = 6;
            // 
            // lblBillType
            // 
            this.lblBillType.AutoSize = true;
            this.lblBillType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillType.Location = new System.Drawing.Point(102, 38);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(0, 20);
            this.lblBillType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Is Paid:";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdue.ForeColor = System.Drawing.Color.Red;
            this.lblOverdue.Location = new System.Drawing.Point(192, 171);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(211, 23);
            this.lblOverdue.TabIndex = 5;
            this.lblOverdue.Text = "*** OVERDUE ***";
            this.lblOverdue.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Due Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Due:";
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.Location = new System.Drawing.Point(281, 43);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(37, 13);
            this.lblBillId.TabIndex = 2;
            this.lblBillId.Text = "Bill ID:";
            this.lblBillId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill Type:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnDeleteBill);
            this.groupBox3.Controls.Add(this.btnEditBill);
            this.groupBox3.Controls.Add(this.btnAddBill);
            this.groupBox3.Location = new System.Drawing.Point(458, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 255);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Enabled = false;
            this.btnDeleteBill.Location = new System.Drawing.Point(6, 90);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(190, 34);
            this.btnDeleteBill.TabIndex = 2;
            this.btnDeleteBill.Text = "Delete Bill";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnEditBill
            // 
            this.btnEditBill.Enabled = false;
            this.btnEditBill.Location = new System.Drawing.Point(6, 50);
            this.btnEditBill.Name = "btnEditBill";
            this.btnEditBill.Size = new System.Drawing.Size(190, 34);
            this.btnEditBill.TabIndex = 2;
            this.btnEditBill.Text = "Edit Bill";
            this.btnEditBill.UseVisualStyleBackColor = true;
            this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkWaterEntered);
            this.groupBox2.Controls.Add(this.chkCableEntered);
            this.groupBox2.Controls.Add(this.chkGarbageEntered);
            this.groupBox2.Controls.Add(this.chkElectricEntered);
            this.groupBox2.Controls.Add(this.lblSplit);
            this.groupBox2.Controls.Add(this.lblTotalDue);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(0, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bills Logged This Month";
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplit.Location = new System.Drawing.Point(126, 94);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(0, 20);
            this.lblSplit.TabIndex = 18;
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDue.Location = new System.Drawing.Point(126, 72);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(0, 20);
            this.lblTotalDue.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total Due This Month:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Split 3-Ways:";
            // 
            // chkElectricEntered
            // 
            this.chkElectricEntered.AutoCheck = false;
            this.chkElectricEntered.AutoSize = true;
            this.chkElectricEntered.Location = new System.Drawing.Point(31, 25);
            this.chkElectricEntered.Name = "chkElectricEntered";
            this.chkElectricEntered.Size = new System.Drawing.Size(61, 17);
            this.chkElectricEntered.TabIndex = 23;
            this.chkElectricEntered.Text = "Electric";
            this.chkElectricEntered.UseVisualStyleBackColor = true;
            // 
            // chkGarbageEntered
            // 
            this.chkGarbageEntered.AutoCheck = false;
            this.chkGarbageEntered.AutoSize = true;
            this.chkGarbageEntered.Location = new System.Drawing.Point(31, 47);
            this.chkGarbageEntered.Name = "chkGarbageEntered";
            this.chkGarbageEntered.Size = new System.Drawing.Size(67, 17);
            this.chkGarbageEntered.TabIndex = 23;
            this.chkGarbageEntered.Text = "Garbage";
            this.chkGarbageEntered.UseVisualStyleBackColor = true;
            // 
            // chkCableEntered
            // 
            this.chkCableEntered.AutoCheck = false;
            this.chkCableEntered.AutoSize = true;
            this.chkCableEntered.Location = new System.Drawing.Point(116, 24);
            this.chkCableEntered.Name = "chkCableEntered";
            this.chkCableEntered.Size = new System.Drawing.Size(53, 17);
            this.chkCableEntered.TabIndex = 23;
            this.chkCableEntered.Text = "Cable";
            this.chkCableEntered.UseVisualStyleBackColor = true;
            // 
            // chkWaterEntered
            // 
            this.chkWaterEntered.AutoCheck = false;
            this.chkWaterEntered.AutoSize = true;
            this.chkWaterEntered.Location = new System.Drawing.Point(116, 46);
            this.chkWaterEntered.Name = "chkWaterEntered";
            this.chkWaterEntered.Size = new System.Drawing.Size(55, 17);
            this.chkWaterEntered.TabIndex = 23;
            this.chkWaterEntered.Text = "Water";
            this.chkWaterEntered.UseVisualStyleBackColor = true;
            // 
            // BillTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 497);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btMenuStrip);
            this.Controls.Add(this.groupBill);
            this.KeyPreview = true;
            this.MainMenuStrip = this.btMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillTrackerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillTrackerForm_FormClosing);
            this.Load += new System.EventHandler(this.BillTrackerForm_Load);
            this.Shown += new System.EventHandler(this.BillTrackerForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillTrackerForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.btMenuStrip.ResumeLayout(false);
            this.btMenuStrip.PerformLayout();
            this.groupBill.ResumeLayout(false);
            this.groupBill.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip btMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar calenderBills;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.ListView lstBills;
        private System.Windows.Forms.GroupBox groupBill;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblIsPaid;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAverageDue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLastPayment;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.RadioButton radShowHighlighted;
        private System.Windows.Forms.RadioButton radShowAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkWaterEntered;
        private System.Windows.Forms.CheckBox chkCableEntered;
        private System.Windows.Forms.CheckBox chkGarbageEntered;
        private System.Windows.Forms.CheckBox chkElectricEntered;
    }
}


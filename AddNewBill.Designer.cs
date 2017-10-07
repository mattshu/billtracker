namespace BillTracker
{
    partial class AddNewBill
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
            this.radPaid = new System.Windows.Forms.RadioButton();
            this.radNotPaid = new System.Windows.Forms.RadioButton();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.cbxBillTypes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddExit = new System.Windows.Forms.Button();
            this.btnAddNext = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radPaid
            // 
            this.radPaid.AutoSize = true;
            this.radPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaid.ForeColor = System.Drawing.Color.ForestGreen;
            this.radPaid.Location = new System.Drawing.Point(311, 171);
            this.radPaid.Name = "radPaid";
            this.radPaid.Size = new System.Drawing.Size(62, 24);
            this.radPaid.TabIndex = 4;
            this.radPaid.Text = "Paid";
            this.radPaid.UseVisualStyleBackColor = true;
            // 
            // radNotPaid
            // 
            this.radNotPaid.AutoSize = true;
            this.radNotPaid.Checked = true;
            this.radNotPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNotPaid.ForeColor = System.Drawing.Color.Firebrick;
            this.radNotPaid.Location = new System.Drawing.Point(127, 171);
            this.radNotPaid.Name = "radNotPaid";
            this.radNotPaid.Size = new System.Drawing.Size(95, 24);
            this.radNotPaid.TabIndex = 3;
            this.radNotPaid.TabStop = true;
            this.radNotPaid.Text = "Not Paid";
            this.radNotPaid.UseVisualStyleBackColor = true;
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDue.Location = new System.Drawing.Point(151, 76);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.Size = new System.Drawing.Size(137, 26);
            this.txtAmountDue.TabIndex = 1;
            this.txtAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountDue.TextChanged += new System.EventHandler(this.txtAmountDue_TextChanged);
            this.txtAmountDue.Leave += new System.EventHandler(this.txtAmountDue_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Due Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount Due:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bill Type:";
            // 
            // dateDueDate
            // 
            this.dateDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDueDate.Location = new System.Drawing.Point(151, 120);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(268, 26);
            this.dateDueDate.TabIndex = 2;
            // 
            // cbxBillTypes
            // 
            this.cbxBillTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBillTypes.FormattingEnabled = true;
            this.cbxBillTypes.Items.AddRange(new object[] {
            "Electric",
            "Cable",
            "Water",
            "Garbage"});
            this.cbxBillTypes.Location = new System.Drawing.Point(151, 36);
            this.cbxBillTypes.Name = "cbxBillTypes";
            this.cbxBillTypes.Size = new System.Drawing.Size(137, 21);
            this.cbxBillTypes.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(379, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAddExit
            // 
            this.btnAddExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddExit.Location = new System.Drawing.Point(256, 224);
            this.btnAddExit.Name = "btnAddExit";
            this.btnAddExit.Size = new System.Drawing.Size(117, 23);
            this.btnAddExit.TabIndex = 5;
            this.btnAddExit.Text = "Add Once";
            this.btnAddExit.UseVisualStyleBackColor = true;
            this.btnAddExit.Click += new System.EventHandler(this.btnAddExit_Click);
            // 
            // btnAddNext
            // 
            this.btnAddNext.Location = new System.Drawing.Point(133, 224);
            this.btnAddNext.Name = "btnAddNext";
            this.btnAddNext.Size = new System.Drawing.Size(117, 23);
            this.btnAddNext.TabIndex = 6;
            this.btnAddNext.Text = "Add Next";
            this.btnAddNext.UseVisualStyleBackColor = true;
            this.btnAddNext.Click += new System.EventHandler(this.btnAddNext_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(348, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 11;
            // 
            // AddNewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 259);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAddNext);
            this.Controls.Add(this.btnAddExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radPaid);
            this.Controls.Add(this.radNotPaid);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.cbxBillTypes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewBill_FormClosing);
            this.Shown += new System.EventHandler(this.AddNewBill_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radPaid;
        private System.Windows.Forms.RadioButton radNotPaid;
        private System.Windows.Forms.TextBox txtAmountDue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDueDate;
        private System.Windows.Forms.ComboBox cbxBillTypes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddExit;
        private System.Windows.Forms.Button btnAddNext;
        private System.Windows.Forms.Label lblId;
    }
}
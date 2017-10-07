using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BillTracker
{
    public partial class AddNewBill : Form
    {
        public AddNewBill(int editId = 0)
        {
            InitializeComponent();
            EditId = editId;
        }

        public Bill NewBill;
        public bool StopClosing;
        public readonly int EditId;

        public void MaskAmountDue()
        {
            var t = txtAmountDue.Text;
            if (Regex.Matches(t, @"[a-zA-Z]").Count > 0)
                txtAmountDue.Text = "";
            if (string.IsNullOrEmpty(t) || t == "0") return;
            if (t.Length <= 2)
                t = t.PadLeft(3, '0');
            if (!t.Contains('$'))
                t = $"${t}";
            if (!t.Contains('.'))
                t = t.Insert(t.Length - 2, ".");
            txtAmountDue.Text = t;
        }

        public bool ValidateInputs()
        {
            return cbxBillTypes.SelectedIndex != -1 && !string.IsNullOrEmpty(txtAmountDue.Text.Replace("$", ""));
        }
        private void ResetAddBillForm()
        {
            cbxBillTypes.SelectedIndex = -1;
            txtAmountDue.ResetText();
            dateDueDate.ResetText();
            radNotPaid.Checked = radPaid.Checked = false;
        }
        private void AddNewBillFromData()
        {
            if (!ValidateInputs())
            {
                ErrorHandler.Error("More details required.");
                return;
            }
            var id = EditId != 0 ? EditId : 1 + BillTrackerForm.Bills.Max(x => x.Id);
            NewBill = new Bill
            {
                Id = id,
                BillType = (BillType)cbxBillTypes.SelectedIndex,
                Amount = Convert.ToDouble(txtAmountDue.Text.Replace("$", "")),
                DueDate = dateDueDate.Value,
                IsPaid = radPaid.Checked
            }; 
        }
        private void btnAddNext_Click(object sender, EventArgs e)
        {
            AddNewBillFromData();
            btnAddExit.Text = "Finish";
            ResetAddBillForm();
        }

        private void txtAmountDue_Leave(object sender, EventArgs e)
        {
            MaskAmountDue();
        }

        private void AddNewBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = StopClosing;
            StopClosing = false;
        }

        private void btnAddExit_Click(object sender, EventArgs e)
        {
            if (btnAddExit.Text == "Finish")
            { 
                ActiveForm.Close();
                return;
            }
            AddNewBillFromData();
        }

        private void txtAmountDue_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddNewBill_Shown(object sender, EventArgs e)
        {
            if (EditId == 0)
                return;
            var bills = BillTrackerForm.Bills;
            var id = EditId;
            lblId.Text = "ID: " + id;
            ActiveForm.Text = "Edit Bill";
            btnAddExit.Text = "Save Changes";
            btnAddNext.Visible = false;
            //id,type,amount,due,paid
            var data = bills.Where(b => b.Id == id).Select(b => b).FirstOrDefault();
            if (data == null)
            {
                ErrorHandler.Error("An error has occured. data == null");
                return;
            }
            cbxBillTypes.SelectedIndex = (int)data.BillType;
            txtAmountDue.Text = data.Amount.ToString(CultureInfo.InvariantCulture);
            dateDueDate.Value = data.DueDate;
            if (data.IsPaid)
                radPaid.Checked = true;
            else radNotPaid.Checked = true;
        }
    }
}

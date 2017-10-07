using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillTracker.Properties;


namespace BillTracker
{
    public partial class BillTrackerForm : Form
    {
        public BillTrackerForm() { InitializeComponent(); }
        private const string DEFAULT_PATH = @"C:\Users\shu\Desktop\billtracker.csv";
        public static List<Bill> Bills;
        public int ActiveBillId;

        private void BillTrackerForm_Load(object sender, EventArgs e)
        {
            //Before form appears
            Bills = new List<Bill>();
            var path = Settings.Default.PathToDB;
            if (path == null)
                Settings.Default.PathToDB = DEFAULT_PATH;
            else
            {
                try
                {
                    LoadFromCSV(path);
                }
                catch (FileNotFoundException)
                {
                    Console.Error.WriteLine("File not found");
                }
            }
        }
        private void BillTrackerForm_Shown(object sender, EventArgs e)
        {
            UpdateBillList();
        }
        private void calenderBills_DateChanged(object sender, DateRangeEventArgs e)
        {
            radShowHighlighted.Checked = true;
            if (Bills.Count(x => x.DueDate == e.Start) <= 0)
            {
                lstBills.Items.Clear();
                return;
            }
            UpdateBillList(date: e.Start);
        }
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            OpenAddBillDialog();
        }
        private void OpenAddBillDialog(int editId = 0)
        {
            var addBill = new AddNewBill(editId);
            if (addBill.ShowDialog() != DialogResult.OK || addBill.NewBill == null) return;
            if (addBill.EditId <= 0)
                Bills.Add(addBill.NewBill);
            else
                Bills[Bills.FindIndex(x => x.Id == addBill.EditId)] = addBill.NewBill;
            PopulateLabelData(editId);
            UpdateBillList();
        }
        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this bill?", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) != DialogResult.Yes || lstBills.SelectedItems.Count <= 0) return;
            var index = lstBills.SelectedItems[0].Index;
            lstBills.Items[index].Remove();
            //###########################################Bills.RemoveAt(Bills);
        }
        private void btnEditBill_Click(object sender, EventArgs e)
        {
            OpenAddBillDialog(ActiveBillId);
        }
        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            var options = new Options();
            if (options.ShowDialog() != DialogResult.OK) return;
            if (!options.LoadOnSave) return;
            LoadFromCSV(Settings.Default.PathToDB);
            UpdateBillList();
        }
        private void lstBills_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                btnDeleteBill.Enabled = false;
                btnEditBill.Enabled = false;
                return;
            }
            btnDeleteBill.Enabled = true;
            btnEditBill.Enabled = true;
            ActiveBillId = Convert.ToInt32(e.Item.SubItems[0].Tag);
            PopulateLabelData(ActiveBillId);
        }
        private void radShowHighlighted_CheckedChanged(object sender, EventArgs e)
        {
            if (radShowHighlighted.Checked)
            {
                UpdateBillList(calenderBills.SelectionStart);
                calenderBills.Focus();
            }
        }
        private void radShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radShowAll.Checked)
                UpdateBillList();
        }
        private void BillTrackerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ActiveForm.Close();
        }
        private void BillTrackerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveToCSV(Settings.Default.PathToDB);
            }
            catch (FileNotFoundException)
            {
                ErrorHandler.Error("Unable to save database to given location. Please check the location for future saves.\n\nData will be saved to default location.");
                SaveToCSV(Settings.Default.DefaultPathToDB);
            }
        }
        public void LoadFromCSV(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException();
            Bills.Clear();
            var billsFromCSV = File.ReadAllLines(path);
            foreach (var b in billsFromCSV)
                Bills.Add(new Bill().FromCSV(b));
            SortBillList();
        }
        public void SortBillList()
        {
            Bills = Bills.OrderByDescending(o => o.DueDate).ToList();
        }
        public void SaveToCSV(string path)
        {
            string[] csv = Bills.Select(x => x.ToString()).ToArray();
            try
            {
                File.WriteAllLines(path, csv);
            }
            catch (Exception e)
            {
                ErrorHandler.Error("Unable to write to database file:\n\n" + e.Message);
            }
        }
        public void UpdateBillList(DateTime? date = null)
        {
            if (Bills.Count <= 0) return;
            lstBills.Items.Clear();
            SortBillList();
            var lvis = new List<ListViewItem>();
            var billData = Bills;
            if (date.HasValue)
                billData = Bills.Where(x => x.DueDate.ToString("MM/dd/yyyy") == date.Value.ToString("MM/dd/yyyy")).ToList();
            if (billData.Count == 0) return;
            for (int i = 0; i < billData.Count; i++)
            {
                //id,type,amount,duedate,ispaid
                var b = billData[i].ToString().Split(',');
                lvis.Add(new ListViewItem(b[1], 0));
                lvis[i].SubItems.Add("$" + b[2]);
                lvis[i].SubItems[0].Tag = b[0];
                lvis[i].SubItems.Add(b[3]);
                lvis[i].SubItems.Add(Convert.ToBoolean(b[4]) ? "Yes" : "No");
                var overdue = DateTime.Now.Subtract(Convert.ToDateTime(b[3])).CompareTo(TimeSpan.Zero) > 0 && !Convert.ToBoolean(b[4]);
                lvis[i].SubItems.Add(overdue ? "Yes" : "No");
                lstBills.Items.Add(lvis[i]);
                calenderBills.AddBoldedDate(Convert.ToDateTime(b[3]));
            }
            var checkMonth = billData.Where(b => b.DueDate.Month == DateTime.Now.Month).ToList();
            if (checkMonth.Count <= 0) return;
            foreach (var c in checkMonth)
            {
                switch (c.BillType)
                {
                    case BillType.Electric:
                        chkElectricEntered.Checked = true;
                        break;
                    case BillType.Cable:
                        chkCableEntered.Checked = true;
                        break;
                    case BillType.Garbage:
                        chkGarbageEntered.Checked = true;
                        break;
                    case BillType.Water:
                        chkWaterEntered.Checked = true;
                        break;
                }
            }

        }
        private async void FlashOverdueLabel()
        {
            int i = 2;
            while (i-- >= 0)
            {
                await Task.Delay(100);
                lblOverdue.Visible = !lblOverdue.Visible;
            }
        }
        private void PopulateLabelData(int billId = 0)
        {
            if (billId == 0) return;
            lblOverdue.Visible = false;
            var b = Bills.Where(x => x.Id == billId).ToArray()[0];

            lblBillType.Text = b.BillType.ToString();
            lblId.Text = ActiveBillId.ToString();

            lblAmountDue.Text = "$" + b.Amount.ToString(CultureInfo.InvariantCulture);
            lblAverageDue.Text = "$" + Math.Round(Bills.Where(x => x.BillType == b.BillType).Average(x => x.Amount), 2)
                                     .ToString(CultureInfo.InvariantCulture);

            lblDueDate.Text = b.DueDate.ToString("MM/dd/yyyy");
            lblLastPayment.Text = "";

            lblIsPaid.Text = b.IsPaid ? "Yes" : "No";
            if (DateTime.Now.Subtract(b.DueDate).CompareTo(TimeSpan.Zero) > 0 && !b.IsPaid) FlashOverdueLabel();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillTracker.Properties;

namespace BillTracker
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        public bool LoadOnSave => chkLoadOnSave.Checked;
        private bool CancelClose = false;

        private void Options_Load(object sender, EventArgs e)
        {
            txtPathToDB.Text = Settings.Default.PathToDB;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtPathToDB.Text))
            {
                //MessageBox.Show("File not found", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //CancelClose = true;
                if (MessageBox.Show("File doesn't exist. Do you want to create a new database file?",
                        "Create new database file", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    File.WriteAllText(txtPathToDB.Text, "");
                }

            }
            Settings.Default.PathToDB = txtPathToDB.Text ?? Settings.Default.DefaultPathToDB;

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var browse = openDatabaseFile;
            if (browse.ShowDialog() == DialogResult.OK)
                txtPathToDB.Text = browse.FileName;
        }

        private void txtPathToDB_TextChanged(object sender, EventArgs e)
        {
            if (txtPathToDB.Text != Settings.Default.PathToDB)
                chkLoadOnSave.Visible = true;
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CancelClose)
                e.Cancel = true;
            else
                Settings.Default.Save();
            CancelClose = false;
        }


    }
}

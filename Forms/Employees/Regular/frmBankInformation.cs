#region

using System;
using System.Media;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Employees.Regular {
    public partial class frmBankInformation : Form {
        public frmBankInformation() {
            InitializeComponent();
        }

        private void btnChangeNumbers_Click(object sender, EventArgs e) {
            tbxAccount.Enabled = true;
            tbxRouting.Enabled = true;

            btnChangeNumbers.Enabled = false;
            btnConfirmNewDeposit.Enabled = true;
        }

        private void frmBankInformation_Load(object sender, EventArgs e) {
            ProgOps.populateBanking(tbxName, tbxEmail, tbxAccountID, tbxAccount, tbxRouting);
        }

        private void tbxAccount_KeyPress(object sender, KeyPressEventArgs e) {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) {
                e.Handled = false;
            } else if (e.KeyChar == 13) {
                tbxAccount.Focus();
            } else {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void tbxRouting_KeyPress(object sender, KeyPressEventArgs e) {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8)) {
                e.Handled = false;
            } else if (e.KeyChar == 13) {
                tbxAccount.Focus();
            } else {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void btnConfirmNewDeposit_Click(object sender, EventArgs e)
        {
            if (tbxAccount.Text != string.Empty && tbxRouting.Text != string.Empty)
            {
                if (tbxRouting.Text.Length != 9 || tbxAccount.Text.Length != 17)
                {
                    MessageBox.Show("Account or Routing is too short", "Banking Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ProgOps.updateAccountRouting(tbxAccount.Text, tbxRouting.Text);
                    tbxAccount.Enabled = false;
                    tbxRouting.Enabled = false;
                    btnChangeNumbers.Enabled = true;
                    btnConfirmNewDeposit.Enabled = false;
                    MessageBox.Show("Account and Routing changed", "Banking Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            else
            {
                MessageBox.Show("Account or Routing number cannot be empty", "Banking Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
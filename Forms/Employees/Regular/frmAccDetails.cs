#region

using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Forms.Login;
#endregion

namespace BCD_Restaurant_Project.Forms.Employees.Regular {
    public partial class frmAccDetails : Form {
        public frmAccDetails() {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e) {
            ProgOps.fillInPersonalInformation(tbxAccountID, tbxEmail, tbxUsername, tbxName, tbxPassword);
        }

        

        private void btnChangeInformation_Click(object sender, EventArgs e)
        {
            tbxPassword.Enabled = true;
            tbxAddress.Enabled = true;
            tbxEmail.Enabled = true;
            tbxPhone.Enabled = true;
            tbxUsername.Enabled = true;
        }

        private void btnConfirmInformation_Click(object sender, EventArgs e)
        {
            if (!ProgOps.isValidEmail(tbxEmail.Text))
            {
                MessageBox.Show("Invalid email", "Password", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

         



            if (tbxPassword.Text != string.Empty)
            {
                ProgOps.generatePassword(1, tbxPassword.Text);
                
                tbxPassword.Enabled = false;
                tbxAddress.Enabled = false;
                tbxEmail.Enabled = false;
                tbxPhone.Enabled = false;
                tbxUsername.Enabled = false;
                ProgOps.updateAccountDetails(tbxAddress.Text, tbxEmail.Text, tbxUsername.Text, tbxPhone.Text);
            }
            else
            {
                MessageBox.Show("Password cannot be empty", "Password", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar >= '0') && (e.KeyChar <= '9'))||e.KeyChar==8)
            {
                e.Handled = false;
            }else if (e.KeyChar == 13)
            {
                tbxPhone.Focus();
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
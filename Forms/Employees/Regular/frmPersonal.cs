#region

using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Forms.Login;
#endregion

namespace BCD_Restaurant_Project.Forms.Employees.Regular {
    public partial class frmPersonal : Form {
        public frmPersonal() {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e) {
            ProgOps.fillInPersonalInformation(tbxAccountID, tbxEmail, tbxUsername, tbxName, tbxPassword);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            tbxPassword.Enabled = true;
                       
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text != string.Empty)
            {
                ProgOps.generatePassword(1, tbxPassword.Text);
                MessageBox.Show("Password has been changed", "Password", MessageBoxButtons.OK, MessageBoxIcon.None);
                tbxPassword.Enabled = false;
            }
            else
            {
                MessageBox.Show("Password cannot be empty", "Password", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
#region

using System;
using System.Windows.Forms;

using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Login {
    public partial class frmNewPassword : Form {
        public frmNewPassword() {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            if (tbxConfirm.Text == tbxPassword.Text) {
                ProgOps.generatePassword(1, tbxPassword.Text);
                Close();
                MessageBox.Show("Password has been changed", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.None);
            } else {
                lblNoMatch.Enabled = true;
            }
        }

    }
}
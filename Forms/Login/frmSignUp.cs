#region

using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Login {
    public partial class frmSignUp : Form {
        public frmSignUp() {
            InitializeComponent();
        }

        private void lnkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            bool emailOK = ProgOps.isValidEmail(tbxEmail.Text);

            if (emailOK)
                ProgOps.insertNewAccount(tbxFirstname.Text, tbxLastName.Text, tbxUsername.Text, tbxEmail.Text,
                                         tbxPassword.Text);
            else
                MessageBox.Show("Enter a valid email address.", "Sign Up", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e) {
            ProgOps.closeDatabase();
        }
    }
}
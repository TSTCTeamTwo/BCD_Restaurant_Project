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

        private void pnlLogin_Paint(object sender, PaintEventArgs e) { }

        private void btnConfirm_Click(object sender, EventArgs e) {
            if (tbxConfirm.Text == tbxPassword.Text) {
                ProgOps.generatePassword(1, tbxPassword.Text);
                Hide();
                new frmLogin().Show();
            } else {
                lblNoMatch.Enabled = true;
            }
        }

        private void lnkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Hide();
            new frmLogin().Show();
        }
    }
}
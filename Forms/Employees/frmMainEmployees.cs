#region

using System;
using System.Windows.Forms;

#endregion

namespace BCD_Restaurant_Project.Forms.Employees {
    public partial class frmMainEmployees : Form {
        private Form activeForm;

        public frmMainEmployees() {
            InitializeComponent();
        }

        private void btnPaycheck_Click(object sender, EventArgs e) {
            OpenChildForm(new frmPaycheck(), sender);
        }

        private void btnPersonal_Click(object sender, EventArgs e) {
            OpenChildForm(new frmPersonal(), sender);
        }

        private void btnBankInformation_Click(object sender, EventArgs e) {
            OpenChildForm(new frmBankInformation(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDisplay.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Confirm log out. ", "Log Out", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Hide();
                new frmLogin().Show();
            }
        }
    }
}
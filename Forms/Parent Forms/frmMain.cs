#region

using System;
using System.Drawing;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Forms.Customers;
using BCD_Restaurant_Project.Forms.Customers.Menu;
using BCD_Restaurant_Project.Forms.Customers.Order;
using BCD_Restaurant_Project.Forms.Login;

#endregion

namespace BCD_Restaurant_Project.Forms.Main {
    public partial class frmMain : Form {
        private Form activeForm;

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            RandomColor.setFormColors(this); //sets the theme colors
        }

        private void OpenChildForm(Form childForm, object btnSender) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            childForm.Location = new Point((pnlDisplay.ClientSize.Width - childForm.Width) / 2,
                                           (pnlDisplay.ClientSize.Height - childForm.Height) / 2);
            pnlDisplay.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            RandomColor.setFormColors(childForm);
            lblTitle.Text = childForm.Text;
        }

        private void btnFood_Click(object sender, EventArgs e) {
            OpenChildForm(new frmFood(), sender);
        }

        private void btnDrinks_Click(object sender, EventArgs e) {
            OpenChildForm(new frmDrinks(), sender);
        }

        private void btnDesserts_Click(object sender, EventArgs e) {
            OpenChildForm(new frmDesserts(), sender);
        }

        private void btnCheckout_Click_1(object sender, EventArgs e) {
            OpenChildForm(new frmOrder(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            performLogout();
        }

        private void btnDashboard_Click(object sender, EventArgs e) {
            if (activeForm != null)
                activeForm.Close();

            lblTitle.Text = "Dashboard";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            performLogout();
        }

        private void performLogout() {
            DialogResult result = MessageBox.Show("Confirm log out. ", "Log Out", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Hide();
                ProgOps.login.Show();
            }
            else if(result == DialogResult.No)
            {
                return;
            }

        }
    }
}
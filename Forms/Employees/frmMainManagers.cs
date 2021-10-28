using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Forms.Employees;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmMainManagers : Form
    {
        private Form activeForm;
        public frmMainManagers()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageAccounts(), sender);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmManageMenu(), sender);
        }

        private void btnDirectDeposit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBankInformation(), sender);
        }

        private void frmMainManagers_Load(object sender, EventArgs e)
        {
            ProgOps.openDatabase();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {


                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDisplay.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm log out. ", "Log Out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new frmLogin().Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

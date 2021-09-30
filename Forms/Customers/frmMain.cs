using System;
using System.Linq;
using System.Windows.Forms;

namespace BCD_Restaurant_Project.Forms
{
    public partial class frmMain : Form
    {
        private Form activeForm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hello World!", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

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

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmFood(), sender);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDrinks(), sender);
        }

        private void btnDesserts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDesserts(), sender);
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrder(), sender);
        }
    }
}

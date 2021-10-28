using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Forms.Customers;
using BCD_Restaurant_Project.Forms.Employees;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmNewPassword : Form
    {
        public frmNewPassword()
        {
            InitializeComponent();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(tbxConfirm.Text == tbxPassword.Text)
            {
                ProgOps.generatePassword(1, tbxPassword.Text);
                this.Hide();
                new frmLogin().Show();
            }
            else
            {
                lblNoMatch.Enabled = true;
            }
        }

        private void lnkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }
    }
}

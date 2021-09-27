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
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void lnkReturn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxFirstname.Text.Equals("") || tbxLastName.Text.Equals(""))
            {
                lblEmpty.Text = "Enter a first name and last name";
            }
            if (tbxEmail.Text.Equals(""))
            {
                lblEmpty.Text = "Enter an email";
            }
            if (tbxUsername.Text.Equals(""))
            {
                lblEmpty.Text = "Enter a username";
            }
            if (tbxPassword.Text.Equals(""))
            {
                lblEmpty.Text = "Enter a password";

            }
            ProgOps.SignUp(tbxFirstname.Text, tbxLastName.Text, tbxUsername.Text, tbxEmail.Text, tbxPassword.Text);
        }
    }
}

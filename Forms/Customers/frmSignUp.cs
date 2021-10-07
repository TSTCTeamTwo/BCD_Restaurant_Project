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

            bool emailOK = ProgOps.IsValidEmail(tbxEmail.Text);

            if (emailOK)
            {
                ProgOps.SignUp(tbxFirstname.Text, tbxLastName.Text, tbxUsername.Text, tbxEmail.Text, tbxPassword.Text);
                MessageBox.Show("Sign up was successful.", "SignUp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Enter a valid email address.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
        }

        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDatabase();
        }
    }
}

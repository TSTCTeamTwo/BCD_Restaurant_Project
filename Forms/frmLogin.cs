using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Forms.Customers;
using BCD_Restaurant_Project.Forms.Employees;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmLogin : Form
    {
        private static readonly StringBuilder _errorMessages = new StringBuilder();
        private bool showPassword;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text.Equals("") || tbxPassword.Text.Equals(""))
            {
                lblEmpty.Visible = true;
            }
            else
            {
                try
                {
                    ProgOps.openDatabase();
                    //ProgOps.AccountID = ProgOps.verifyAccountExistence(tbxUsername.Text, tbxPassword.Text);
                    int checkPasswordCombination = ProgOps.verifyAccountStatus(tbxUsername.Text, tbxPassword.Text);
                    if (ProgOps.AccountID != -1 && checkPasswordCombination != -1)
                    {

                        int accountType = ProgOps.verifyEmployeeStatus();

                        if (accountType == 2) //account is an admin -> which would mean accountType = 2
                        {
                            new frmMainManagers().Show();
                        }
                        else if (accountType == 1) //account is employee -> which would mean accountType = 1
                        {
                            new frmMainEmployees().Show();
                        }
                        else //account is regular customer  -> which would mean accountType = 0
                        {
                            new frmMain().Show();
                        }

                        lblEmpty.Visible = false;
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Account not found", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxPassword.Clear();
                        tbxUsername.Focus();
                    }
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index#" + i + "\n" +
                                              "Message: " + ex.Errors[i].Message + "\n" +
                                              "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                              "Source: " + ex.Errors[i].Source + "\n" +
                                              "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }

                    MessageBox.Show(_errorMessages.ToString(), "Error Opening Database", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error Logging in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.closeDatabase();
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            showPassword = false;
            tbxUsername.Focus();

            tbxUsername.Text = "rdemeza0";
            tbxPassword.Text = "59g0GR05";

            btnLogin.Focus();

        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgot form = new frmForgot();
            form.Show();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp sign = new frmSignUp();
            sign.Show();
        }

        private void pbxPasswordIcon_Click(object sender, EventArgs e)
        {
            
            if (!showPassword)
            {

                pbxPasswordIcon.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("pressToShow");
                tbxPassword.PasswordChar = default;
                showPassword = true;
            }
            else
            {

                pbxPasswordIcon.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("pressToHide");
                tbxPassword.PasswordChar = '•';
                showPassword = false;
            }
        }
    }
}

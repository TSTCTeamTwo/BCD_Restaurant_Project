#region

using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Forms.Customers;
using BCD_Restaurant_Project.Forms.Employees;
using BCD_Restaurant_Project.Forms.Main;
using BCD_Restaurant_Project.Properties;

#endregion

namespace BCD_Restaurant_Project.Forms.Login {
    public partial class frmLogin : Form {
        private static readonly StringBuilder _errorMessages = new StringBuilder();
        private bool showPassword;

        public frmLogin() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (tbxUsername.Text.Equals("") || tbxPassword.Text.Equals(""))
                lblEmpty.Visible = true;
            else
                try {
                    ProgOps.openDatabase();
                    int checkPasswordCombination = ProgOps.verifyAccountStatus(tbxUsername.Text, tbxPassword.Text);
                    if ((ProgOps.AccountID != -1) && (checkPasswordCombination != -1)) {
                        switch (checkPasswordCombination) {
                            case 0:
                                lblEmpty.Visible = true;
                                lblEmpty.Text = "Incorrect username or password.";
                                break;
                            case 1:
                                int accountType = ProgOps.verifyEmployeeStatus();

                                if (accountType == 2) //account is an admin -> which would mean accountType = 2
                                {
                                    DialogResult result
                                        = MessageBox.Show("Login As Admin? Yes for Admin, No for Customer", "Login",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (result == DialogResult.Yes)
                                        new frmMainManagers().Show();
                                    else
                                        new frmMain().Show();
                                } else if (accountType == 1) //account is employee -> which would mean accountType = 1
                                {
                                    DialogResult result
                                        = MessageBox.Show("Login As Employee? Yes for Employee, No for Customer",
                                                          "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (result == DialogResult.Yes)
                                        new frmMainEmployees().Show();
                                    else
                                        new frmMain().Show();
                                } else //account is regular customer  -> which would mean accountType = 0
                                {
                                    new frmMain().Show();
                                }

                                lblEmpty.Visible = false;
                                Hide();
                                break;
                            case 2:
                                new frmNewPassword().Show();
                                break;
                        }
                    } else {
                        MessageBox.Show("Account not found", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxPassword.Clear();
                        tbxUsername.Focus();
                    }
                } catch (SqlException ex) {
                    for (int i = 0; i < ex.Errors.Count; i++)
                        _errorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                              "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                              ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure +
                                              "\n");

                    MessageBox.Show(_errorMessages.ToString(), "Error Opening Database", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error Logging in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e) {
            ProgOps.closeDatabase();
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e) {
            showPassword = false;
            tbxUsername.Focus();

            //Testing for customer
            //tbxUsername.Text = "rdemeza0";
            //tbxPassword.Text = "59g0GR05";

            //Testing for employee
            //tbxUsername.Text = "dcoultar4";
            //tbxPassword.Text = "YSGQDxS";

            //Testing for admin
            tbxUsername.Text = "sdeerr";
            tbxPassword.Text = "hola";

            btnLogin.Focus();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ProgOps.closeDatabase();
            frmForgot form = new frmForgot();
            form.Show();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ProgOps.closeDatabase();
            frmSignUp sign = new frmSignUp();
            sign.Show();
        }

        private void pbxPasswordIcon_Click(object sender, EventArgs e) {
            if (!showPassword) {
                pbxPasswordIcon.Image = (Bitmap)Resources.ResourceManager.GetObject("pressToShow");
                tbxPassword.PasswordChar = default;
                showPassword = true;
            } else {
                pbxPasswordIcon.Image = (Bitmap)Resources.ResourceManager.GetObject("pressToHide");
                tbxPassword.PasswordChar = '•';
                showPassword = false;
            }
        }
    }
}
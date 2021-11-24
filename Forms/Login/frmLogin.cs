#region

using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Forms.Main;
using BCD_Restaurant_Project.Properties;

#endregion

namespace BCD_Restaurant_Project.Forms.Login {
    public partial class frmLogin : Form {
        private static StringBuilder _errorMessages = new StringBuilder();
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
                //tbxPassword.UseSystemPasswordChar = false;
                showPassword = true;
            } else {
                pbxPasswordIcon.Image = (Bitmap)Resources.ResourceManager.GetObject("pressToHide");
                tbxPassword.PasswordChar = '•';
                //tbxPassword.UseSystemPasswordChar = true;
                showPassword = false;
            }
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e) {

            if (((e.KeyChar >= 'A') && (e.KeyChar <= 'Z')) || ((e.KeyChar >= 'a') && (e.KeyChar <= 'z')) || (e.KeyChar == 8)) {
                e.Handled = false;
            } else if (e.KeyChar == 13) {
                tbxPassword.Focus();
            } else {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }

        }

        private void tbxUsername_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Home
                || e.KeyCode == Keys.End) {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void tbxUsername_Click(object sender, EventArgs e) {
            tbxUsername.SelectionStart = tbxUsername.TextLength;
        }

        private void tbxPassword_Click(object sender, EventArgs e) {
            tbxPassword.SelectionStart = tbxPassword.TextLength;
        }

        private void tbxUsername_DoubleClick(object sender, EventArgs e) {
            tbxUsername.SelectionStart = tbxUsername.TextLength;
        }

        private void tbxPassword_DoubleClick(object sender, EventArgs e) {
            tbxPassword.SelectionStart = tbxPassword.TextLength;
        }
    }
}
#region

using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers {
    public partial class frmForgot : Form {
        public frmForgot() {
            InitializeComponent();
        }

        private void lnkLblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e) {
            if (tbxEmail.Text.Equals("")) {
                MessageBox.Show("Enter an email", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool emailOK = ProgOps.isValidEmail(tbxEmail.Text);

            if (!emailOK) {
                MessageBox.Show("Enter a valid email address", "Reset Password", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            string otp = ProgOps.verifyOneTimePassword(tbxEmail.Text);
            if (!otp.Equals("")) {
                using (MailMessage mail = new MailMessage()) {
                    mail.From = new MailAddress("tstcteamtwo@gmail.com");
                    mail.To.Add(tbxEmail.Text);
                    mail.Subject = "Password Reset Request";
                    mail.Body = "<h2> Thank you for visiting Brayan and " +
                                "D'Angelo's Restaurant. You have requested the one time password for your account. You may find your " +
                                "password below:</h2><blockquote><h3> Password: " + otp + "</h3></blockquote>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)) {
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials
                            = new NetworkCredential("tstcteamtwo@gmail.com", "%3WZaH6M*ti4O8XnfZjWBGhkUooN9O");
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("Email has been sent", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void frmForgot_Load(object sender, EventArgs e) {
            tbxEmail.Focus();
        }
    }
}
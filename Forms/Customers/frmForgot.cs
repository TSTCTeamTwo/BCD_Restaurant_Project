using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms.Customers
{
    public partial class frmForgot : Form
    {
        public frmForgot()
        {
            InitializeComponent();
        }

        private void lnkLblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            bool emailOK = ProgOps.isValidEmail(tbxEmail.Text);
            if (tbxEmail.Text.Equals(""))
            {
                MessageBox.Show("Enter an email", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(emailOK == false)
            {
                MessageBox.Show("Enter a valid email address", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string otp = ProgOps.verifyOneTimePassword(tbxEmail.Text);
                if (!otp.Equals(""))
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("tstcteamtwo@gmail.com");
                        mail.To.Add("baviles599@gmail.com");
                        mail.Subject = "Hello World";
                        mail.Body = "<h1>" + otp + "</h1>";
                        mail.IsBodyHtml = true;
                        //mail.Attachments.Add(new Attachment("C:\\file.zip"));

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.Credentials = new NetworkCredential("tstcteamtwo@gmail.com", "igy7685(*&%");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                        }
                    }
                    MessageBox.Show("Email has been sent", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
               
            }
            
            
        }

        private void frmForgot_Load(object sender, EventArgs e)
        {
            tbxEmail.Focus();
        }
    }
}



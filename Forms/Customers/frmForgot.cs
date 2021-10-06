using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Net.Http;

namespace BCD_Restaurant_Project.Forms.Customers
{
    public partial class frmForgot : Form
    {
        public frmForgot()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("tstcteamtwo@gmail.com", "bcdTeamTwo"),
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("tstcteamtwo@gmail.com"),
                Subject = "subject",
                Body = "<h1>Hello</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add("baviles599@gmail.com");
            //sdad
            //    afsadfsadsf
            //        adfs
            //            adfs
            //                adfs
            //                    dfas
            //                        fdf
            //                            dsf
            //                                adsf
            //                                    dfds
            //                                        adfs
            //                                            asd
            //                                                fasd
            //                                                    fasdf
            //                                                        asdf
            //                                                            asdf
            //                                                                asdf
            //                                                                    asdfasd
            //                                                                        fasd
            //                                                                            fasd
            //                                                                                fadsf
            //                                                                                    adsf


            smtpClient.Send(mailMessage);
        }
    }
}

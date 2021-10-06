using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

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

            smtpClient.Send("tstcteamtwo@gmail.com", "baviles599@gmail.com", "TEST 1", "body");
        }
    }
}

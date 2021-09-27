using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmLogin : Form
    {
        CurrencyManager accountsManager;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ProgOps.openDatabase();
            accountsManager = (CurrencyManager)this.BindingContext[ProgOps.DTAccounts];
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDatabase();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (tbxPassword.Equals("") || tbxUsername.Equals(""))
            {
                return;

            }
            
            
        }
    }
}

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

namespace BCD_Restaurant_Project.Forms.Employees
{
    public partial class frmManageAccounts : Form
    {
        public frmManageAccounts()
        {
            InitializeComponent();
        }

        private void frmManageAccounts_Load(object sender, EventArgs e)
        {
            ProgOps.fillDgvWithAccountTable(dgvAccounts, tbxAccountID, tbxEmail, tbxUsername, tbxPassword, tbxConfirmPassword, tbxLastName, tbxFirstName);
        }
    }
}

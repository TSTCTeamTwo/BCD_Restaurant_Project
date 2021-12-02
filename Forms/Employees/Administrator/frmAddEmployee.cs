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
namespace BCD_Restaurant_Project.Forms.Employees.Administrator {
    public partial class frmAddEmployee : Form {
        CurrencyManager addEmployee;
        public frmAddEmployee() {
            InitializeComponent();
        }

        public frmAddEmployee(string accountID) {
            tbxAccountID.Text = accountID;
            cboPositions.Focus();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e) {
            
            addEmployee = (CurrencyManager)this.BindingContext[ProgOps.DTAccounts];
            ProgOps.findAccounts(tbxAccountID, cboPositions);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text.Equals(""))
            {
                return;
            }
            int savedRow = addEmployee.Position;
            DataRow[] foundRows;
            ProgOps.DTAccounts.DefaultView.Sort = "Username";
            foundRows = ProgOps.DTAccounts.Select("Username LIKE '" + tbxSearch.Text + "*'");

            if(foundRows.Length == 0)
            {
                addEmployee.Position = savedRow;
                MessageBox.Show("Account not found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(ProgOps.DTAccounts.DefaultView.Find(foundRows[0]["isEmployee"]) == 1)
            {
                addEmployee.Position = savedRow;
                MessageBox.Show("Account is already an employee", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                addEmployee.Position = ProgOps.DTAccounts.DefaultView.Find(foundRows[0]["Username"]);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}

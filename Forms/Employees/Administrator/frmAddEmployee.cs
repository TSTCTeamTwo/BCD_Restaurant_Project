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
using static BCD_Restaurant_Project.Classes.ProgOps;

namespace BCD_Restaurant_Project.Forms.Employees.Administrator {
    public partial class frmAddEmployee : Form {
        CurrencyManager addEmployee;
        public frmAddEmployee() {
            InitializeComponent();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e) {
            findAccounts(tbxAccountID, tbxFullName, cboPositions);
            addEmployee = (CurrencyManager)this.BindingContext[DTAccounts];

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text.Equals(""))
            {
                return;
            }
            int savedRow = addEmployee.Position;
            DataRow[] foundRows;
            DTAccounts.DefaultView.Sort = "Username";
            foundRows = DTAccounts.Select("Username LIKE '" + tbxSearch.Text + "*'");

            if(foundRows.Length == 0)
            {
                addEmployee.Position = savedRow;
                MessageBox.Show("Account not found", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxSearch.Clear();
                tbxSearch.Focus();
            }
            else if((bool)foundRows[0]["isEmployee"])
            {
                addEmployee.Position = savedRow;
                MessageBox.Show("Account is already an employee", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxSearch.Clear();
                tbxSearch.Focus();
            }
            else
            {
                addEmployee.Position = DTAccounts.DefaultView.Find(foundRows[0]["Username"]);
                cboPositions.Focus();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            insertEmployee(int.Parse(tbxAccountID.Text),cboPositions.SelectedText);
        }

        private void btnClear_Click(object sender, EventArgs e) {

        }
    }
}

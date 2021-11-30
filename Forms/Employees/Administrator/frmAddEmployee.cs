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

        }
    }
}

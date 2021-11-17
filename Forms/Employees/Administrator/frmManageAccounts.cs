#region

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static BCD_Restaurant_Project.Classes.ProgOps;

#endregion

namespace BCD_Restaurant_Project.Forms.Employees.Administrator {
    public partial class frmManageAccounts : Form {
        private CurrencyManager accountsManager;

        private CurrencyManager employeesManager;
        private string myState;

        public frmManageAccounts() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            setState("Add");
            accountsManager.AddNew();
            tbxAccountID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            setState("View");
            accountsManager.CancelCurrentEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            string[] txt = {
                               tbxAccountID.Text, tbxEmail.Text, tbxUsername.Text, tbxPassword.Text, tbxLastName.Text,
                               tbxFirstName.Text
                           };
            deactivateAccount(int.Parse(tbxAccountID.Text));
            setTitleAndEmployees();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            setState("Edit");
        }

        private void btnFirst_Click(object sender, EventArgs e) {
            accountsManager.Position = 0;
        }

        private void btnLast_Click(object sender, EventArgs e) {
            accountsManager.Position = accountsManager.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e) {
            accountsManager.Position++;
            setTitleAndEmployees();
            if (!string.IsNullOrEmpty(tbxAccountID.Text)) {
                populateEmployees(dgvEmployees, tbxAccountID.Text);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            accountsManager.Position--;
            setTitleAndEmployees();
            if (!string.IsNullOrEmpty(tbxAccountID.Text)) {
                populateEmployees(dgvEmployees, tbxAccountID.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string[] txt = {
                               tbxAccountID.Text, tbxEmail.Text, tbxUsername.Text, tbxPassword.Text, tbxLastName.Text,
                               tbxFirstName.Text
                           };

            accountsManager.EndCurrentEdit();
            commandAccount();
            accountsManager.Refresh();
            setTitleAndEmployees();
            setState("View");
        }

        private void frmManageAccounts_Load(object sender, EventArgs e) {
            populateAccounts(tbxAccountID, tbxEmail, tbxUsername, tbxPassword, tbxLastName, tbxFirstName, this,
                         out accountsManager);

            setState("View");
            setTitleAndEmployees();
        }

        private void setState(string appState) {
            myState = appState;
            switch (appState) {
                case "View":
                    btnPrevious.Focus();
                    //COLOR
                    tbxAccountID.BackColor = Color.White;
                    tbxAccountID.ForeColor = Color.Black;
                    //READONLY all text boxes
                    foreach (TextBox tbxCurrent in Controls.OfType<TextBox>()) {
                        tbxCurrent.ReadOnly = true;
                        tbxCurrent.Enabled = false;
                    }

                    //ENABLED - BUTTONS
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAdd.Enabled = true;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnPrevious.Focus();
                    setTitleAndEmployees();
                    break;
                default:
                    //modify the color of the AccountID tbx
                    tbxAccountID.BackColor = Color.Red;
                    tbxAccountID.ForeColor = Color.Black;
                    tbxAccountID.ReadOnly = true;
                    tbxAccountID.Enabled = false;
                    //ENABLE ALL TEXTBOXES
                    foreach (TextBox tbxCurrent in Controls.OfType<TextBox>()) {
                        tbxCurrent.ReadOnly = false;
                        tbxCurrent.Enabled = true;
                    }

                    //ENABLE - BUTTONS
                    btnSave.Enabled = true;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    break;
            }
        }

        private void setTitleAndEmployees() {
            lblAccounts.Text = "Account - Record " + (accountsManager.Position + 1) + " of " + accountsManager.Count +
                               " Records: " + tbxLastName.Text + ", " + tbxFirstName.Text;


        }
    }
}
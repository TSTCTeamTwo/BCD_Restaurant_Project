using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using BCD_Restaurant_Project.Classes;

namespace BCD_Restaurant_Project.Forms.Employees
{
    public partial class frmManageAccounts : Form
    {
        private CurrencyManager accountsManager = null;
        private string myState;

        public frmManageAccounts()
        {
            InitializeComponent();
        }

        private void frmManageAccounts_Load(object sender, EventArgs e)
        {
            ProgOps.openDatabase();
            ProgOps.bindAccounts(tbxAccountID, tbxEmail, tbxUsername, tbxPassword, tbxConfirmPassword,
             tbxLastName, tbxFirstName, this, out accountsManager);

            SetState("View");
            setTitle();

        }

        private void SetState(string appState)
        {

            myState = appState;
            switch (appState)
            {
                case "View":
                    btnPrevious.Focus();
                    //COLOR
                    tbxEmployeeID.BackColor = Color.White;
                    tbxEmployeeID.ForeColor = Color.Black;
                    //READONLY
                    tbxEmployeeID.ReadOnly = true;
                    tbxEmail.ReadOnly = true;
                    tbxUsername.ReadOnly = true;
                    tbxPassword.ReadOnly = true;
                    tbxConfirmPassword.ReadOnly = true;
                    tbxLastName.ReadOnly = true;
                    tbxFirstName.ReadOnly = true;
                    //ENABLED - BUTTONS
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAdd.Enabled = true;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnPrevious.Focus();
                    btnEdit.Text = "Edit";
                    break;

                case "Add":
                    //COLOR
                    tbxAccountID.BackColor = Color.Red;
                    tbxAccountID.ForeColor = Color.Black;
                    //READONLY
                    tbxEmployeeID.ReadOnly = false;
                    tbxEmail.ReadOnly = false;
                    tbxUsername.ReadOnly = false;
                    tbxPassword.ReadOnly = false;
                    tbxConfirmPassword.ReadOnly = false;
                    tbxLastName.ReadOnly = false;
                    tbxFirstName.ReadOnly = false;
                    //ENABLED - BUTTONS
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnEdit.Text = "Cancel";
                    btnDelete.Enabled = false;
                    btnSave.Enabled = false;
                    tbxLastName.Focus();
                    break;

                case "Edit":
                    //COLOR
                    tbxAccountID.BackColor = Color.Red;
                    tbxAccountID.ForeColor = Color.Black;
                    //READONLY
                    tbxEmployeeID.ReadOnly = false;
                    tbxEmail.ReadOnly = false;
                    tbxUsername.ReadOnly = false;
                    tbxPassword.ReadOnly = false;
                    tbxConfirmPassword.ReadOnly = false;
                    tbxLastName.ReadOnly = false;
                    tbxFirstName.ReadOnly = false;
                    //ENABLED - BUTTONS

                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnEdit.Text = "Cancel";
                    tbxLastName.Focus();
                    break;

                default:

                    //modify the color of the AccountID tbx
                    tbxAccountID.BackColor = Color.White;
                    tbxAccountID.ForeColor = Color.Black;

                    foreach (var tbxCurrent in Controls.OfType<TextBox>())
                    {
                        tbxCurrent.ReadOnly = true;
                    }

                    btnEdit.Text = "Edit";

                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (accountsManager.Position == accountsManager.Count - 1)
            {
            }
            else
            {
                accountsManager.Position++;
                setTitle();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (accountsManager.Position == 0)
            {
            }
            else
            {
                accountsManager.Position--;
                setTitle();
            }
        }

        private void setTitle()
        {
            Text = "Account - Record " + (accountsManager.Position + 1) + " of " + accountsManager.Count + " Record: "
                + tbxLastName.Text + ", " + tbxFirstName.Text;
        }

    }
}

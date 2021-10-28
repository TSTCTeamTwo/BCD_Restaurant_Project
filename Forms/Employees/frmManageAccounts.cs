using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using BCD_Restaurant_Project.Classes;

using static BCD_Restaurant_Project.Classes.ProgOps;

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

        private void btnEdit_Click(object sender, EventArgs e)
        {

            setState("Edit");
                
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
                accountsManager.Position++;
                setTitle();
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
                accountsManager.Position--;
                setTitle();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] txt = {
                tbxAccountID.Text,
                tbxEmail.Text,
                tbxUsername.Text,
                tbxPassword.Text,
                tbxLastName.Text,
                tbxFirstName.Text
            };

            accountsManager.EndCurrentEdit();
            ProgOps.commandAccount();
            setTitle();
            setState("View");
        }

        private void frmManageAccounts_Load(object sender, EventArgs e)
        {
            ProgOps.bindAccounts(tbxAccountID, tbxEmail, tbxUsername, tbxPassword,
             tbxLastName, tbxFirstName, this, out accountsManager);

            setState("View");
            setTitle();

        }

        private void setState(string appState)
        {

            myState = appState;
            switch (appState)
            {
                case "View":
                    btnPrevious.Focus();
                    //COLOR
                    tbxAccountID.BackColor = Color.White;
                    tbxAccountID.ForeColor = Color.Black;
                    //READONLY all text boxes
                    foreach (var tbxCurrent in Controls.OfType<TextBox>())
                    {
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
                    setTitle();
                    break;
                default:
                    //modify the color of the AccountID tbx
                    tbxAccountID.BackColor = Color.Red;
                    tbxAccountID.ForeColor = Color.Black;
                    tbxAccountID.ReadOnly = true;
                    tbxAccountID.Enabled = false;
                    //ENABLE ALL TEXTBOXES
                    foreach (var tbxCurrent in Controls.OfType<TextBox>())
                    {
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
        private void setTitle()
        {
            lblAccounts.Text = "Account - Record " + (accountsManager.Position + 1) + " of " + accountsManager.Count + " Records: "
                + tbxLastName.Text + ", " + tbxFirstName.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] txt = {
                tbxAccountID.Text,
                tbxEmail.Text,
                tbxUsername.Text,
                tbxPassword.Text,
                tbxLastName.Text,
                tbxFirstName.Text
            };
            ProgOps.deactivateAccount(int.Parse(tbxAccountID.Text));
            setTitle();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setState("Add");
            accountsManager.AddNew();
            tbxAccountID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setState("View");
            accountsManager.CancelCurrentEdit();
        }
    }
}


//case "Add":
//    //COLOR
//    tbxAccountID.BackColor = Color.Red;
//    tbxAccountID.ForeColor = Color.Black;
//    //READONLY
//    tbxEmployeeID.ReadOnly = false;
//    tbxEmail.ReadOnly = false;
//    tbxUsername.ReadOnly = false;
//    tbxPassword.ReadOnly = false;
//    tbxConfirmPassword.ReadOnly = false;
//    tbxLastName.ReadOnly = false;
//    tbxFirstName.ReadOnly = false;
//    //ENABLED - BUTTONS
//    btnPrevious.Enabled = false;
//    btnNext.Enabled = false;
//    btnAdd.Enabled = false;
//    btnSave.Enabled = true;
//    btnDelete.Enabled = false;
//    btnEdit.Enabled = false;
//    btnEdit.Text = "Cancel";

//    tbxEmployeeID.Enabled = true;
//    tbxEmail.Enabled = true;
//    tbxUsername.Enabled = true;
//    tbxPassword.Enabled = true;
//    tbxConfirmPassword.Enabled = true;
//    tbxLastName.Enabled = true;
//    tbxFirstName.Enabled = true;

//    tbxAccountID.Text = string.Empty;
//    tbxEmployeeID.Text = string.Empty;
//    tbxEmail.Text = string.Empty;
//    tbxUsername.Text = string.Empty;
//    tbxPassword.Text = string.Empty;
//    tbxConfirmPassword.Text = string.Empty;
//    tbxLastName.Text = string.Empty;
//    tbxFirstName.Text = string.Empty;

//    tbxEmail.Focus();
//    break;

//case "Edit":
//    //COLOR
//    tbxAccountID.BackColor = Color.Red;
//    tbxAccountID.ForeColor = Color.Black;
//    //READONLY
//    tbxEmployeeID.ReadOnly = false;
//    tbxEmail.ReadOnly = false;
//    tbxUsername.ReadOnly = false;
//    tbxPassword.ReadOnly = false;
//    tbxConfirmPassword.ReadOnly = false;
//    tbxLastName.ReadOnly = false;
//    tbxFirstName.ReadOnly = false;

//    tbxEmployeeID.Enabled = true;
//    tbxEmail.Enabled = true;
//    tbxUsername.Enabled = true;
//    tbxPassword.Enabled = true;
//    tbxConfirmPassword.Enabled = true;
//    tbxLastName.Enabled = true;
//    tbxFirstName.Enabled = true;

//    //ENABLED - BUTTONS

//    btnPrevious.Enabled = false;
//    btnNext.Enabled = false;
//    btnAdd.Enabled = false;
//    btnSave.Enabled = true;
//    btnDelete.Enabled = false;
//    btnEdit.Enabled = true;
//    btnEdit.Text = "Cancel";
//    tbxLastName.Focus();
//    break;
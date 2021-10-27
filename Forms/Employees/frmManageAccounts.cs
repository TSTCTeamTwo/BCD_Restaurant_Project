﻿using System;
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
            if (btnEdit.Text == "Edit")
                setState("Edit");
            else
            {
                setState("View");
                accountsManager.CancelCurrentEdit();
            }
                
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

            switch (myState)
            {
                case "Add":
                    addAccount(txt);
                    accountsManager.EndCurrentEdit();
                    break;
                case "Edit":
                    updateAccount(txt);
                    break;
            }
            setTitle();
        }

        private void frmManageAccounts_Load(object sender, EventArgs e)
        {
            ProgOps.openDatabase();
            ProgOps.bindAccounts(tbxAccountID, tbxEmail, tbxUsername, tbxPassword, tbxConfirmPassword,
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
                    setTitle();
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
                    btnEdit.Enabled = false;
                    btnEdit.Text = "Cancel";

                    tbxEmployeeID.Enabled = true;
                    tbxEmail.Enabled = true;
                    tbxUsername.Enabled = true;
                    tbxPassword.Enabled = true;
                    tbxConfirmPassword.Enabled = true;
                    tbxLastName.Enabled = true;
                    tbxFirstName.Enabled = true;

                    tbxAccountID.Text = string.Empty;
                    tbxEmployeeID.Text = string.Empty;
                    tbxEmail.Text = string.Empty;
                    tbxUsername.Text = string.Empty;
                    tbxPassword.Text = string.Empty;
                    tbxConfirmPassword.Text = string.Empty;
                    tbxLastName.Text = string.Empty;
                    tbxFirstName.Text = string.Empty;

                    tbxEmail.Focus();
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

                    tbxEmployeeID.Enabled = true;
                    tbxEmail.Enabled = true;
                    tbxUsername.Enabled = true;
                    tbxPassword.Enabled = true;
                    tbxConfirmPassword.Enabled = true;
                    tbxLastName.Enabled = true;
                    tbxFirstName.Enabled = true;

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
            deleteAccount(txt);
            accountsManager.RemoveAt(accountsManager.Position);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setState("Add");
        }
    }
}

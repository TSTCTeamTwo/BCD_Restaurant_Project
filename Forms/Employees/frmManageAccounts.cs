using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
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
             tbxLastName, tbxFirstName, dgvDisplay);

            accountsManager = (CurrencyManager)BindingContext[ProgOps.DTAccounts];

            SetState("View");

        }

        private void SetState(string view)
        {
            //myState = appState;
            //switch (appState)
            //{
            //    case "View":
            //        btnPrevious.Focus();
            //        //COLOR
            //        tbxEmployeeID.BackColor = Color.White;
            //        tbxEmployeeID.ForeColor = Color.Black;
            //        //READONLY
            //        tbxEmployeeID.ReadOnly = true;
            //        tbxLastName.ReadOnly = true;
            //        tbxFirstName.ReadOnly = true;
            //        tbxExtension.ReadOnly = true;
            //        //ENABLED - BUTTONS
            //        btnPrevious.Enabled = true;
            //        btnNext.Enabled = true;
            //        btnAddNew.Enabled = true;
            //        btnSave.Enabled = false;
            //        btnCancel.Enabled = false;
            //        btnEdit.Enabled = true;
            //        btnDelete.Enabled = true;
            //        btnPrevious.Focus();
            //        break;

            //    case "Add New":
            //        //COLOR
            //        tbxEmployeeID.BackColor = Color.Red;
            //        tbxEmployeeID.ForeColor = Color.Black;
            //        //READONLY
            //        tbxEmployeeID.ReadOnly = true;
            //        tbxLastName.ReadOnly = false;
            //        tbxFirstName.ReadOnly = false;
            //        tbxExtension.ReadOnly = false;
            //        //ENABLED - BUTTONS
            //        btnPrevious.Enabled = false;
            //        btnNext.Enabled = false;
            //        btnAddNew.Enabled = false;
            //        btnSave.Enabled = true;
            //        btnCancel.Enabled = true;
            //        btnEdit.Enabled = false;
            //        btnDelete.Enabled = false;
            //        tbxLastName.Focus();
            //        break;

            //    case "Edit":
            //        //COLOR
            //        tbxEmployeeID.BackColor = Color.Red;
            //        tbxEmployeeID.ForeColor = Color.Black;
            //        //READONLY
            //        tbxEmployeeID.ReadOnly = true;
            //        tbxLastName.ReadOnly = false;
            //        tbxFirstName.ReadOnly = false;
            //        tbxExtension.ReadOnly = false;
            //        //ENABLED - BUTTONS
            //        btnPrevious.Enabled = false;
            //        btnNext.Enabled = false;
            //        btnAddNew.Enabled = false;
            //        btnSave.Enabled = true;
            //        btnCancel.Enabled = true;
            //        btnEdit.Enabled = false;
            //        btnDelete.Enabled = true;
            //        tbxLastName.Focus();
            //        break;

            //    default: // Add or Edit if not View
            //        //tbxEmployeeID.BackColor = Color.Red;
            //        //tbxEmployeeID.ForeColor = Color.White;
            //        //tbxEmployeeID.ReadOnly = true;
            //        //tbxLastName.ReadOnly = false;
            //        //tbxFirstName.ReadOnly = false;
            //        //tbxExtension.ReadOnly = false;
            //        //tbxEmployeeID.Enabled = true;
            //        //tbxLastName.Enabled = true;
            //        //tbxFirstName.Enabled = true;
            //        //tbxExtension.Enabled = true;
            //        //btnPrevious.Enabled = false;
            //        //btnNext.Enabled = false;
            //        //btnAddNew.Enabled = false;
            //        //btnSave.Enabled = true;
            //        //btnCancel.Enabled = true;
            //        //btnEdit.Enabled = false;
            //        //btnDelete.Enabled = false;

            //        //modify the color of the AccountID tbx
            //        tbxAccountID.BackColor = Color.Red;
            //        tbxAccountID.ForeColor = Color.White;

            //        foreach (var tbxCurrent in Controls.OfType<TextBox>())
            //        {
            //            tbxCurrent.Enabled = true;
            //            tbxCurrent.ReadOnly = true;
            //        }

                    

            //        break;
            //}
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (accountsManager.Position == accountsManager.Count - 1)
            {
            }
            else
            {
                accountsManager.Position++;
                //SetText();
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
                //SetText();
            }
        }

    }
}

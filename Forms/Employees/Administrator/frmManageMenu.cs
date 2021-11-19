﻿#region

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Employees.Administrator {
    public partial class frmManageMenu : Form {
        private CurrencyManager menuManager;

        private string myState;

        public frmManageMenu() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            menuManager.AddNew();
            setState("Add");
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            setState("View");
            menuManager.CancelCurrentEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) ==
                DialogResult.Yes)
                menuManager.RemoveAt(menuManager.Position);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            setState("Edit");
        }

        private void btnFirst_Click(object sender, EventArgs e) {
            menuManager.Position = 0;
        }

        private void btnLast_Click(object sender, EventArgs e) {
            menuManager.Position = menuManager.Count - 1;
        }

        private void btnLoadImage_Click(object sender, EventArgs e) {
            ProgOps.changeMenuItemImage(int.Parse(tbxItemID.Text));
        }

        private void btnNext_Click(object sender, EventArgs e) {
            menuManager.Position++;
            setText();
            ProgOps.changeCategoryAndImage(menuManager, cbxCategories, pbxImageBox);
        }

        private void btnPrevious_Click(object sender, EventArgs e) {
            menuManager.Position--;
            setText();
            ProgOps.changeCategoryAndImage(menuManager, cbxCategories, pbxImageBox);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            menuManager.EndCurrentEdit();
            ProgOps.updateMenuOnClose();
            setState("View");
        }

        private void frmManageMenu_FormClosing(object sender, FormClosingEventArgs e) { }

        private void frmManageMenu_Load(object sender, EventArgs e) {
            ProgOps.modifyMenu(tbxName, tbxItemID, tbxDescription, tbxPrice, cbxCategories, this, out menuManager,
                               dgvDisplay, pbxImageBox);
            setState("View");
            //byte[] image = System.Text.Encoding.UTF8.GetBytes(tbxImagePath.Text);

            //string str = System.Text.Encoding.UTF8.GetString(image, 0, image.Length);

            //tbxImagePath.Text = str.ToString();
        }

        private void setState(string appState) {
            myState = appState;
            switch (appState) {
                case "View":
                    btnPrevious.Focus();
                    //COLOR
                    tbxItemID.BackColor = Color.White;
                    tbxItemID.ForeColor = Color.Black;
                    //READONLY
                    foreach (TextBox tbxCurrent in Controls.OfType<TextBox>()) {
                        tbxCurrent.ReadOnly = true;
                        tbxCurrent.Enabled = true;
                    }

                    //ENABLED - BUTTONS
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnLoadImage.Enabled = false;
                    btnFirst.Enabled = true;
                    btnLast.Enabled = true;
                    btnSave.Enabled = false;
                    btnEdit.Text = "Edit";
                    break;

                default:
                    //COLOR
                    tbxItemID.BackColor = Color.Red;
                    tbxItemID.ForeColor = Color.Black;
                    //READONLY
                    foreach (TextBox tbxCurrent in Controls.OfType<TextBox>()) {
                        tbxCurrent.ReadOnly = false;
                        tbxCurrent.Enabled = true;
                    }

                    //ENABLED - BUTTONS
                    btnFirst.Enabled = false;
                    btnLast.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnLoadImage.Enabled = true;
                    tbxName.Focus();
                    break;
            }
        }

        private void setText() {
            Text = "Menu - Record" + (menuManager.Position + 1) + " of" + menuManager.Count + " Records";
        }
    }
}
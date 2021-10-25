using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms.Employees
{
    public partial class frmManageMenu : Form
    {
        public frmManageMenu()
        {
            InitializeComponent();
        }

        CurrencyManager menuManager;
        private string myState;
        private void frmManageMenu_Load(object sender, EventArgs e)
        {
            ProgOps.modifyMenu(tbxName, tbxItemID, tbxDescription, tbxPrice, tbxImagePath, cbxCategories, this, out menuManager, dgvDisplay);


            //byte[] image = System.Text.Encoding.UTF8.GetBytes(tbxImagePath.Text);

            //string str = System.Text.Encoding.UTF8.GetString(image, 0, image.Length);

            //tbxImagePath.Text = str.ToString();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            menuManager.Position++;
            SetText();
            ProgOps.changeCategory(menuManager, cbxCategories);


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {


            menuManager.Position--;
            SetText();
            ProgOps.changeCategory(menuManager, cbxCategories);


        }

        private void SetText()
        {
            this.Text = "Menu - Record" + (menuManager.Position + 1).ToString() + " of" + menuManager.Count.ToString() + " Records";
        }

        private void tbxImagePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
                SetState("Edit");
            else
                SetState("View");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            menuManager.AddNew();
            SetState("Add");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                menuManager.RemoveAt(menuManager.Position);
            }
        }

        private void SetState(string appState)
        {

            myState = appState;
            switch (appState)
            {
                case "View":
                    btnPrevious.Focus();
                    //COLOR
                    tbxItemID.BackColor = Color.White;
                    tbxItemID.ForeColor = Color.Black;
                    //READONLY
                    tbxItemID.ReadOnly = true;
                    tbxName.ReadOnly = true;
                    tbxImagePath.ReadOnly = true;
                    tbxDescription.ReadOnly = true;
                    tbxPrice.ReadOnly = true;
                    //ENABLED - BUTTONS
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnPrevious.Focus();
                    btnEdit.Text = "Edit";
                    break;

                case "Add":
                    //COLOR
                    tbxItemID.BackColor = Color.Red;
                    tbxItemID.ForeColor = Color.Black;
                    //READONLY
                    tbxItemID.ReadOnly = true;
                    tbxName.ReadOnly = false;
                    tbxPrice.ReadOnly = false;
                    tbxImagePath.ReadOnly = false;
                    tbxDescription.ReadOnly = false;
                    //ENABLED - BUTTONS
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnEdit.Text = "Cancel";
                    tbxName.Focus();
                    break;

                case "Edit":
                    //COLOR
                    tbxItemID.BackColor = Color.Red;
                    tbxItemID.ForeColor = Color.Black;
                    //READONLY
                    tbxItemID.ReadOnly = true;
                    tbxName.ReadOnly = false;
                    tbxPrice.ReadOnly = false;
                    tbxImagePath.ReadOnly = false;
                    tbxDescription.ReadOnly = false;
                    //ENABLED - BUTTONS

                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnEdit.Text = "Cancel";
                    tbxName.Focus();
                    break;

                default:

                    //modify the color of the AccountID tbx
                    tbxItemID.BackColor = Color.White;
                    tbxItemID.ForeColor = Color.Black;

                    foreach (var tbxCurrent in Controls.OfType<TextBox>())
                    {
                        tbxCurrent.ReadOnly = true;
                    }

                    btnEdit.Text = "Edit";

                    break;
            }
        }

        private void frmManageMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            menuManager.EndCurrentEdit();
            ProgOps.updateMenuOnClose();
            SetState("View");

        }
    }
}

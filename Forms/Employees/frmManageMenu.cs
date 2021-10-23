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
namespace BCD_Restaurant_Project.Forms.Employees
{
    public partial class frmManageMenu : Form
    {
        public frmManageMenu()
        {
            InitializeComponent();
        }

        CurrencyManager menuManager;

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

            if (menuManager.Position == menuManager.Count - 1)
            {
            }
            else
            {
                menuManager.Position++;
                SetText();
                ProgOps.changeCategory(menuManager, cbxCategories);
            }
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(menuManager.Position == 0)
            {
                
            }
            else
            {
                menuManager.Position--;
                SetText();
                ProgOps.changeCategory(menuManager, cbxCategories);
            }
            
        }

        private void SetText()
        {
            this.Text = "Menu - Record" + (menuManager.Position + 1).ToString() + " of" + menuManager.Count.ToString() + " Records";
        }

        private void tbxImagePath_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

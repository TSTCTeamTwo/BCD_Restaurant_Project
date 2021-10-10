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

        private void frmManageMenu_Load(object sender, EventArgs e)
        {
            ProgOps.ModifyMenu(dgvMenu, tbxName, tbxItemID, tbxDescription, tbxPrice, tbxImagePath);
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ProgOps.MenuBinding(dgvMenu,tbxName, tbxItemID,tbxDescription,tbxPrice,tbxImagePath);
        }

        
    }
}

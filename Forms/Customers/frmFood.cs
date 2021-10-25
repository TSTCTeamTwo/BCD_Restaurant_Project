using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            ProgOps.displayMenuItems(dgvFood, 1);
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            Cart.addToCartFromFood(dgvFood);
        }
    }
}

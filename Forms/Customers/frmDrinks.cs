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
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmDrinks : Form
    {
        public frmDrinks()
        {
            InitializeComponent();
        }

     
        private void frmDrinks_Load(object sender, EventArgs e)
        {
            ProgOps.displayMenuItems(dgvDrinks, 4);
        }

       

        private void btnReturnToDrinks_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            Cart.addToCartFromDrinks(dgvDrinks);
        }

        
    }
}

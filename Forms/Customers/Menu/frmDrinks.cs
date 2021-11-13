#region

using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers.Menu {
    public partial class frmDrinks : Form {
        public frmDrinks() {
            InitializeComponent();
        }

        private void frmDrinks_Load(object sender, EventArgs e) {
            ProgOps.displayMenuItems(dgvDrinks, 4, 2);
        }

        private void btnReturnToDrinks_Click(object sender, EventArgs e) { }

        private void btnAddToOrder_Click(object sender, EventArgs e) {
            Cart.addToCartFromDrinks(dgvDrinks);
        }

        private void dgvDrinks_SelectionChanged(object sender, EventArgs e) {
            ProgOps.updatePicInPbx((int)dgvDrinks.CurrentRow.Cells[0].Value, pbxShakes);
        }
    }
}
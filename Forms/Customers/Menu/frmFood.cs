#region

using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers.Menu {
    public partial class frmFood : Form {
        public frmFood() {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e) {
            ProgOps.displayMenuItems(dgvFood, 1);
        }

        private void btnAddToOrder_Click(object sender, EventArgs e) {
            Cart.addToCartFromFood(dgvFood);
        }

        private void dgvFood_SelectionChanged(object sender, EventArgs e) {
            if (dgvFood.CurrentRow != null)
                ProgOps.updatePicInPbx((int)dgvFood.CurrentRow.Cells[0].Value, pbxFood);
        }
    }
}
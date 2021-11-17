#region

using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
using static BCD_Restaurant_Project.Classes.ProgOps;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers.Menu {
    public partial class frmDrinks : Form {
        public frmDrinks() {
            InitializeComponent();
        }

        private void frmDrinks_Load(object sender, EventArgs e) {
            displayMenuItems(dgvDrinks, CurrentForm.DRINKS);
            dgvDrinks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnAddToOrder_Click(object sender, EventArgs e) {
            Cart.addToCartFromDrinks(dgvDrinks);
        }

        private void dgvDrinks_SelectionChanged(object sender, EventArgs e) {
            if (dgvDrinks.CurrentRow != null) {
                //pbxDrinks.Image = setImage((int)dgvDrinks.CurrentRow.Cells[4].Value);
            }
        }
    }
}
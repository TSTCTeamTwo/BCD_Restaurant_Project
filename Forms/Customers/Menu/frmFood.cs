#region

using System;
using System.Windows.Forms;

using BCD_Restaurant_Project.Classes;

using static BCD_Restaurant_Project.Classes.ProgOps;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers.Menu {
    public partial class frmFood : Form {
        public frmFood() {
            InitializeComponent();
        }

        private void frmFood_Load(object sender, EventArgs e) {
            displayMenuItems(dgvFood, CurrentForm.SIDES);
            dgvFood.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            pbxFood.Image = setImage();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e) {
            Cart.addToCartFromFood(dgvFood);
        }

        private void dgvFood_SelectionChanged(object sender, EventArgs e) {
            if (dgvFood.CurrentRow != null) {
                pbxFood.Image = setImage((int)dgvFood.CurrentRow.Cells[4].Value);
            }
        }

    }
}
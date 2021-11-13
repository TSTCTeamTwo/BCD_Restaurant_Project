#region

using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers.Menu {
    public partial class frmDesserts : Form {
        public frmDesserts() {
            InitializeComponent();
        }

        private void frmDesserts_Load(object sender, EventArgs e) {
            ProgOps.displayMenuItems(dgvDesserts, 3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnAddToOrder_Click(object sender, EventArgs e) {
            Cart.addToCartFromDesserts(dgvDesserts);
        }

        private void dgvDesserts_SelectionChanged(object sender, EventArgs e) {
            ProgOps.updatePicInPbx((int)dgvDesserts.CurrentRow.Cells[0].Value, pbxDesserts);
        }
    }
}
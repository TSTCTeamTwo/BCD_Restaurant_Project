#region

using System;
using System.Windows.Forms;

using BCD_Restaurant_Project.Classes;

using static BCD_Restaurant_Project.Classes.ProgOps;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers.Menu {
    public partial class frmDesserts : Form {
        public frmDesserts() {
            InitializeComponent();
        }

        private void frmDesserts_Load(object sender, EventArgs e) {
            displayMenuItems(dgvDesserts, CurrentForm.DESSERTS);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnAddToOrder_Click(object sender, EventArgs e) {
            Cart.addToCartFromDesserts(dgvDesserts);
        }

        private void dgvDesserts_SelectionChanged(object sender, EventArgs e) {
            if (dgvDesserts.CurrentRow != null) {
                pbxDesserts.Image = setImage((int)dgvDesserts.CurrentRow.Cells[0].Value);
            }
        }
    }
}
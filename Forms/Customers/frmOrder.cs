using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

namespace BCD_Restaurant_Project.Forms.Customers
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Cart.myCart.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ProgOps.scanForPaymentOption())
            {
                DialogResult result = MessageBox.Show("Would you like to use your previous paying method?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    this.Hide();
                    new frmPayment().Show();
                }
                else if (result == DialogResult.Yes)
                {
                    ProgOps.finalizeOrder();
                }
            }
            else
            {
                this.Hide();
                new frmPayment().Show();
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cart.clearCart(dgvOrder);
            Cart.fillBtnCheckoutText(btnCheckout);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Cart.removeFromCart(dgvOrder);
            Cart.fillBtnCheckoutText(btnCheckout);
            dgvOrder.Rows.Clear();

            foreach (KeyValuePair<int, Classes.MenuItem> item in Cart.myCart)
            {

                int row = dgvOrder.Rows.Add();
                dgvOrder.Rows[row].Cells[0].Value = item.Key;
                dgvOrder.Rows[row].Cells[1].Value = item.Value.ItemName;
                dgvOrder.Rows[row].Cells[2].Value = item.Value.IndividualPrice;
                dgvOrder.Rows[row].Cells[3].Value = item.Value.Quantity;

            }

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            Cart.fillBtnCheckoutText(btnCheckout);

            dgvOrder.Rows.Clear();
            dgvOrder.ColumnCount = 4;
            dgvOrder.Columns[0].Name = "Item ID";
            dgvOrder.Columns[1].Name = "Item Name";
            dgvOrder.Columns[2].Name = "Item Price";
            dgvOrder.Columns[3].Name = "Quantity";

            foreach (KeyValuePair<int, Classes.MenuItem> item in Cart.myCart)
            {

                int row = dgvOrder.Rows.Add();
                dgvOrder.Rows[row].Cells[0].Value = item.Key;
                dgvOrder.Rows[row].Cells[1].Value = item.Value.ItemName;
                dgvOrder.Rows[row].Cells[2].Value = item.Value.IndividualPrice;
                dgvOrder.Rows[row].Cells[3].Value = item.Value.Quantity;

            }

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

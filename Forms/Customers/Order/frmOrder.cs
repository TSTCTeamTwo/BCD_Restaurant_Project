#region

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Reports;
using MenuItem = BCD_Restaurant_Project.Classes.MenuItem;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers.Order {
    public partial class frmOrder : Form {
        public frmOrder() {
            InitializeComponent();
        }
        static int dotCounter = 0;
        private void btnCheckout_Click(object sender, EventArgs e) {
           // MessageBox.Show(Cart.Tip.ToString());
            if (Cart.myCart.Count == 0) {
                MessageBox.Show("Your cart is empty!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ProgOps.scanForPaymentOption()) {
                DialogResult result = MessageBox.Show("Would you like to use your previous paying method?", "Payment",
                                                      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.No) {
                    Hide();
                    new frmPayment().Show();
                } else if (result == DialogResult.Yes) {
                    ProgOps.finalizeOrder(Cart.Tip);
                    dgvOrder.Rows.Clear();
                    btnCheckout.Text = "Checkout   $0.00";
                    lblTotal.Text = string.Empty;
                    lblSubtotal.Text = string.Empty;
                    lblTax.Text = string.Empty;
                    lblTip.Text = string.Empty;
                    tbxTip.Text = string.Empty;

                    frmReceipt receipt = new frmReceipt();
                    //create an object of the report
                    crptReceipt crptReceipt = new crptReceipt();
                    crptReceipt.Load(@"Reports\crptReceipt.rpt");

                    crptReceipt.SetParameterValue("OrderID", Cart.OrderID);

                    //set the database logon for the report
                    crptReceipt.SetDatabaseLogon("group2fa212330", "2547268");
                    //create an object of the frmViewer so we can use vrmViewer
                    //set to null first to clear the viewer
                    receipt.crvReceiptViewer.ReportSource = null;
                    //Then set the crvViewer to the report object
                    receipt.crvReceiptViewer.ReportSource = crptReceipt;
                    receipt.crvReceiptViewer.Refresh();
                    receipt.ShowDialog(); //opens an instance of the form now
                }
                else if(result == DialogResult.Cancel)
                {
                    return;
                }
            }else {
                Hide();
                new frmPayment().Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            Cart.clearCart(dgvOrder);
            Cart.fillBtnCheckoutText(btnCheckout);
            tbxTip.Text = string.Empty;
            Cart.Tip = 0;
            fillLabels();
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            Cart.removeFromCart(dgvOrder);
            Cart.fillBtnCheckoutText(btnCheckout);
            dgvOrder.Rows.Clear();

            foreach (KeyValuePair<int, MenuItem> item in Cart.myCart) {
                int row = dgvOrder.Rows.Add();
                dgvOrder.Rows[row].Cells[0].Value = item.Key;
                dgvOrder.Rows[row].Cells[1].Value = item.Value.ItemName;
                dgvOrder.Rows[row].Cells[2].Value = item.Value.IndividualPrice;
                dgvOrder.Rows[row].Cells[3].Value = item.Value.Quantity;
            }

            if (Cart.myCart.Count == 0)
            {
                Cart.Tip = 0;
                tbxTip.Text = string.Empty;
            }  

            fillLabels();
        }

        private void frmOrder_Load(object sender, EventArgs e) {
            if (Cart.myCart.Count == 0)
                tbxTip.Enabled = false;

            Cart.fillBtnCheckoutText(btnCheckout);

            dgvOrder.Rows.Clear();
            dgvOrder.ColumnCount = 4;
            dgvOrder.Columns[0].Name = "Item ID";
            dgvOrder.Columns[1].Name = "Item Name";
            dgvOrder.Columns[2].Name = "Item Price";
            dgvOrder.Columns[3].Name = "Quantity";

            foreach (KeyValuePair<int, MenuItem> item in Cart.myCart) {
                int row = dgvOrder.Rows.Add();
                dgvOrder.Rows[row].Cells[0].Value = item.Key;
                dgvOrder.Rows[row].Cells[1].Value = item.Value.ItemName;
                dgvOrder.Rows[row].Cells[2].Value = item.Value.IndividualPrice;
                dgvOrder.Rows[row].Cells[3].Value = item.Value.Quantity;
            }

            //subtotal, total and tax
            fillLabels();
        }

        private void tbxTip_KeyUp(object sender, KeyEventArgs e) {
            lblTotal.Text = string.Empty;
            Cart.Tip = 0;
            if (!string.IsNullOrEmpty(tbxTip.Text))
                Cart.Tip = decimal.Parse(tbxTip.Text);

            fillLabels();
        }

        private void fillLabels() {
            lblSubtotal.Text = Cart.SubTotal.ToString("c");
            lblTax.Text = Cart.Tax.ToString("c");
            lblTotal.Text = Cart.Total.ToString("C");
            lblTip.Text = Cart.Tip.ToString("c");
            btnCheckout.Text = $"Checkout  {Cart.Total:C}";
        }

        private void tbxTip_KeyDown(object sender, KeyEventArgs e) { }

        private void tbxTip_KeyPress(object sender, KeyPressEventArgs e) {
            
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == 8) || (e.KeyChar == 46))
            {
                 
                if (e.KeyChar == 46)
                    dotCounter++;
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
                tbxTip.Focus();
            else
                e.Handled = true;
        }

        private void tbxTip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
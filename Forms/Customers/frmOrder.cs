﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;


using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

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
                    Hide();
                    new frmPayment().Show();
                }
                else if (result == DialogResult.Yes)
                {
                    ProgOps.finalizeOrder();
                    dgvOrder.Rows.Clear();
                    btnCheckout.Text = "Checkout   $0.00";
                    lblTotal.Text = string.Empty;
                    lblSubtotal.Text = string.Empty;
                    lblTax.Text = string.Empty;


                    frmReceipt receipt = new frmReceipt();
                    //create an object of the report
                    Reports.crptReceipt crptReceipt = new Reports.crptReceipt();
                    crptReceipt.Load(@"Reports\crptReceipt.rpt");

                    MessageBox.Show(Cart.OrderID.ToString(), "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            else
            {
                Hide();
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

            fillLabels();

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

            //subtotal, total and tax
            fillLabels();


        }

        private void tbxTip_KeyUp(object sender, KeyEventArgs e)
        {
            lblTotal.Text = string.Empty;
            Cart.Tip = 0;

            if (tbxTip.Text != "")
            {
                Cart.Tip = Convert.ToDecimal(tbxTip.Text);
            }

            fillLabels();

        }


        private void fillLabels()
        {
            lblSubtotal.Text = Cart.SubTotal.ToString("c");
            lblTax.Text = Cart.Tax.ToString("c");
            lblTotal.Text = Cart.Total.ToString("C");
            btnCheckout.Text = $"Checkout  {Cart.Total:C}";
        }

        private void tbxTip_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

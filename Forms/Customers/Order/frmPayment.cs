#region Imports

using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Reports;
#endregion Imports

namespace BCD_Restaurant_Project.Forms.Customers.Order {
    public partial class frmPayment : Form {

        public frmPayment() {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e) {

            if (rdoPaymentOptionCard.Checked)
                ProgOps.insertPaymentOption(mskPaymentNumber.Text, "Credit", tbxName.Text, mskSecurityCode.Text,
                                   mskExpirationDate);
            else if (rdoPaymentOptiondebit.Checked)
                ProgOps.insertPaymentOption(mskPaymentNumber.Text, "Debit", tbxName.Text, mskSecurityCode.Text,
                                   mskExpirationDate);
            else if(!rdoPaymentOptionCard.Checked && !rdoPaymentOptiondebit.Checked)
            {
                MessageBox.Show("Choose card type", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Complete Order?", "Finalize Order", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                ProgOps.finalizeOrder(Cart.Tip);

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
            else
            {
                this.Close();
            }
            
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Hide();
        }
        private void frmPayment_Load(object sender, EventArgs e) { }
        private void mskExpirationDate_Click(object sender, EventArgs e) {
            mskExpirationDate.SelectionStart = 0;
        }
        private void mskExpirationDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void mskPaymentNumber_Click(object sender, EventArgs e) {
            mskPaymentNumber.SelectionStart = 0;
        }
        private void mskPaymentNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void mskSecurityCode_Click(object sender, EventArgs e) {
            mskSecurityCode.SelectionStart = 0;
        }
        private void rdoPaymentOptionCard_CheckedChanged(object sender, EventArgs e) {
            tbxName.Enabled = true;
            mskExpirationDate.Enabled = true;
            mskPaymentNumber.Enabled = true;
            mskSecurityCode.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void rdoPaymentOptionCheck_CheckedChanged(object sender, EventArgs e) {
            tbxName.Enabled = true;
            mskExpirationDate.Enabled = true;
            mskPaymentNumber.Enabled = true;
            mskSecurityCode.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void tbxName_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
                          (e.KeyChar == (char)Keys.Space));
        }
        private void tbxName_TextChanged(object sender, EventArgs e) { }
    }
}
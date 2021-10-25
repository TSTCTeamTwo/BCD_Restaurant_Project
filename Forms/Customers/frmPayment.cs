using System;
using System.Windows.Forms;

namespace BCD_Restaurant_Project.Forms
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void rdoPaymentOptionCash_CheckedChanged(object sender, EventArgs e)
        {
            tbxName.Enabled = false;
            mskExpirationDate.Enabled = false;
            mskPaymentNumber.Enabled = false;
            mskSecurityCode.Enabled = false;
            btnPay.Enabled = true;

            tbxName.Text = string.Empty;
            mskExpirationDate.Text = string.Empty;
            mskPaymentNumber.Text = string.Empty;
            mskSecurityCode.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
           
        }

        private void mskPaymentNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void mskPaymentNumber_Click(object sender, EventArgs e)
        {
            mskPaymentNumber.SelectionStart = 0;
        }

        private void mskSecurityCode_Click(object sender, EventArgs e)
        {
            mskSecurityCode.SelectionStart = 0;
        }

        private void mskExpirationDate_Click(object sender, EventArgs e)
        {
            mskExpirationDate.SelectionStart = 0;
        }

        private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void rdoPaymentOptionCheck_CheckedChanged(object sender, EventArgs e)
        {
            tbxName.Enabled = true;
            mskExpirationDate.Enabled = true;
            mskPaymentNumber.Enabled = true;
            mskSecurityCode.Enabled = true;
            btnPay.Enabled = true;
        }

        private void rdoPaymentOptionCard_CheckedChanged(object sender, EventArgs e)
        {
            tbxName.Enabled = true;
            mskExpirationDate.Enabled = true;
            mskPaymentNumber.Enabled = true;
            mskSecurityCode.Enabled = true;
            btnPay.Enabled = true;
        }
    }
}

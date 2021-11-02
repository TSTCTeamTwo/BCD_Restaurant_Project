using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms.Customers
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

            tbxName.Text = string.Empty;
            mskExpirationDate.Text = string.Empty;
            mskPaymentNumber.Text = string.Empty;
            mskSecurityCode.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (rdoPaymentOptionCard.Checked)
            {
                ProgOps.addPayment(mskPaymentNumber.Text, "Credit",tbxName.Text ,mskSecurityCode.Text, mskExpirationDate);
            }
            else if (rdoPaymentOptiondebit.Checked)
            {
                ProgOps.addPayment(mskPaymentNumber.Text, "Debit", tbxName.Text,mskSecurityCode.Text, mskExpirationDate);
            }
            
            
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
            btnCancel.Enabled = true;
        }

        private void rdoPaymentOptionCard_CheckedChanged(object sender, EventArgs e)
        {
            tbxName.Enabled = true;
            mskExpirationDate.Enabled = true;
            mskPaymentNumber.Enabled = true;
            mskSecurityCode.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mskExpirationDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

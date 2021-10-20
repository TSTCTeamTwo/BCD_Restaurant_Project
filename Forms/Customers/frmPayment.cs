using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}

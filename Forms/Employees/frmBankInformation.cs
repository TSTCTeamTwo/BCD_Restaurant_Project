﻿using System;
using System.Windows.Forms;
using System.Media;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms.Employees
{
    public partial class frmBankInformation : Form
    {
        public frmBankInformation()
        {
            InitializeComponent();
        }

        private void btnChangeNumbers_Click(object sender, EventArgs e)
        {
            tbxAccount.Enabled = true;
            tbxRouting.Enabled = true;
        }

        private void frmBankInformation_Load(object sender, EventArgs e)
        {
           ProgOps.bankInformation(tbxName, tbxEmail, tbxAccountID, tbxAccount, tbxRouting);
        }

        private void tbxAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 13)
            {
                tbxAccount.Focus();
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        private void tbxRouting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 13)
            {
                tbxAccount.Focus();
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }
    }
}

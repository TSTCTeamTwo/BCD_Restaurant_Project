﻿using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms.Employees
{
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            ProgOps.fillInPersonalInformation(tbxAccountID, tbxEmail, tbxUsername, tbxName, tbxPassword);
        }
    }
}

﻿using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmDesserts : Form
    {
        public frmDesserts()
        {
            InitializeComponent();
        }

        private void frmDesserts_Load(object sender, EventArgs e)
        {
            ProgOps.displayMenuItems(dgvDesserts, 3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            Cart.addToCartFromDesserts(dgvDesserts);
        }
    }
}

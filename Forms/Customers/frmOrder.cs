using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cart.clearCart(dgvOrder);
            Cart.buttonCalculate(btnCheckout);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Cart.removeFromCart(dgvOrder);
            Cart.buttonCalculate(btnCheckout);
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

        private void frmOrder_Load(object sender, EventArgs e)
        {
            Cart.buttonCalculate(btnCheckout);

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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            ProgOps.finalizeOrder();
        }
    }
}

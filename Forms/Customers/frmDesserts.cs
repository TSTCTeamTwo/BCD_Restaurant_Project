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
    public partial class frmDesserts : Form
    {
        public frmDesserts()
        {
            InitializeComponent();
        }

        private void frmDesserts_Load(object sender, EventArgs e)
        {
            ProgOps.DisplayMenuItems(dgvDesserts, 3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

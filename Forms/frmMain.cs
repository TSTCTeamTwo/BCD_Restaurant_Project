using System;
using System.Windows.Forms;

namespace BCD_Restaurant_Project.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Hello World!", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

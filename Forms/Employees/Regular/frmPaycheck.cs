#region Imports

using System.Windows.Forms;
using static BCD_Restaurant_Project.Classes.ProgOps;

#endregion

namespace BCD_Restaurant_Project.Forms.Employees.Regular {
    public partial class frmPaycheck : Form {
        public frmPaycheck() {
            InitializeComponent();
        }

        private void frmPaycheck_Load(object sender, System.EventArgs e) {
            populatePaychecks(dgvPaychecks);
        }
    }
}
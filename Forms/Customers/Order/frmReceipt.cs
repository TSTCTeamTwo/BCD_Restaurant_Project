#region

using System;
using System.Windows.Forms;

#endregion

namespace BCD_Restaurant_Project.Forms.Customers.Order {
    public partial class frmReceipt : Form {
        public frmReceipt() {
            InitializeComponent();
        }

        private void crvReceiptViewer_Load(object sender, EventArgs e) { }

        private void crvReceiptViewer_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                // Release the mouse capture started by the mouse down.
                crvReceiptViewer.Capture = false; //select control
                Capture = false;
                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), IntPtr.Zero);
                DefWndProc(ref msg);
            }
        }

        private void frmReceipt_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                // Release the mouse capture started by the mouse down.
                crvReceiptViewer.Capture = false; //select control
                Capture = false;
                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), IntPtr.Zero);
                DefWndProc(ref msg);
            }
        }
    }
}
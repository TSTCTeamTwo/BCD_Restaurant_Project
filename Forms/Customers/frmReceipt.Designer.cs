
namespace BCD_Restaurant_Project.Forms
{
    partial class frmReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvReceiptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReceiptViewer
            // 
            this.crvReceiptViewer.ActiveViewIndex = -1;
            this.crvReceiptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReceiptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReceiptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReceiptViewer.Location = new System.Drawing.Point(0, 0);
            this.crvReceiptViewer.Name = "crvReceiptViewer";
            this.crvReceiptViewer.Size = new System.Drawing.Size(800, 450);
            this.crvReceiptViewer.TabIndex = 0;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReceiptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReceipt";
            this.Text = "frmReceipt";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReceiptViewer;
    }
}
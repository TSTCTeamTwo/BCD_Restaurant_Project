
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
            this.crvReceiptViewer.Size = new System.Drawing.Size(1176, 769);
            this.crvReceiptViewer.TabIndex = 0;
            this.crvReceiptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvReceiptViewer.Load += new System.EventHandler(this.crvReceiptViewer_Load);
            this.crvReceiptViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crvReceiptViewer_MouseDown);
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 769);
            this.Controls.Add(this.crvReceiptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReceipt";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmReceipt_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReceiptViewer;
    }
}
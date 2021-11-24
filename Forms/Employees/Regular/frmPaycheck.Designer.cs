
namespace BCD_Restaurant_Project.Forms.Employees.Regular
{
    partial class frmPaycheck
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
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPaychecks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaychecks)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(336, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "PAY CHECK";
            // 
            // dgvPaychecks
            // 
            this.dgvPaychecks.AllowUserToAddRows = false;
            this.dgvPaychecks.AllowUserToDeleteRows = false;
            this.dgvPaychecks.AllowUserToResizeColumns = false;
            this.dgvPaychecks.AllowUserToResizeRows = false;
            this.dgvPaychecks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaychecks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPaychecks.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaychecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaychecks.Location = new System.Drawing.Point(58, 46);
            this.dgvPaychecks.Name = "dgvPaychecks";
            this.dgvPaychecks.ReadOnly = true;
            this.dgvPaychecks.RowHeadersVisible = false;
            this.dgvPaychecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaychecks.ShowCellErrors = false;
            this.dgvPaychecks.ShowCellToolTips = false;
            this.dgvPaychecks.ShowEditingIcon = false;
            this.dgvPaychecks.ShowRowErrors = false;
            this.dgvPaychecks.Size = new System.Drawing.Size(714, 376);
            this.dgvPaychecks.TabIndex = 23;
            // 
            // frmPaycheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 433);
            this.Controls.Add(this.dgvPaychecks);
            this.Controls.Add(this.label8);
            this.Name = "frmPaycheck";
            this.Text = "Paycheck";
            this.Load += new System.EventHandler(this.frmPaycheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaychecks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPaychecks;
    }
}

namespace BCD_Restaurant_Project.Forms
{
    partial class frmOrder
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeColumns = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(85, 37);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(877, 210);
            this.dgvOrder.TabIndex = 2;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(491, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Your order";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.White;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(159, 254);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(748, 44);
            this.btnCheckout.TabIndex = 0;
            this.btnCheckout.Text = "Checkout       $18.99";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(534, 306);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(373, 44);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(159, 306);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(369, 44);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 588);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnCheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
    }
}
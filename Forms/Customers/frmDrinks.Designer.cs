
namespace BCD_Restaurant_Project.Forms
{
    partial class frmDrinks
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
            this.pbxShakes = new System.Windows.Forms.PictureBox();
            this.dgvDrinks = new System.Windows.Forms.DataGridView();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxShakes
            // 
            this.pbxShakes.Image = global::BCD_Restaurant_Project.Properties.Resources.OIP__1_;
            this.pbxShakes.Location = new System.Drawing.Point(611, 12);
            this.pbxShakes.Name = "pbxShakes";
            this.pbxShakes.Size = new System.Drawing.Size(214, 303);
            this.pbxShakes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxShakes.TabIndex = 1;
            this.pbxShakes.TabStop = false;
            // 
            // dgvDrinks
            // 
            this.dgvDrinks.AllowUserToAddRows = false;
            this.dgvDrinks.AllowUserToDeleteRows = false;
            this.dgvDrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrinks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrinks.Location = new System.Drawing.Point(12, 12);
            this.dgvDrinks.Name = "dgvDrinks";
            this.dgvDrinks.ReadOnly = true;
            this.dgvDrinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrinks.Size = new System.Drawing.Size(593, 303);
            this.dgvDrinks.TabIndex = 0;
            this.dgvDrinks.SelectionChanged += new System.EventHandler(this.dgvDrinks_SelectionChanged);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToOrder.Location = new System.Drawing.Point(12, 321);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(116, 35);
            this.btnAddToOrder.TabIndex = 6;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // frmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 391);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.dgvDrinks);
            this.Controls.Add(this.pbxShakes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDrinks";
            this.Text = "Drinks";
            this.Load += new System.EventHandler(this.frmDrinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxShakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxShakes;
        private System.Windows.Forms.DataGridView dgvDrinks;
        private System.Windows.Forms.Button btnAddToOrder;
    }
}
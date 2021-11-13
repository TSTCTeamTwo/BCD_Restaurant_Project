
namespace BCD_Restaurant_Project.Forms.Customers.Menu
{
    partial class frmDesserts
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
            this.dgvDesserts = new System.Windows.Forms.DataGridView();
            this.pbxDesserts = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDesserts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDesserts
            // 
            this.dgvDesserts.AllowUserToAddRows = false;
            this.dgvDesserts.AllowUserToDeleteRows = false;
            this.dgvDesserts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesserts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDesserts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesserts.Location = new System.Drawing.Point(12, 11);
            this.dgvDesserts.Name = "dgvDesserts";
            this.dgvDesserts.ReadOnly = true;
            this.dgvDesserts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesserts.Size = new System.Drawing.Size(593, 550);
            this.dgvDesserts.TabIndex = 0;
            this.dgvDesserts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvDesserts.SelectionChanged += new System.EventHandler(this.dgvDesserts_SelectionChanged);
            // 
            // pbxDesserts
            // 
            this.pbxDesserts.Image = global::BCD_Restaurant_Project.Properties.Resources.download;
            this.pbxDesserts.Location = new System.Drawing.Point(611, 11);
            this.pbxDesserts.Name = "pbxDesserts";
            this.pbxDesserts.Size = new System.Drawing.Size(333, 392);
            this.pbxDesserts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDesserts.TabIndex = 1;
            this.pbxDesserts.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(608, 406);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(336, 117);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description Description\r\nDescription Description\r\nDescription Description";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToOrder.Location = new System.Drawing.Point(611, 526);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(116, 35);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // frmDesserts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 573);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.dgvDesserts);
            this.Controls.Add(this.pbxDesserts);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDesserts";
            this.Text = "Desserts";
            this.Load += new System.EventHandler(this.frmDesserts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDesserts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDesserts;
        private System.Windows.Forms.PictureBox pbxDesserts;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddToOrder;
    }
}
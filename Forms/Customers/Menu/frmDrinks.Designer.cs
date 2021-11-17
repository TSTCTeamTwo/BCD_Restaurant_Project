
namespace BCD_Restaurant_Project.Forms.Customers.Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.dgvDrinks = new System.Windows.Forms.DataGridView();
            this.pbxDrinks = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrinks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToOrder.Location = new System.Drawing.Point(20, 496);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(116, 35);
            this.btnAddToOrder.TabIndex = 7;
            this.btnAddToOrder.Text = "&Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // dgvDrinks
            // 
            this.dgvDrinks.AllowUserToAddRows = false;
            this.dgvDrinks.AllowUserToDeleteRows = false;
            this.dgvDrinks.AllowUserToResizeColumns = false;
            this.dgvDrinks.AllowUserToResizeRows = false;
            this.dgvDrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrinks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDrinks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDrinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrinks.CausesValidation = false;
            this.dgvDrinks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrinks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrinks.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrinks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrinks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDrinks.GridColor = System.Drawing.Color.Black;
            this.dgvDrinks.Location = new System.Drawing.Point(20, 12);
            this.dgvDrinks.MultiSelect = false;
            this.dgvDrinks.Name = "dgvDrinks";
            this.dgvDrinks.ReadOnly = true;
            this.dgvDrinks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDrinks.RowHeadersVisible = false;
            this.dgvDrinks.RowHeadersWidth = 51;
            this.dgvDrinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrinks.ShowCellErrors = false;
            this.dgvDrinks.ShowCellToolTips = false;
            this.dgvDrinks.ShowEditingIcon = false;
            this.dgvDrinks.ShowRowErrors = false;
            this.dgvDrinks.Size = new System.Drawing.Size(793, 478);
            this.dgvDrinks.TabIndex = 5;
            this.dgvDrinks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrinks_CellContentClick);
            this.dgvDrinks.SelectionChanged += new System.EventHandler(this.dgvDrinks_SelectionChanged);
            // 
            // pbxDrinks
            // 
            this.pbxDrinks.Image = global::BCD_Restaurant_Project.Properties.Resources.P;
            this.pbxDrinks.Location = new System.Drawing.Point(822, 110);
            this.pbxDrinks.Name = "pbxDrinks";
            this.pbxDrinks.Size = new System.Drawing.Size(214, 218);
            this.pbxDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDrinks.TabIndex = 6;
            this.pbxDrinks.TabStop = false;
            // 
            // frmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 543);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.dgvDrinks);
            this.Controls.Add(this.pbxDrinks);
            this.Name = "frmDrinks";
            this.Text = "Drinks";
            this.Load += new System.EventHandler(this.frmDrinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.DataGridView dgvDrinks;
        private System.Windows.Forms.PictureBox pbxDrinks;
    }
}
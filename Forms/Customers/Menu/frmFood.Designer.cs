
namespace BCD_Restaurant_Project.Forms.Customers.Menu
{
    partial class frmFood
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
            this.pbxFood = new System.Windows.Forms.PictureBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToOrder.Location = new System.Drawing.Point(12, 496);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(116, 35);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "&Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // pbxFood
            // 
            this.pbxFood.Image = global::BCD_Restaurant_Project.Properties.Resources.P;
            this.pbxFood.Location = new System.Drawing.Point(814, 110);
            this.pbxFood.Name = "pbxFood";
            this.pbxFood.Size = new System.Drawing.Size(214, 218);
            this.pbxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFood.TabIndex = 1;
            this.pbxFood.TabStop = false;
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AllowUserToResizeColumns = false;
            this.dgvFood.AllowUserToResizeRows = false;
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFood.CausesValidation = false;
            this.dgvFood.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFood.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFood.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFood.GridColor = System.Drawing.Color.Black;
            this.dgvFood.Location = new System.Drawing.Point(12, 12);
            this.dgvFood.MultiSelect = false;
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.ReadOnly = true;
            this.dgvFood.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.ShowCellErrors = false;
            this.dgvFood.ShowCellToolTips = false;
            this.dgvFood.ShowEditingIcon = false;
            this.dgvFood.ShowRowErrors = false;
            this.dgvFood.Size = new System.Drawing.Size(793, 478);
            this.dgvFood.TabIndex = 0;
            this.dgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentClick);
            this.dgvFood.SelectionChanged += new System.EventHandler(this.dgvFood_SelectionChanged);
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 543);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.pbxFood);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food";
            this.Load += new System.EventHandler(this.frmFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.PictureBox pbxFood;
        private System.Windows.Forms.DataGridView dgvFood;
    }
}
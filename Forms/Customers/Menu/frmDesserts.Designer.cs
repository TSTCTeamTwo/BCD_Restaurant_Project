
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesserts));
            this.pbxDesserts = new System.Windows.Forms.PictureBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.dgvDesserts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDesserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesserts)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDesserts
            // 
            this.pbxDesserts.Image = global::BCD_Restaurant_Project.Properties.Resources.download;
            this.pbxDesserts.Location = new System.Drawing.Point(698, 22);
            this.pbxDesserts.Name = "pbxDesserts";
            this.pbxDesserts.Size = new System.Drawing.Size(333, 392);
            this.pbxDesserts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDesserts.TabIndex = 1;
            this.pbxDesserts.TabStop = false;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddToOrder.Location = new System.Drawing.Point(171, 539);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(116, 35);
            this.btnAddToOrder.TabIndex = 4;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // dgvDesserts
            // 
            this.dgvDesserts.AllowUserToAddRows = false;
            this.dgvDesserts.AllowUserToDeleteRows = false;
            this.dgvDesserts.AllowUserToResizeColumns = false;
            this.dgvDesserts.AllowUserToResizeRows = false;
            this.dgvDesserts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesserts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDesserts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDesserts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDesserts.CausesValidation = false;
            this.dgvDesserts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDesserts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDesserts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesserts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDesserts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDesserts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDesserts.GridColor = System.Drawing.Color.Black;
            this.dgvDesserts.Location = new System.Drawing.Point(81, 12);
            this.dgvDesserts.MultiSelect = false;
            this.dgvDesserts.Name = "dgvDesserts";
            this.dgvDesserts.ReadOnly = true;
            this.dgvDesserts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDesserts.RowHeadersVisible = false;
            this.dgvDesserts.RowHeadersWidth = 51;
            this.dgvDesserts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesserts.ShowCellErrors = false;
            this.dgvDesserts.ShowCellToolTips = false;
            this.dgvDesserts.ShowEditingIcon = false;
            this.dgvDesserts.ShowRowErrors = false;
            this.dgvDesserts.Size = new System.Drawing.Size(599, 530);
            this.dgvDesserts.TabIndex = 5;
            this.dgvDesserts.SelectionChanged += new System.EventHandler(this.dgvDesserts_SelectionChanged_1);
            // 
            // frmDesserts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 601);
            this.Controls.Add(this.dgvDesserts);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.pbxDesserts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDesserts";
            this.Text = "Desserts";
            this.Load += new System.EventHandler(this.frmDesserts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDesserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesserts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxDesserts;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.DataGridView dgvDesserts;
    }
}
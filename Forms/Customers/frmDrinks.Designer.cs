
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
            this.btnReturnToDrinks = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbxShakes = new System.Windows.Forms.PictureBox();
            this.dgvShakes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShakes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnToDrinks
            // 
            this.btnReturnToDrinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturnToDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToDrinks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnToDrinks.Location = new System.Drawing.Point(90, 341);
            this.btnReturnToDrinks.Name = "btnReturnToDrinks";
            this.btnReturnToDrinks.Size = new System.Drawing.Size(156, 35);
            this.btnReturnToDrinks.TabIndex = 5;
            this.btnReturnToDrinks.Text = "Return to drinks";
            this.btnReturnToDrinks.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckout.Location = new System.Drawing.Point(497, 341);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(186, 35);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "Add shake to meal";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(689, 317);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(116, 39);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description Description\r\nDescription Description\r\nDescription Description";
            // 
            // pbxShakes
            // 
            this.pbxShakes.Image = global::BCD_Restaurant_Project.Properties.Resources.OIP__1_;
            this.pbxShakes.Location = new System.Drawing.Point(692, 32);
            this.pbxShakes.Name = "pbxShakes";
            this.pbxShakes.Size = new System.Drawing.Size(214, 282);
            this.pbxShakes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxShakes.TabIndex = 1;
            this.pbxShakes.TabStop = false;
            // 
            // dgvShakes
            // 
            this.dgvShakes.AllowUserToAddRows = false;
            this.dgvShakes.AllowUserToDeleteRows = false;
            this.dgvShakes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShakes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvShakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShakes.Location = new System.Drawing.Point(90, 32);
            this.dgvShakes.Name = "dgvShakes";
            this.dgvShakes.ReadOnly = true;
            this.dgvShakes.Size = new System.Drawing.Size(593, 303);
            this.dgvShakes.TabIndex = 0;
            this.dgvShakes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 643);
            this.Controls.Add(this.btnReturnToDrinks);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dgvShakes);
            this.Controls.Add(this.pbxShakes);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDrinks";
            this.Text = "Drinks";
            this.Load += new System.EventHandler(this.frmDrinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxShakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShakes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturnToDrinks;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbxShakes;
        private System.Windows.Forms.DataGridView dgvShakes;
    }
}
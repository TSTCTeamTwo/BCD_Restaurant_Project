
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pnlLogin.Controls.Add(this.dataGridView1);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(107, 13);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(412, 249);
            this.pnlLogin.TabIndex = 4;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(17, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Your order";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(21, 195);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(368, 44);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Checkout       $18.99";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.Text = "frmOrder";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
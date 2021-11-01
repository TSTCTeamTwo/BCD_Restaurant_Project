
namespace BCD_Restaurant_Project.Forms
{
    partial class frmNewPassword
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
            this.lnkReturn = new System.Windows.Forms.LinkLabel();
            this.lblNoMatch = new System.Windows.Forms.Label();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pnlLogin.Controls.Add(this.lnkReturn);
            this.pnlLogin.Controls.Add(this.lblNoMatch);
            this.pnlLogin.Controls.Add(this.tbxConfirm);
            this.pnlLogin.Controls.Add(this.tbxPassword);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.btnConfirm);
            this.pnlLogin.Location = new System.Drawing.Point(43, 26);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(412, 249);
            this.pnlLogin.TabIndex = 4;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // lnkReturn
            // 
            this.lnkReturn.AutoSize = true;
            this.lnkReturn.Location = new System.Drawing.Point(147, 206);
            this.lnkReturn.Name = "lnkReturn";
            this.lnkReturn.Size = new System.Drawing.Size(84, 13);
            this.lnkReturn.TabIndex = 10;
            this.lnkReturn.TabStop = true;
            this.lnkReturn.Text = "Return To Login";
            this.lnkReturn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReturn_LinkClicked);
            // 
            // lblNoMatch
            // 
            this.lblNoMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNoMatch.AutoSize = true;
            this.lblNoMatch.Enabled = false;
            this.lblNoMatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoMatch.Location = new System.Drawing.Point(208, 113);
            this.lblNoMatch.Name = "lblNoMatch";
            this.lblNoMatch.Size = new System.Drawing.Size(129, 13);
            this.lblNoMatch.TabIndex = 9;
            this.lblNoMatch.Text = "Password does not match";
            this.lblNoMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoMatch.Visible = false;
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.BackColor = System.Drawing.Color.White;
            this.tbxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirm.Location = new System.Drawing.Point(174, 73);
            this.tbxConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.PasswordChar = '•';
            this.tbxConfirm.Size = new System.Drawing.Size(199, 26);
            this.tbxConfirm.TabIndex = 4;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.White;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(174, 23);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '•';
            this.tbxPassword.Size = new System.Drawing.Size(199, 26);
            this.tbxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Confirm Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(53, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "New Password";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.White;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(132, 146);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 44);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm New Password";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmNewPassword
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Reset";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblNoMatch;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.LinkLabel lnkReturn;
    }
}
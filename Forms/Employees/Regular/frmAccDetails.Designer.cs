
namespace BCD_Restaurant_Project.Forms.Employees.Regular
{
    partial class frmAccDetails
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAccountID = new System.Windows.Forms.TextBox();
            this.btnChangeInformation = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnConfirmInformation = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.White;
            this.tbxUsername.Enabled = false;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(249, 139);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(199, 26);
            this.tbxUsername.TabIndex = 7;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.White;
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(249, 106);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(199, 26);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.White;
            this.tbxName.Enabled = false;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(249, 75);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(199, 26);
            this.tbxName.TabIndex = 3;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxAccountID
            // 
            this.tbxAccountID.BackColor = System.Drawing.Color.White;
            this.tbxAccountID.Enabled = false;
            this.tbxAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccountID.Location = new System.Drawing.Point(249, 41);
            this.tbxAccountID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAccountID.Name = "tbxAccountID";
            this.tbxAccountID.ReadOnly = true;
            this.tbxAccountID.Size = new System.Drawing.Size(69, 26);
            this.tbxAccountID.TabIndex = 1;
            // 
            // btnChangeInformation
            // 
            this.btnChangeInformation.BackColor = System.Drawing.Color.White;
            this.btnChangeInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeInformation.Location = new System.Drawing.Point(116, 295);
            this.btnChangeInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeInformation.Name = "btnChangeInformation";
            this.btnChangeInformation.Size = new System.Drawing.Size(148, 28);
            this.btnChangeInformation.TabIndex = 14;
            this.btnChangeInformation.Text = "&Change Information";
            this.btnChangeInformation.UseVisualStyleBackColor = false;
            this.btnChangeInformation.Click += new System.EventHandler(this.btnChangeInformation_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(115, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Account ID";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.White;
            this.tbxPassword.Enabled = false;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(249, 173);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(199, 26);
            this.tbxPassword.TabIndex = 9;
            // 
            // btnConfirmInformation
            // 
            this.btnConfirmInformation.BackColor = System.Drawing.Color.White;
            this.btnConfirmInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmInformation.Location = new System.Drawing.Point(351, 295);
            this.btnConfirmInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmInformation.Name = "btnConfirmInformation";
            this.btnConfirmInformation.Size = new System.Drawing.Size(148, 28);
            this.btnConfirmInformation.TabIndex = 15;
            this.btnConfirmInformation.Text = "C&onfirm Information";
            this.btnConfirmInformation.UseVisualStyleBackColor = false;
            this.btnConfirmInformation.Click += new System.EventHandler(this.btnConfirmInformation_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(115, 247);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPhone
            // 
            this.tbxPhone.BackColor = System.Drawing.Color.White;
            this.tbxPhone.Enabled = false;
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(249, 241);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPhone.MaxLength = 10;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(199, 26);
            this.tbxPhone.TabIndex = 13;
            this.tbxPhone.TextChanged += new System.EventHandler(this.tbxPhone_TextChanged);
            this.tbxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhone_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(115, 213);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackColor = System.Drawing.Color.White;
            this.tbxAddress.Enabled = false;
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(249, 207);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(199, 26);
            this.tbxAddress.TabIndex = 11;
            // 
            // frmAccDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 336);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.btnConfirmInformation);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChangeInformation);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxAccountID);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Name = "frmAccDetails";
            this.Text = "Account Details";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAccountID;
        private System.Windows.Forms.Button btnChangeInformation;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnConfirmInformation;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxAddress;
    }
}
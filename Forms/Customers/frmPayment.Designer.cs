
namespace BCD_Restaurant_Project.Forms
{
    partial class frmPayment
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
            this.rdoPaymentOptionCash = new System.Windows.Forms.RadioButton();
            this.rdoPaymentOptionCheck = new System.Windows.Forms.RadioButton();
            this.rdoPaymentOptionCard = new System.Windows.Forms.RadioButton();
            this.mskExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.mskSecurityCode = new System.Windows.Forms.MaskedTextBox();
            this.mskPaymentNumber = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pnlLogin.Controls.Add(this.rdoPaymentOptionCash);
            this.pnlLogin.Controls.Add(this.rdoPaymentOptionCheck);
            this.pnlLogin.Controls.Add(this.rdoPaymentOptionCard);
            this.pnlLogin.Controls.Add(this.mskExpirationDate);
            this.pnlLogin.Controls.Add(this.mskSecurityCode);
            this.pnlLogin.Controls.Add(this.mskPaymentNumber);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.tbxUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(44, 39);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(462, 390);
            this.pnlLogin.TabIndex = 6;
            // 
            // rdoPaymentOptionCash
            // 
            this.rdoPaymentOptionCash.AutoSize = true;
            this.rdoPaymentOptionCash.Location = new System.Drawing.Point(304, 87);
            this.rdoPaymentOptionCash.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPaymentOptionCash.Name = "rdoPaymentOptionCash";
            this.rdoPaymentOptionCash.Size = new System.Drawing.Size(49, 17);
            this.rdoPaymentOptionCash.TabIndex = 28;
            this.rdoPaymentOptionCash.TabStop = true;
            this.rdoPaymentOptionCash.Text = "Cash";
            this.rdoPaymentOptionCash.UseVisualStyleBackColor = true;
            // 
            // rdoPaymentOptionCheck
            // 
            this.rdoPaymentOptionCheck.AutoSize = true;
            this.rdoPaymentOptionCheck.Location = new System.Drawing.Point(248, 87);
            this.rdoPaymentOptionCheck.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPaymentOptionCheck.Name = "rdoPaymentOptionCheck";
            this.rdoPaymentOptionCheck.Size = new System.Drawing.Size(56, 17);
            this.rdoPaymentOptionCheck.TabIndex = 27;
            this.rdoPaymentOptionCheck.TabStop = true;
            this.rdoPaymentOptionCheck.Text = "Check";
            this.rdoPaymentOptionCheck.UseVisualStyleBackColor = true;
            // 
            // rdoPaymentOptionCard
            // 
            this.rdoPaymentOptionCard.AutoSize = true;
            this.rdoPaymentOptionCard.Location = new System.Drawing.Point(200, 87);
            this.rdoPaymentOptionCard.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPaymentOptionCard.Name = "rdoPaymentOptionCard";
            this.rdoPaymentOptionCard.Size = new System.Drawing.Size(47, 17);
            this.rdoPaymentOptionCard.TabIndex = 26;
            this.rdoPaymentOptionCard.TabStop = true;
            this.rdoPaymentOptionCard.Text = "Card";
            this.rdoPaymentOptionCard.UseVisualStyleBackColor = true;
            // 
            // mskExpirationDate
            // 
            this.mskExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskExpirationDate.Location = new System.Drawing.Point(200, 176);
            this.mskExpirationDate.Margin = new System.Windows.Forms.Padding(2);
            this.mskExpirationDate.Mask = "00/00";
            this.mskExpirationDate.Name = "mskExpirationDate";
            this.mskExpirationDate.Size = new System.Drawing.Size(45, 26);
            this.mskExpirationDate.TabIndex = 25;
            // 
            // mskSecurityCode
            // 
            this.mskSecurityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskSecurityCode.Location = new System.Drawing.Point(200, 145);
            this.mskSecurityCode.Margin = new System.Windows.Forms.Padding(2);
            this.mskSecurityCode.Mask = "000";
            this.mskSecurityCode.Name = "mskSecurityCode";
            this.mskSecurityCode.Size = new System.Drawing.Size(36, 26);
            this.mskSecurityCode.TabIndex = 24;
            // 
            // mskPaymentNumber
            // 
            this.mskPaymentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskPaymentNumber.Location = new System.Drawing.Point(200, 111);
            this.mskPaymentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.mskPaymentNumber.Mask = "0000 0000 0000 0000";
            this.mskPaymentNumber.Name = "mskPaymentNumber";
            this.mskPaymentNumber.Size = new System.Drawing.Size(152, 26);
            this.mskPaymentNumber.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Expiration Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Security Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.White;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(200, 50);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(199, 26);
            this.tbxUsername.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(65, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(31, 13);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Type";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(65, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 13);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Name On Card";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Payment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(132, 219);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(199, 44);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Add Payment";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 503);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MaskedTextBox mskPaymentNumber;
        private System.Windows.Forms.MaskedTextBox mskExpirationDate;
        private System.Windows.Forms.MaskedTextBox mskSecurityCode;
        private System.Windows.Forms.RadioButton rdoPaymentOptionCash;
        private System.Windows.Forms.RadioButton rdoPaymentOptionCheck;
        private System.Windows.Forms.RadioButton rdoPaymentOptionCard;
    }
}
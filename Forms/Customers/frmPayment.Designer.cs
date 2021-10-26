
namespace BCD_Restaurant_Project.Forms.Customers
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
            this.rdoPaymentOptiondebit = new System.Windows.Forms.RadioButton();
            this.rdoPaymentOptionCard = new System.Windows.Forms.RadioButton();
            this.mskExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.mskSecurityCode = new System.Windows.Forms.MaskedTextBox();
            this.mskPaymentNumber = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoPaymentOptiondebit
            // 
            this.rdoPaymentOptiondebit.AutoSize = true;
            this.rdoPaymentOptiondebit.Location = new System.Drawing.Point(203, 69);
            this.rdoPaymentOptiondebit.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPaymentOptiondebit.Name = "rdoPaymentOptiondebit";
            this.rdoPaymentOptiondebit.Size = new System.Drawing.Size(50, 17);
            this.rdoPaymentOptiondebit.TabIndex = 41;
            this.rdoPaymentOptiondebit.TabStop = true;
            this.rdoPaymentOptiondebit.Text = "Debit";
            this.rdoPaymentOptiondebit.UseVisualStyleBackColor = true;
            this.rdoPaymentOptiondebit.CheckedChanged += new System.EventHandler(this.rdoPaymentOptionCheck_CheckedChanged);
            // 
            // rdoPaymentOptionCard
            // 
            this.rdoPaymentOptionCard.AutoSize = true;
            this.rdoPaymentOptionCard.Location = new System.Drawing.Point(155, 69);
            this.rdoPaymentOptionCard.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPaymentOptionCard.Name = "rdoPaymentOptionCard";
            this.rdoPaymentOptionCard.Size = new System.Drawing.Size(52, 17);
            this.rdoPaymentOptionCard.TabIndex = 40;
            this.rdoPaymentOptionCard.TabStop = true;
            this.rdoPaymentOptionCard.Text = "Credit";
            this.rdoPaymentOptionCard.UseVisualStyleBackColor = true;
            this.rdoPaymentOptionCard.CheckedChanged += new System.EventHandler(this.rdoPaymentOptionCard_CheckedChanged);
            // 
            // mskExpirationDate
            // 
            this.mskExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskExpirationDate.Location = new System.Drawing.Point(155, 158);
            this.mskExpirationDate.Margin = new System.Windows.Forms.Padding(2);
            this.mskExpirationDate.Mask = "00/00";
            this.mskExpirationDate.Name = "mskExpirationDate";
            this.mskExpirationDate.Size = new System.Drawing.Size(45, 26);
            this.mskExpirationDate.TabIndex = 39;
            this.mskExpirationDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskExpirationDate_MaskInputRejected);
            this.mskExpirationDate.Click += new System.EventHandler(this.mskExpirationDate_Click);
            // 
            // mskSecurityCode
            // 
            this.mskSecurityCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskSecurityCode.Location = new System.Drawing.Point(155, 127);
            this.mskSecurityCode.Margin = new System.Windows.Forms.Padding(2);
            this.mskSecurityCode.Mask = "000";
            this.mskSecurityCode.Name = "mskSecurityCode";
            this.mskSecurityCode.Size = new System.Drawing.Size(36, 26);
            this.mskSecurityCode.TabIndex = 38;
            this.mskSecurityCode.Click += new System.EventHandler(this.mskSecurityCode_Click);
            // 
            // mskPaymentNumber
            // 
            this.mskPaymentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskPaymentNumber.Location = new System.Drawing.Point(155, 93);
            this.mskPaymentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.mskPaymentNumber.Mask = "0000000000000000";
            this.mskPaymentNumber.Name = "mskPaymentNumber";
            this.mskPaymentNumber.Size = new System.Drawing.Size(151, 26);
            this.mskPaymentNumber.TabIndex = 37;
            this.mskPaymentNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskPaymentNumber_MaskInputRejected);
            this.mskPaymentNumber.Click += new System.EventHandler(this.mskPaymentNumber_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Expiration Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Security Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.White;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(155, 32);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(199, 26);
            this.tbxName.TabIndex = 33;
            this.tbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxName_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(31, 13);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Type";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 37);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 13);
            this.lblUsername.TabIndex = 31;
            this.lblUsername.Text = "Name On Card";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Add Payment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(87, 201);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 44);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add Payment";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(87, 253);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(199, 44);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 323);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rdoPaymentOptiondebit);
            this.Controls.Add(this.rdoPaymentOptionCard);
            this.Controls.Add(this.mskExpirationDate);
            this.Controls.Add(this.mskSecurityCode);
            this.Controls.Add(this.mskPaymentNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoPaymentOptiondebit;
        private System.Windows.Forms.RadioButton rdoPaymentOptionCard;
        private System.Windows.Forms.MaskedTextBox mskExpirationDate;
        private System.Windows.Forms.MaskedTextBox mskSecurityCode;
        private System.Windows.Forms.MaskedTextBox mskPaymentNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}

namespace BCD_Restaurant_Project.Forms.Employees
{
    partial class frmBankInformation
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
            this.gbxBankInformation = new System.Windows.Forms.GroupBox();
            this.btnConfirmNewDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.tbxRouting = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lnkLblReturn = new System.Windows.Forms.LinkLabel();
            this.btnChangeNumbers = new System.Windows.Forms.Button();
            this.tbxAccountID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxBankInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBankInformation
            // 
            this.gbxBankInformation.Controls.Add(this.btnConfirmNewDeposit);
            this.gbxBankInformation.Controls.Add(this.label2);
            this.gbxBankInformation.Controls.Add(this.tbxAccount);
            this.gbxBankInformation.Controls.Add(this.tbxRouting);
            this.gbxBankInformation.Controls.Add(this.label3);
            this.gbxBankInformation.Controls.Add(this.lblUsername);
            this.gbxBankInformation.Controls.Add(this.lnkLblReturn);
            this.gbxBankInformation.Controls.Add(this.btnChangeNumbers);
            this.gbxBankInformation.Controls.Add(this.tbxAccountID);
            this.gbxBankInformation.Controls.Add(this.label1);
            this.gbxBankInformation.Controls.Add(this.tbxName);
            this.gbxBankInformation.Controls.Add(this.tbxEmail);
            this.gbxBankInformation.Controls.Add(this.label4);
            this.gbxBankInformation.Location = new System.Drawing.Point(22, 30);
            this.gbxBankInformation.Margin = new System.Windows.Forms.Padding(2);
            this.gbxBankInformation.Name = "gbxBankInformation";
            this.gbxBankInformation.Padding = new System.Windows.Forms.Padding(2);
            this.gbxBankInformation.Size = new System.Drawing.Size(403, 306);
            this.gbxBankInformation.TabIndex = 21;
            this.gbxBankInformation.TabStop = false;
            this.gbxBankInformation.Text = "Bank Information";
            // 
            // btnConfirmNewDeposit
            // 
            this.btnConfirmNewDeposit.BackColor = System.Drawing.Color.White;
            this.btnConfirmNewDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmNewDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmNewDeposit.Location = new System.Drawing.Point(25, 252);
            this.btnConfirmNewDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmNewDeposit.Name = "btnConfirmNewDeposit";
            this.btnConfirmNewDeposit.Size = new System.Drawing.Size(166, 28);
            this.btnConfirmNewDeposit.TabIndex = 25;
            this.btnConfirmNewDeposit.Text = "C&onfirm New Deposit";
            this.btnConfirmNewDeposit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Routing Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxAccount
            // 
            this.tbxAccount.BackColor = System.Drawing.Color.White;
            this.tbxAccount.Enabled = false;
            this.tbxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccount.Location = new System.Drawing.Point(156, 159);
            this.tbxAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.Size = new System.Drawing.Size(199, 26);
            this.tbxAccount.TabIndex = 24;
            this.tbxAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAccount_KeyPress);
            // 
            // tbxRouting
            // 
            this.tbxRouting.BackColor = System.Drawing.Color.White;
            this.tbxRouting.Enabled = false;
            this.tbxRouting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRouting.Location = new System.Drawing.Point(156, 125);
            this.tbxRouting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxRouting.Name = "tbxRouting";
            this.tbxRouting.Size = new System.Drawing.Size(199, 26);
            this.tbxRouting.TabIndex = 22;
            this.tbxRouting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRouting_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Account Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(22, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Account ID";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkLblReturn
            // 
            this.lnkLblReturn.AutoSize = true;
            this.lnkLblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblReturn.Location = new System.Drawing.Point(283, 225);
            this.lnkLblReturn.Name = "lnkLblReturn";
            this.lnkLblReturn.Size = new System.Drawing.Size(52, 18);
            this.lnkLblReturn.TabIndex = 5;
            this.lnkLblReturn.TabStop = true;
            this.lnkLblReturn.Text = "Return";
            // 
            // btnChangeNumbers
            // 
            this.btnChangeNumbers.BackColor = System.Drawing.Color.White;
            this.btnChangeNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeNumbers.Location = new System.Drawing.Point(25, 203);
            this.btnChangeNumbers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangeNumbers.Name = "btnChangeNumbers";
            this.btnChangeNumbers.Size = new System.Drawing.Size(233, 28);
            this.btnChangeNumbers.TabIndex = 20;
            this.btnChangeNumbers.Text = "&Change Routing/Account Number";
            this.btnChangeNumbers.UseVisualStyleBackColor = false;
            this.btnChangeNumbers.Click += new System.EventHandler(this.btnChangeNumbers_Click);
            // 
            // tbxAccountID
            // 
            this.tbxAccountID.BackColor = System.Drawing.Color.White;
            this.tbxAccountID.Enabled = false;
            this.tbxAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccountID.Location = new System.Drawing.Point(156, 23);
            this.tbxAccountID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAccountID.Name = "tbxAccountID";
            this.tbxAccountID.Size = new System.Drawing.Size(69, 26);
            this.tbxAccountID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.White;
            this.tbxName.Enabled = false;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(156, 89);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(199, 26);
            this.tbxName.TabIndex = 17;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.White;
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(156, 55);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(199, 26);
            this.tbxEmail.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBankInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxBankInformation);
            this.Name = "frmBankInformation";
            this.Text = "Bank Information";
            this.Load += new System.EventHandler(this.frmBankInformation_Load);
            this.gbxBankInformation.ResumeLayout(false);
            this.gbxBankInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxBankInformation;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel lnkLblReturn;
        private System.Windows.Forms.Button btnChangeNumbers;
        private System.Windows.Forms.TextBox tbxAccountID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmNewDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.TextBox tbxRouting;
        private System.Windows.Forms.Label label3;
    }
}
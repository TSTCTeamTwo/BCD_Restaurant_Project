
namespace BCD_Restaurant_Project.Forms.Employees
{
    partial class frmManageAccounts
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
            this.tbxDesignateAccountAsEmployee = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.cbxMakeAccountAdmin = new System.Windows.Forms.CheckBox();
            this.btnDeleteEmployeeAccount = new System.Windows.Forms.Button();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbxAccountID = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxDesignateAccountAsEmployee
            // 
            this.tbxDesignateAccountAsEmployee.BackColor = System.Drawing.Color.White;
            this.tbxDesignateAccountAsEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbxDesignateAccountAsEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesignateAccountAsEmployee.Location = new System.Drawing.Point(512, 245);
            this.tbxDesignateAccountAsEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDesignateAccountAsEmployee.Name = "tbxDesignateAccountAsEmployee";
            this.tbxDesignateAccountAsEmployee.Size = new System.Drawing.Size(330, 30);
            this.tbxDesignateAccountAsEmployee.TabIndex = 30;
            this.tbxDesignateAccountAsEmployee.Text = "&Designate Account As Employee";
            this.tbxDesignateAccountAsEmployee.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPassword);
            this.groupBox3.Controls.Add(this.tbxEmployeeID);
            this.groupBox3.Controls.Add(this.cbxMakeAccountAdmin);
            this.groupBox3.Controls.Add(this.btnDeleteEmployeeAccount);
            this.groupBox3.Location = new System.Drawing.Point(491, 281);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(368, 79);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee/Manager Account";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 23);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Employee ID";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.BackColor = System.Drawing.Color.White;
            this.tbxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeID.Location = new System.Drawing.Point(88, 19);
            this.tbxEmployeeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.Size = new System.Drawing.Size(127, 26);
            this.tbxEmployeeID.TabIndex = 10;
            // 
            // cbxMakeAccountAdmin
            // 
            this.cbxMakeAccountAdmin.AutoSize = true;
            this.cbxMakeAccountAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.cbxMakeAccountAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMakeAccountAdmin.Location = new System.Drawing.Point(20, 50);
            this.cbxMakeAccountAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMakeAccountAdmin.Name = "cbxMakeAccountAdmin";
            this.cbxMakeAccountAdmin.Size = new System.Drawing.Size(174, 17);
            this.cbxMakeAccountAdmin.TabIndex = 21;
            this.cbxMakeAccountAdmin.Text = "Make This Account A Manager";
            this.cbxMakeAccountAdmin.UseVisualStyleBackColor = false;
            // 
            // btnDeleteEmployeeAccount
            // 
            this.btnDeleteEmployeeAccount.BackColor = System.Drawing.Color.White;
            this.btnDeleteEmployeeAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteEmployeeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployeeAccount.Location = new System.Drawing.Point(226, 17);
            this.btnDeleteEmployeeAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteEmployeeAccount.Name = "btnDeleteEmployeeAccount";
            this.btnDeleteEmployeeAccount.Size = new System.Drawing.Size(136, 45);
            this.btnDeleteEmployeeAccount.TabIndex = 24;
            this.btnDeleteEmployeeAccount.Text = "De&lete Employee Record";
            this.btnDeleteEmployeeAccount.UseVisualStyleBackColor = false;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.BackColor = System.Drawing.Color.White;
            this.tbxConfirmPassword.Enabled = false;
            this.tbxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmPassword.Location = new System.Drawing.Point(643, 145);
            this.tbxConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(199, 26);
            this.tbxConfirmPassword.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Confirm Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.White;
            this.tbxPassword.Enabled = false;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.Location = new System.Drawing.Point(643, 112);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(199, 26);
            this.tbxPassword.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(735, 366);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 28);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "&Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(626, 366);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 28);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(509, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Account ID";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(654, 398);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 18);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Return";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(517, 366);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(99, 28);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // tbxAccountID
            // 
            this.tbxAccountID.BackColor = System.Drawing.Color.White;
            this.tbxAccountID.Enabled = false;
            this.tbxAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccountID.Location = new System.Drawing.Point(643, 11);
            this.tbxAccountID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAccountID.Name = "tbxAccountID";
            this.tbxAccountID.Size = new System.Drawing.Size(69, 26);
            this.tbxAccountID.TabIndex = 9;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.White;
            this.tbxFirstName.Enabled = false;
            this.tbxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.Location = new System.Drawing.Point(643, 211);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(199, 26);
            this.tbxFirstName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.White;
            this.tbxLastName.Enabled = false;
            this.tbxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.Location = new System.Drawing.Point(643, 177);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(199, 26);
            this.tbxLastName.TabIndex = 17;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.White;
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(643, 45);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(199, 26);
            this.tbxEmail.TabIndex = 12;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.White;
            this.tbxUsername.Enabled = false;
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.Location = new System.Drawing.Point(643, 79);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(199, 26);
            this.tbxUsername.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Last Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAccounts);
            this.groupBox1.Location = new System.Drawing.Point(4, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(483, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accounts";
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AllowUserToResizeColumns = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAccounts.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvAccounts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccounts.Location = new System.Drawing.Point(6, 17);
            this.dgvAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAccounts.MultiSelect = false;
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.ShowCellErrors = false;
            this.dgvAccounts.ShowEditingIcon = false;
            this.dgvAccounts.ShowRowErrors = false;
            this.dgvAccounts.Size = new System.Drawing.Size(470, 298);
            this.dgvAccounts.TabIndex = 13;
            // 
            // frmManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 828);
            this.Controls.Add(this.tbxDesignateAccountAsEmployee);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxAccountID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManageAccounts";
            this.Text = "Manage Accounts";
            this.Load += new System.EventHandler(this.frmManageAccounts_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAccountID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.CheckBox cbxMakeAccountAdmin;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteEmployeeAccount;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button tbxDesignateAccountAsEmployee;
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCD_Restaurant_Project.Classes
{
    static class ProgOps
    {
        private const string CONNECT_STRING = "Server=cstnt.tstc.edu;Database= inew2330fa21;User Id =group2fa212330;password=2547268";

        private static SqlConnection _cntDBConnection = new SqlConnection(CONNECT_STRING);

        private static SqlCommand _sqlAccountsCommand = new SqlCommand();
        private static SqlDataAdapter _daAccounts = new SqlDataAdapter();
        private static DataTable _dtAccountsTable = new DataTable();

        private static SqlCommand _sqlEmployeesCommand = new SqlCommand();
        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        private static DataTable _dtEmployees = new DataTable();

        private static SqlCommand _sqlMenuCommand = new SqlCommand();
        private static SqlDataAdapter _daMenu = new SqlDataAdapter();
        private static DataTable _dtMenu = new DataTable();

        private static readonly StringBuilder _errorMessages = new StringBuilder();

        public static DataTable DTAccounts
        {
            get { return _dtAccountsTable; }

        }

        public static string AccountFirstName { get; set; } = string.Empty;
        public static string AccountLastName { get; set; } = string.Empty;
        public static string Username { get; set; } = string.Empty;
        public static int AccountID { get; set; } = 0;
        public static string OTP { get; set; } = string.Empty;
        public static void openDatabase()
        {
            try
            {
                _cntDBConnection.Open();
                //MessageBox.Show("Connection to database was successfully opened.", "Database Connection",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException exception)
            {
                for (int i = 0; i < exception.Errors.Count; i++)
                {
                    _errorMessages.Append("Index #" + i + "\n" +
                                          "Message: " + exception.Errors[i].Message + "\n" +
                                          "LineNumber: " + exception.Errors[i].LineNumber + "\n" +
                                          "Source: " + exception.Errors[i].Source + "\n" +
                                          "Procedure: " + exception.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(_errorMessages.ToString(), "Error Dispose Publisher", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error (PO8)", "Error Opening Database", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void CloseDatabase()
        {
            try
            {
                _cntDBConnection.Close();
                //MessageBox.Show("Connection to database was successfully closed.", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _cntDBConnection.Dispose();
                _daAccounts.Dispose();
                _daEmployees.Dispose();
                _dtAccountsTable.Dispose();
                _dtEmployees.Dispose();

            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static int verifyEmployeeStatus(int accountID)
        {

            int employeeID = -1;

            string query = "select * from group2fa212330.employees where accountID = " + accountID;

            _sqlEmployeesCommand = new SqlCommand(query, _cntDBConnection);

            _daEmployees = new SqlDataAdapter();

            _daEmployees.SelectCommand = _sqlEmployeesCommand;

            _dtEmployees = new DataTable();
            _daEmployees.Fill(_dtEmployees);

            if (_dtEmployees.Rows.Count > 0) // if results return a row
            {
                bool tempBool = false;
                if ((bool)_dtEmployees.Rows[0]["IsAdmin"])
                {
                    return 2;// admin
                }
                else
                {
                    return 1;//employee
                }
            }
            else
            {
                return 0;//customer
            }

        }

        public static int verifyAccountExistence(string username, string password)
        {

            int accountID = -1;//start with no account

            string query = "select * from group2fa212330.Accounts where username = '" + username + "' AND (password = " +
                           "'" + password + "' OR OneTimePassword = '" + password + "')";

            _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);

            _daAccounts = new SqlDataAdapter(selectCommand: _sqlAccountsCommand);

            _dtAccountsTable = new DataTable();
            _daAccounts.Fill(_dtAccountsTable);

            if (_dtAccountsTable.Rows.Count > 0) // if results return a row
            {
                accountID = (int)_dtAccountsTable.Rows[0]["AccountID"]; //return row 1 column cell value of column with the name"AccountID"

                if (password == (string)_dtAccountsTable.Rows[0]["OneTimePassword"])
                {
                    //TODO - place stored procedure code here
                    
                }

                // MessageBox.Show("Welcome "+_dtAccountsTable.Rows[0]["FirstName"]+"!");
            }

            //dispose all the connections
            //_dtAccountsTable.Dispose();
            //_daAccounts.Dispose();
            //_sqlAccountsCommand.Dispose();
            return accountID;

        }

        //Returning the one time password of the user with the email that is provided, can't use get because 
        //user hasn't been found
        public static string OneTimePassword(string email)
        {
            string result = string.Empty;
            try
            {
                //returning the accounts information that matches the email entered in the tbxForgot
                string query = "SELECT OneTimePassword FROM group2fa212330.Accounts WHERE Email =  '" + email + "'";
                _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                _dtAccountsTable = new DataTable();
                _daAccounts.Fill(_dtAccountsTable);

                //if the account exists
                if (_dtAccountsTable.Rows.Count != 0)
                {
                    //store the one time password to return in the forgot form
                    result = (string)_dtAccountsTable.Rows[0]["OneTimePassword"];
                }
                else
                {
                    MessageBox.Show("No account associated with the email entered", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //returning OTP to send VIA email
            return result;
        }

        //method for the user to sign up and add the information onto the database
        public static void SignUp(string fName, string lName, string username, string email, string password)
        {
            try
            {
                string query = "INSERT INTO group2fa212330.Accounts(FirstName, LastName, Username, Email, Password, isEmployee, OneTimePassword) VALUES(@FName, @LName, @UName, @Email, @Password, 0, 1)";
                _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);

                _sqlAccountsCommand.Parameters.AddWithValue("@FName", fName);
                _sqlAccountsCommand.Parameters.AddWithValue("@LName", lName);
                _sqlAccountsCommand.Parameters.AddWithValue("@UName", username);
                _sqlAccountsCommand.Parameters.AddWithValue("@Email", email);
                _sqlAccountsCommand.Parameters.AddWithValue("@Password", password);
                _sqlAccountsCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //displaying the specific items wherever the user is in the form
        public static void DisplayMenuItems(DataGridView dgvDisplay, int categoryId)
        {
            string query = "SELECT ItemName AS 'Item', ItemDescription AS 'Description', FORMAT(Price, 'C') AS Price, Image FROM group2fa212330.Menu INNER JOIN group2fa212330.Images ON Menu.ImageID = Images.ImageID WHERE CategoryID = " + categoryId;
            _sqlMenuCommand = new SqlCommand(query, _cntDBConnection);
            _daMenu.SelectCommand = _sqlMenuCommand;
            dgvDisplay.Rows.Clear();
            _dtMenu.Clear();
            _daMenu.Fill(_dtMenu);
            dgvDisplay.DataSource = _dtMenu;

            dgvDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDisplay.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        //Method to validate if the user enters a valid email anywhere in the program
        public static bool IsValidEmail(string email)
        {
            try
            {
                //using mail namespace to validate the email being passed in
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static void OneTimePasswordGenerator()
        {
            string newOTP = "DECLARE @password varchar(20) " +
                    "exec group2fa212330.spRandomPassword @len = 10, @output = @password out " +
                    "UPDATE group2fa212330.Accounts " +
                    "SET OneTimePassword = @password " +
                    "WHERE AccountID = "+AccountID;
            _sqlAccountsCommand = new SqlCommand(newOTP, _cntDBConnection);
            _sqlAccountsCommand.ExecuteNonQuery();
        }


        //method for binding the bank information form
        public static void BankInformation(TextBox tbxName, TextBox tbxEmail, TextBox tbxAccountID, TextBox tbxAccNumber, TextBox tbxRouNumber)
        {
            //  
            try
            {
                _cntDBConnection = new SqlConnection(CONNECT_STRING);
                string query = "SELECT CONCAT(FirstName, ' ', LastName) AS Name, Email, A.AccountID, AccountNumber, RoutingNumber " +
                    "FROM group2fa212330.Employees AS E JOIN group2fa212330.Accounts AS A ON E.AccountID = A.AccountID WHERE A.AccountID =" + AccountID;

                _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);
                _daAccounts = new SqlDataAdapter();
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                _dtAccountsTable = new DataTable();
                _daAccounts.Fill(_dtAccountsTable);

                //binding the textboxes
                tbxName.DataBindings.Add("Text", _dtAccountsTable, "Name");
                tbxEmail.DataBindings.Add("Text", _dtAccountsTable, "Email");
                tbxAccountID.DataBindings.Add("Text", _dtAccountsTable, "AccountID");
                tbxAccNumber.DataBindings.Add("Text", _dtAccountsTable, "AccountNumber");
                tbxRouNumber.DataBindings.Add("Text", _dtAccountsTable, "RoutingNumber");
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //MessageBox.Show(ex.StackTrace + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void PersonalInformation(TextBox tbxAccountID, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxName, TextBox tbxPassword)
        {
            try
            {
                _cntDBConnection = new SqlConnection(CONNECT_STRING);
                //_cntDBConnection.Open();
                string query = "SELECT AccountID, Email, Username, CONCAT(FirstName,' ', LastName) AS Name, Password FROM group2fa212330.Accounts WHERE AccountID = "+AccountID;
                _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);
                _daAccounts = new SqlDataAdapter();
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                _dtAccountsTable = new DataTable();
                _daAccounts.Fill(_dtAccountsTable);

                tbxAccountID.DataBindings.Add("Text", _dtAccountsTable, "AccountID");
                tbxEmail.DataBindings.Add("Text", _dtAccountsTable, "Email");
                tbxUsername.DataBindings.Add("Text", _dtAccountsTable, "Username");
                tbxName.DataBindings.Add("Text",_dtAccountsTable,"Name");
                tbxPassword.DataBindings.Add("Text", _dtAccountsTable, "Password");

            }
            catch(SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void fillDgvWithAccountTable(DataGridView dgvAccounts, TextBox tbxAccountID, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword,
            TextBox tbxConfirmPassword, TextBox tbxLastName, TextBox tbxFirstName)
        {

             _cntDBConnection = new SqlConnection(CONNECT_STRING);

            string sqlQuery = "SELECT * from group2fa212330.Accounts";

            _sqlAccountsCommand = new SqlCommand(sqlQuery, _cntDBConnection);

            _daAccounts = new SqlDataAdapter(selectCommand: _sqlAccountsCommand);
            _dtAccountsTable.Clear();
            _daAccounts.Fill(_dtAccountsTable);

            dgvAccounts.DataSource = _dtAccountsTable;

            tbxAccountID.DataBindings.Add("Text", dgvAccounts.DataSource, "AccountID");
            tbxEmail.DataBindings.Add("Text", dgvAccounts.DataSource, "Email");
            tbxUsername.DataBindings.Add("Text", dgvAccounts.DataSource, "Username");
            tbxPassword.DataBindings.Add("Text", dgvAccounts.DataSource, "Password");
            tbxConfirmPassword.DataBindings.Add("Text", dgvAccounts.DataSource, "Password");
            tbxLastName.DataBindings.Add("Text", dgvAccounts.DataSource, "Lastname");
            tbxFirstName.DataBindings.Add("Text", dgvAccounts.DataSource, "Firstname");


        }

        public static void ModifyMenu(DataGridView dgvMenu, TextBox tbItemName, TextBox tbItemID, TextBox tbDescription, TextBox tbPrice, TextBox tbImage)
        {
            try
            {
                _cntDBConnection = new SqlConnection(CONNECT_STRING);
                string query = "SELECT ItemID, ItemName, ItemDescription, FORMAT(Price, 'C') AS Price, Image FROM group2fa212330.Menu AS M INNER JOIN group2fa212330.Images AS I ON M.ImageID = I.ImageID";

                _sqlMenuCommand = new SqlCommand(query, _cntDBConnection);
                _daMenu = new SqlDataAdapter();
                _daMenu.SelectCommand = _sqlMenuCommand;
                _dtMenu = new DataTable();
                _daMenu.Fill(_dtMenu);

                dgvMenu.DataSource = _dtMenu;

                dgvMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                tbItemName.DataBindings.Add("Text", _dtMenu, "ItemName");
                tbItemID.DataBindings.Add("Text", _dtMenu, "ItemID");
                tbDescription.DataBindings.Add("Text", _dtMenu, "ItemDescription");
                tbPrice.DataBindings.Add("Text", _dtMenu, "Price");
                tbImage.DataBindings.Add("Text", _dtMenu, "Image");
            }
            catch(SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        _errorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //public static void menubinding(datagridview dgvmenu, textbox tbitemname, textbox tbitemid, textbox tbdescription, textbox tbprice, textbox tbimage)
        //{
        //    try
        //    {
        //        string query = "select itemid, itemname, itemdescription, price, image from group2fa212330.menu as m inner join group2fa212330.images as i on m.imageid = i.imageid";
        //        _cntdbconnection = new sqlconnection(connect_string);

        //        _sqlmenucommand = new sqlcommand(query, _cntdbconnection);
        //        _damenu = new sqldataadapter();
        //        _damenu.selectcommand = _sqlmenucommand;
        //        _dtmenu = new datatable();
        //        _damenu.fill(_dtmenu);

        //        dgvmenu.datasource = _dtmenu;

        //        tbitemname.databindings.add("text", _dtmenu, "itemname");
        //        tbitemid.databindings.add("text", _dtmenu, "itemid");
        //        tbdescription.databindings.add("text", _dtmenu, "itemdescription");
        //        tbprice.databindings.add("text", _dtmenu, "price");
        //        tbimage.databindings.add("text", _dtmenu, "image");

        //    }
        //    catch (sqlexception ex)
        //    {
        //        if (ex is sqlexception)
        //        {
        //            for (int i = 0; i < ex.errors.count; i++)
        //            {
        //                _errormessages.append("index#" + i + "\n" +
        //                    "message: " + ex.errors[i].message + "\n" +
        //                    "linenumber: " + ex.errors[i].linenumber + "\n" +
        //                    "source: " + ex.errors[i].source + "\n" +
        //                    "procedure: " + ex.errors[i].procedure + "\n");
        //            }
        //            messagebox.show(_errormessages.tostring(), "error close database", messageboxbuttons.ok, messageboxicon.error);
        //        }
        //        else
        //        {//handles generic ones here
        //            messagebox.show(ex.message + "error (po2)", "error close database", messageboxbuttons.ok, messageboxicon.error);
        //        }
        //    }
        //}
    }
}

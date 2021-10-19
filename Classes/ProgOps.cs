using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace BCD_Restaurant_Project.Classes
{
    static class ProgOps
    {
        private const string CONNECT_STRING = "Server=cstnt.tstc.edu;Database= inew2330fa21;User Id =group2fa212330;password=2547268";

        private static SqlConnection _cntDBConnection = new SqlConnection(CONNECT_STRING);

        private static SqlDataAdapter _daAccounts = new SqlDataAdapter();
        private static SqlDataAdapter _daCategory = new SqlDataAdapter();
        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        private static SqlDataAdapter _daMenu = new SqlDataAdapter();
        private static DataTable _dtAccounts = new DataTable();
        private static DataTable _dtCategory = new DataTable();
        private static DataTable _dtEmployees = new DataTable();
        private static DataTable _dtMenu = new DataTable();
        private static SqlCommand _sqlAccountsCommand = new SqlCommand();
        private static SqlCommand _sqlCategoryCommand = new SqlCommand();
        private static SqlCommand _sqlEmployeesCommand = new SqlCommand();
        private static SqlCommand _sqlMenuCommand = new SqlCommand();
        public static string AccountFirstName { get; set; } = string.Empty;

        public static int AccountID { get; set; } = 0;

        public static string AccountLastName { get; set; } = string.Empty;

        public static DataTable DTAccounts => _dtAccounts;
        public static DataTable DTCategories => _dtCategory;
        public static DataTable DTEmployees => _dtEmployees;
        public static DataTable DTMenu => _dtMenu;

        public static string OTP { get; set; } = string.Empty;
        private static StringBuilder ErrorMessages { get; } = new StringBuilder();
        //method for binding the bank information form
        public static void BankInformation(TextBox tbxName, TextBox tbxEmail, TextBox tbxAccountID, TextBox tbxAccNumber, TextBox tbxRouNumber)
        {
            try
            {
                _cntDBConnection = new SqlConnection(CONNECT_STRING);
                string query = "SELECT CONCAT(FirstName, ' ', LastName) AS Name, Email, A.AccountID, AccountNumber, RoutingNumber " +
                    "FROM group2fa212330.Employees AS E JOIN group2fa212330.Accounts AS A ON E.AccountID = A.AccountID WHERE A.AccountID =" + AccountID;

                _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);
                _daAccounts = new SqlDataAdapter();
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                _dtAccounts = new DataTable();
                _daAccounts.Fill(_dtAccounts);

                //binding the textboxes
                tbxName.DataBindings.Add("Text", _dtAccounts, "Name");
                tbxEmail.DataBindings.Add("Text", _dtAccounts, "Email");
                tbxAccountID.DataBindings.Add("Text", _dtAccounts, "AccountID");
                tbxAccNumber.DataBindings.Add("Text", _dtAccounts, "AccountNumber");
                tbxRouNumber.DataBindings.Add("Text", _dtAccounts, "RoutingNumber");
            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        ErrorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //MessageBox.Show(ex.StackTrace + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void changeCategory(CurrencyManager currency, ComboBox cbCategory)
        {
            int index = cbCategory.FindString(_dtMenu.Rows[currency.Position]["CategoryName"].ToString());
            cbCategory.SelectedIndex = index;
        }

        public static void CloseDatabase()
        {
            try
            {
                _cntDBConnection.Close();
                _cntDBConnection.Dispose();

            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index#" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //displaying the specific items wherever the user is in the form
        public static void DisplayMenuItems(DataGridView dgvDisplay, int categoryId)
        {
            string query = "SELECT ItemID, ItemName AS 'Item', ItemDescription AS 'Description', FORMAT(Price, 'C') AS Price, Image FROM group2fa212330.Menu INNER JOIN group2fa212330.Images ON Menu.ImageID = Images.ImageID WHERE CategoryID = " + categoryId;
            _sqlMenuCommand = new SqlCommand(query, _cntDBConnection);
            _daMenu.SelectCommand = _sqlMenuCommand;
            dgvDisplay.Rows.Clear();
            _dtMenu.Clear();
            _daMenu.Fill(_dtMenu);
            dgvDisplay.DataSource = _dtMenu;

            dgvDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDisplay.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        public static void bindAccounts(TextBox tbxAccountID, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword,
            TextBox tbxConfirmPassword, TextBox tbxLastName, TextBox tbxFirstName)
        {

            _sqlAccountsCommand = null;
            _daAccounts = new SqlDataAdapter();
            _dtAccounts = new DataTable();

            //_cntDBConnection = new SqlConnection(CONNECT_STRING);

            string sqlQuery = "SELECT * from group2fa212330.Accounts";

            try
            {
                _sqlAccountsCommand = new SqlCommand(sqlQuery, _cntDBConnection);

                _daAccounts.SelectCommand = _sqlAccountsCommand;

                _daAccounts.Fill(_dtAccounts);

                tbxAccountID.DataBindings.Add("Text", _dtAccounts, "AccountID");
                tbxEmail.DataBindings.Add("Text", _dtAccounts, "Email");
                tbxUsername.DataBindings.Add("Text", _dtAccounts, "Username");
                tbxPassword.DataBindings.Add("Text", _dtAccounts, "Password");
                tbxConfirmPassword.DataBindings.Add("Text", _dtAccounts, "Password");
                tbxLastName.DataBindings.Add("Text", _dtAccounts, "Lastname");
                tbxFirstName.DataBindings.Add("Text", _dtAccounts, "Firstname");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static void disposeAccountObjects()
        {

            try
            {
                //dispose of the sql command objects for publisher
                _sqlAccountsCommand.Dispose();
                _daAccounts.Dispose();
                _dtAccounts.Dispose();

            }
            catch (SqlException ex)
            {
                //handles more specific SqlException here.
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Disposing Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //handles generic ones here
                MessageBox.Show(ex.Message + "Error (PO8)", "Error Disposing Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public static void disposeCategoriesObjects()
        {
            try
            {
                _sqlCategoryCommand.Dispose();
                _daCategory.Dispose();
                _dtCategory.Dispose();

            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Disposing Categories", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //handles generic ones here
                MessageBox.Show(ex.Message + "Error (PO8)", "Error Disposing Categories", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void disposeEmployeesObjects()
        {
            try
            {
                _sqlEmployeesCommand.Dispose();
                _daEmployees.Dispose();
                _dtEmployees.Dispose();

            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Disposing Categories", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //handles generic ones here
                MessageBox.Show(ex.Message + "Error (PO8)", "Error Disposing Categories", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void disposeMenuObjects()
        {
            try
            {
                _sqlMenuCommand.Dispose();
                _daMenu.Dispose();
                _dtMenu.Dispose();

            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Disposing Categories", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //handles generic ones here
                MessageBox.Show(ex.Message + "Error (PO8)", "Error Disposing Categories", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void updateAccountsOnClose()
        {
            try
            {
                SqlCommandBuilder daAccountsCommand = new SqlCommandBuilder(_daAccounts);
                _daAccounts.Update(_dtAccounts);
            }
            catch (SqlException ex)
            {
                //handles more specific SqlException here.
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Update Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error (PO7)", "Error Update Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void updateCategoriesOnClose()
        {
            try
            {
                SqlCommandBuilder daCategoriesCommand = new SqlCommandBuilder(_daCategory);
                _daCategory.Update(_dtCategory);
            }
            catch (SqlException ex)
            {
                //handles more specific SqlException here.
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Update Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error (PO7)", "Error Update Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void updateEmployeesOnClose()
        {
            try
            {
                SqlCommandBuilder daEmployeesCommand = new SqlCommandBuilder(_daEmployees);
                _daEmployees.Update(_dtEmployees);
            }
            catch (SqlException ex)
            {
                //handles more specific SqlException here.
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Update Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error (PO7)", "Error Update Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void updateMenuOnClose()
        {
            try
            {
                SqlCommandBuilder daMenuCommand = new SqlCommandBuilder(_daMenu);
                _daMenu.Update(_dtMenu);
            }
            catch (SqlException ex)
            {
                //handles more specific SqlException here.
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" +
                                         "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                         "Source: " + ex.Errors[i].Source + "\n" +
                                         "Procedure: " + ex.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Update Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error (PO7)", "Error Update Accounts", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Method to validate if the user enters a valid email anywhere in the program
        public static bool isValidEmail(string email)
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

        public static void modifyMenu(TextBox tbItemName, TextBox tbItemID, TextBox tbDescription, TextBox tbPrice, TextBox tbImage, ComboBox cbCategory,
            Form form, out CurrencyManager c)
        {

            c = null;

            try
            {
                _cntDBConnection = new SqlConnection(CONNECT_STRING);
                string query = "SELECT ItemID, ItemName, ItemDescription, FORMAT(Price, 'C') AS Price, Image, CategoryName FROM group2fa212330.Menu AS M INNER JOIN group2fa212330.Images AS I ON M.ImageID = I.ImageID " +
                               "INNER JOIN group2fa212330.Categories c on M.CategoryID = C.CategoryID";

                _sqlMenuCommand = new SqlCommand(query, _cntDBConnection);
                _daMenu = new SqlDataAdapter();
                _daMenu.SelectCommand = _sqlMenuCommand;
                _dtMenu = new DataTable();
                _daMenu.Fill(_dtMenu);

                tbItemName.DataBindings.Add("Text", _dtMenu, "ItemName");
                tbItemID.DataBindings.Add("Text", _dtMenu, "ItemID");
                tbDescription.DataBindings.Add("Text", _dtMenu, "ItemDescription");
                tbPrice.DataBindings.Add("Text", _dtMenu, "Price");
                tbImage.DataBindings.Add("Text", _dtMenu, "Image");


                string categoryName = "SELECT * FROM group2fa212330.Categories";
                _sqlCategoryCommand = new SqlCommand(categoryName, _cntDBConnection);
                _daCategory.SelectCommand = _sqlCategoryCommand;
                _daCategory.Fill(_dtCategory);
                cbCategory.DataSource = _dtCategory;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
                cbCategory.DataBindings.Add("SelectedItem", _dtCategory, "CategoryID");

                c = (CurrencyManager)form.BindingContext[ProgOps.DTMenu];

                //int index = cbCategory.FindString(_dtMenu.Rows[c.Position]["CategoryName"].ToString());
                //cbCategory.SelectedIndex = index;

            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        ErrorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

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
                _dtAccounts = new DataTable();
                _daAccounts.Fill(_dtAccounts);

                //if the account exists
                if (_dtAccounts.Rows.Count != 0)
                {
                    //store the one time password to return in the forgot form
                    result = (string)_dtAccounts.Rows[0]["OneTimePassword"];
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
                        ErrorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //returning OTP to send VIA email
            return result;
        }

        public static void OneTimePasswordGenerator()
        {
            string newOTP = "DECLARE @password varchar(20) " +
                    "exec group2fa212330.spRandomPassword @len = 10, @output = @password out " +
                    "UPDATE group2fa212330.Accounts " +
                    "SET OneTimePassword = @password " +
                    "WHERE AccountID = " + AccountID;
            _sqlAccountsCommand = new SqlCommand(newOTP, _cntDBConnection);
            _sqlAccountsCommand.ExecuteNonQuery();
        }

        public static void openDatabase()
        {
            try
            {
                _cntDBConnection.Open();
            }
            catch (SqlException exception)
            {
                for (int i = 0; i < exception.Errors.Count; i++)
                {
                    ErrorMessages.Append("Index #" + i + "\n" + "Message: " + exception.Errors[i].Message + "\n" +
                                          "LineNumber: " + exception.Errors[i].LineNumber + "\n" + "Source: " + exception.Errors[i].Source + "\n" +
                                          "Procedure: " + exception.Errors[i].Procedure + "\n");
                }

                MessageBox.Show(ErrorMessages.ToString(), "Error Disposing Connection", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Error (PO8)", "Error Opening Database", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void PersonalInformation(TextBox tbxAccountID, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxName, TextBox tbxPassword)
        {
            try
            {
                _cntDBConnection = new SqlConnection(CONNECT_STRING);
                //_cntDBConnection.Open();
                string query = "SELECT AccountID, Email, Username, CONCAT(FirstName,' ', LastName) AS Name, Password FROM group2fa212330.Accounts WHERE AccountID = " + AccountID;
                _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);
                _daAccounts = new SqlDataAdapter();
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                _dtAccounts = new DataTable();
                _daAccounts.Fill(_dtAccounts);

                tbxAccountID.DataBindings.Add("Text", _dtAccounts, "AccountID");
                tbxEmail.DataBindings.Add("Text", _dtAccounts, "Email");
                tbxUsername.DataBindings.Add("Text", _dtAccounts, "Username");
                tbxName.DataBindings.Add("Text", _dtAccounts, "Name");
                tbxPassword.DataBindings.Add("Text", _dtAccounts, "Password");

            }
            catch (SqlException ex)
            {
                if (ex is SqlException)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        ErrorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                        ErrorMessages.Append("Index#" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {//handles generic ones here
                    MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static int verifyAccountExistence(string username, string password)
        {

            int accountID = -1;//start with no account

            string query = "select * from group2fa212330.Accounts where username = '" + username + "' AND (password = " +
                           "'" + password + "' OR OneTimePassword = '" + password + "')";

            _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);

            _daAccounts = new SqlDataAdapter(selectCommand: _sqlAccountsCommand);

            _dtAccounts = new DataTable();
            _daAccounts.Fill(_dtAccounts);

            if (_dtAccounts.Rows.Count > 0) // if results return a row
            {
                accountID = (int)_dtAccounts.Rows[0]["AccountID"]; //return row 1 column cell value of column with the name"AccountID"

                if (password == (string)_dtAccounts.Rows[0]["OneTimePassword"])
                {
                    //TODO - place stored procedure code here

                }

                // MessageBox.Show("Welcome "+_dtAccounts.Rows[0]["FirstName"]+"!");
            }

            //dispose all the connections
            _dtAccounts.Dispose();
            _daAccounts.Dispose();
            _sqlAccountsCommand.Dispose();
            return accountID;

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
    }
}

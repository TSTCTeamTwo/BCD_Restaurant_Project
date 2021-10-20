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

        //Objects for Accounts Table
        private static SqlCommand _sqlAccountsCommand = new SqlCommand();
        private static SqlDataAdapter _daAccounts = new SqlDataAdapter();
        public static DataTable DTAccounts { get; private set; } = new DataTable();

        private static SqlCommand _sqlEmployeesCommand = new SqlCommand();
        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        public static DataTable DTEmployees { get; private set; } = new DataTable();

        private static SqlCommand _sqlMenuCommand = new SqlCommand();
        private static SqlDataAdapter _daMenu = new SqlDataAdapter();
        public static DataTable DTMenu { get; private set; } = new DataTable();

        private static SqlCommand _sqlCategoryCommand = new SqlCommand();
        private static SqlDataAdapter _daCategory = new SqlDataAdapter();
        private static DataTable _dtCategory = new DataTable();
        public static DataTable DTCategories => _dtCategory;

        private static SqlCommand _sqlOrdersCommand = new SqlCommand();
        private static SqlDataAdapter _daOrders = new SqlDataAdapter();
        public static DataTable DTOrders { get; } = new DataTable();

        private static SqlCommand _sqlOrderItemsCommand = new SqlCommand();
        private static SqlDataAdapter _daOrderItems = new SqlDataAdapter();
        public static DataTable DTOrderItems { get; } = new DataTable();

        private static StringBuilder ErrorMessages { get; } = new StringBuilder();

        public static string AccountFirstName { get; set; } = string.Empty;
        public static string AccountLastName { get; set; } = string.Empty;
        public static int AccountID { get; set; } = 0;
        public static string OTP { get; set; } = string.Empty;
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

                MessageBox.Show(ErrorMessages.ToString(), "Error Dispose Publisher", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message, "Error Opening Database", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void closeDatabase()
        {
            try
            {
                _cntDBConnection.Close();
                //MessageBox.Show("Connection to database was successfully closed.", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _cntDBConnection.Dispose();
                _daAccounts.Dispose();
                _daEmployees.Dispose();
                DTAccounts.Dispose();
                DTEmployees.Dispose();

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
                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message, "Error Opening Database", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static int verifyEmployeeStatus(int accountID)
        {

            int employeeID = -1;

            string query = "select * from group2fa212330.employees where accountID = " + accountID;

            _sqlEmployeesCommand = new SqlCommand(query, _cntDBConnection);

            _daEmployees = new SqlDataAdapter();

            _daEmployees.SelectCommand = _sqlEmployeesCommand;

            DTEmployees = new DataTable();
            _daEmployees.Fill(DTEmployees);

            if (DTEmployees.Rows.Count > 0) // if results return a row
            {
                bool tempBool = false;
                if ((bool)DTEmployees.Rows[0]["IsAdmin"])
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

            DTAccounts = new DataTable();
            _daAccounts.Fill(DTAccounts);

            if (DTAccounts.Rows.Count > 0) // if results return a row
            {
                accountID = (int)DTAccounts.Rows[0]["AccountID"]; //return row 1 column cell value of column with the name"AccountID"

                if (password == (string)DTAccounts.Rows[0]["OneTimePassword"])
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
        public static string verifyOneTimePassword(string email)
        {
            string result = string.Empty;
            try
            {
                //returning the accounts information that matches the email entered in the tbxForgot
                string query = "SELECT OneTimePassword FROM group2fa212330.Accounts WHERE Email =  '" + email + "'";
                _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                DTAccounts = new DataTable();
                _daAccounts.Fill(DTAccounts);

                //if the account exists
                if (DTAccounts.Rows.Count != 0)
                {
                    //store the one time password to return in the forgot form
                    result = (string)DTAccounts.Rows[0]["OneTimePassword"];
                }
                else
                {
                    MessageBox.Show("No account associated with the email entered", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            //returning OTP to send VIA email
            return result;
        }

        //method for the user to sign up and add the information onto the database
        public static void insertNewAccount(string fName, string lName, string username, string email, string password)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //displaying the specific items wherever the user is in the form
        public static void displayMenuItems(DataGridView dgvDisplay, int categoryId)
        {
            _cntDBConnection = new SqlConnection(CONNECT_STRING);
            string query = "SELECT ItemID, ItemName AS 'Item', ItemDescription AS 'Description', FORMAT(Price, 'C') AS Price, Image FROM group2fa212330.Menu INNER JOIN group2fa212330.Images ON Menu.ImageID = Images.ImageID WHERE CategoryID = " + categoryId;
            _sqlMenuCommand = new SqlCommand(query, _cntDBConnection);
            _daMenu.SelectCommand = _sqlMenuCommand;
            dgvDisplay.Rows.Clear();
            DTMenu.Clear();
            _daMenu.Fill(DTMenu);
            dgvDisplay.DataSource = DTMenu;

            dgvDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDisplay.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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

        public static void generateOneTimePassword()
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
              
            try
            {
                _cntDBConnection = new SqlConnection(CONNECT_STRING);
                string query = "SELECT CONCAT(FirstName, ' ', LastName) AS Name, Email, A.AccountID, AccountNumber, RoutingNumber " +
                    "FROM group2fa212330.Employees AS E JOIN group2fa212330.Accounts AS A ON E.AccountID = A.AccountID WHERE A.AccountID =" + AccountID;

                _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);
                _daAccounts = new SqlDataAdapter();
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                DTAccounts = new DataTable();
                _daAccounts.Fill(DTAccounts);

                //binding the textboxes
                tbxName.DataBindings.Add("Text", DTAccounts, "Name");
                tbxEmail.DataBindings.Add("Text", DTAccounts, "Email");
                tbxAccountID.DataBindings.Add("Text", DTAccounts, "AccountID");
                tbxAccNumber.DataBindings.Add("Text", DTAccounts, "AccountNumber");
                tbxRouNumber.DataBindings.Add("Text", DTAccounts, "RoutingNumber");
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
                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.StackTrace + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                DTAccounts = new DataTable();
                _daAccounts.Fill(DTAccounts);

                tbxAccountID.DataBindings.Add("Text", DTAccounts, "AccountID");
                tbxEmail.DataBindings.Add("Text", DTAccounts, "Email");
                tbxUsername.DataBindings.Add("Text", DTAccounts, "Username");
                tbxName.DataBindings.Add("Text",DTAccounts,"Name");
                tbxPassword.DataBindings.Add("Text", DTAccounts, "Password");

            }
            catch(SqlException ex)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void bindAccounts(TextBox tbxAccountID, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword,
            TextBox tbxConfirmPassword, TextBox tbxLastName, TextBox tbxFirstName)
        {

             _cntDBConnection = new SqlConnection(CONNECT_STRING);

            string sqlQuery = "SELECT * from group2fa212330.Accounts";

            _sqlAccountsCommand = new SqlCommand(sqlQuery, _cntDBConnection);

            _daAccounts = new SqlDataAdapter(selectCommand: _sqlAccountsCommand);
            DTAccounts.Clear();
            _daAccounts.Fill(DTAccounts);

            tbxAccountID.DataBindings.Add("Text", DTAccounts, "AccountID");
            tbxEmail.DataBindings.Add("Text", DTAccounts, "Email");
            tbxUsername.DataBindings.Add("Text", DTAccounts, "Username");
            tbxPassword.DataBindings.Add("Text", DTAccounts, "Password");
            tbxConfirmPassword.DataBindings.Add("Text", DTAccounts, "Password");
            tbxLastName.DataBindings.Add("Text", DTAccounts, "Lastname");
            tbxFirstName.DataBindings.Add("Text", DTAccounts, "Firstname");


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
                DTMenu = new DataTable();
                _daMenu.Fill(DTMenu);
                
                tbItemName.DataBindings.Add("Text", DTMenu, "ItemName");
                tbItemID.DataBindings.Add("Text", DTMenu, "ItemID");
                tbDescription.DataBindings.Add("Text", DTMenu, "ItemDescription");
                tbPrice.DataBindings.Add("Text", DTMenu, "Price");
                tbImage.DataBindings.Add("Text", DTMenu, "Image");


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
            catch(SqlException ex)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        public static void changeCategory(CurrencyManager currency, ComboBox cbCategory)
        {
            int index = cbCategory.FindString(DTMenu.Rows[currency.Position]["CategoryName"].ToString());
            cbCategory.SelectedIndex = index;
        }

        public static void finalizeOrder()
        {
            try
            {
                string query = "INSERT INTO Orders(AccountID, PaymentID, OrderDate, OrderQty, TotalDue, Tip) VALUES(" + AccountID + ", 2," + DateTime.Now.ToString() + ", 0, 0, 0";
                _sqlOrdersCommand = new SqlCommand(query, _cntDBConnection);
                _sqlOrdersCommand.ExecuteNonQuery();
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
                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

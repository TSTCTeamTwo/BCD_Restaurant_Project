#region Imports

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

#endregion

namespace BCD_Restaurant_Project.Classes {
    internal static class ProgOps {
        private const string CONNECT_STRING
            = "Server=cstnt.tstc.edu;Database= inew2330fa21;User Id =group2fa212330;password=2547268";

        //data adapters for the tables in our database
        private static SqlDataAdapter _daAccounts = new SqlDataAdapter();
        private static readonly SqlDataAdapter _daCategory = new SqlDataAdapter();
        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        private static SqlDataAdapter _daMenu = new SqlDataAdapter();
        private static readonly SqlDataAdapter _daOrderItems = new SqlDataAdapter();
        private static readonly SqlDataAdapter _daOrders = new SqlDataAdapter();

        private static SqlConnection _dbConnection = new SqlConnection(CONNECT_STRING);

        //command objects for the tables in our database
        private static SqlCommand _sqlAccountsCommand = new SqlCommand();
        private static SqlCommand _sqlCategoryCommand = new SqlCommand();
        private static SqlCommand _sqlEmployeesCommand = new SqlCommand();
        private static SqlCommand _sqlMenuCommand = new SqlCommand();
        private static SqlCommand _sqlOrderItemsCommand = new SqlCommand();

        private static SqlCommand _sqlOrdersCommand = new SqlCommand();

        //Properties for the application
        public static string AccountFN {
            get;
            set;
        } = string.Empty;

        public static int AccountID {
            get;
            set;
        }

        public static string AccountLN {
            get;
            set;
        } = string.Empty;

        //Datatables to hold result sets for the application
        public static DataTable DTAccounts {
            get;
            private set;
        } = new DataTable();

        public static DataTable DTCategories {
            get;
        } = new DataTable();

        public static DataTable DTEmployees {
            get;
            private set;
        } = new DataTable();

        public static DataTable DTMenu {
            get;
            private set;
        } = new DataTable();

        public static DataTable DTOrderItems {
            get;
        } = new DataTable();

        public static DataTable DTOrders {
            get;
            private set;
        } = new DataTable();

        public static DataTable DTPayment {
            get;
        } = new DataTable();

        public static string Email {
            get;
            set;
        } = string.Empty;

        private static StringBuilder ErrorMessages {
            get;
        } = new StringBuilder();

        public static void addAccount(string[] text) {
            try {
                string query
                    = "insert into group2fa212330.Accounts (Email, OneTimePassword, Username, Password, LastName, FirstName, IsEmployee) VALUES " +
                      $"('{text[1]}','fads34','{text[2]}','{text[3]}','{text[4]}','{text[5]}',0)";

                SqlCommand _sqlDdlCommand = new SqlCommand(query, _dbConnection);
                _sqlDdlCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addNewMenuItem(string name, string description, double price, ComboBox cbCategory) {
            try {
                string query
                    = "INSERT INTO group2fa212330.Menu(ItemName, ItemDescription, Price, CategoryID) VALUES('" + name +
                      "', '" + description + "', " + price + ", " + cbCategory.SelectedIndex + 1;
                _sqlMenuCommand = new SqlCommand(query, _dbConnection);
                _sqlMenuCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addPayment(
            string cardNumber, string cardType, string cardName, string security, MaskedTextBox expiration
        ) {
            try {
                MessageBox.Show(cardName + cardType + security + cardNumber + expiration.Text);
                //Query to insert payment option for the current account
                string query
                    = "INSERT INTO group2fa212330.Payment(AccountID, Type, CardNumber, CardName, SecurityCode, ExpirationDate) " +
                      "VALUES(" + AccountID + ", '" + cardType + "', '" + cardNumber + "', '" + cardName + "', '" +
                      security + "', '" + expiration.Text + "' )";
                SqlCommand _sqlPaymentCommand = new SqlCommand(query, _dbConnection);
                _sqlPaymentCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //method for binding the bank information form
        public static void bankInformation(
            TextBox tbxName, TextBox tbxEmail, TextBox tbxAccountID, TextBox tbxAccNumber, TextBox tbxRouNumber
        ) {
            try {
                string query
                    = "SELECT CONCAT(FirstName, ' ', LastName) AS Name, Email, A.AccountID, AccountNumber, RoutingNumber " +
                      "FROM group2fa212330.Employees AS E JOIN group2fa212330.Accounts AS A ON E.AccountID = A.AccountID WHERE A.AccountID =" +
                      AccountID;

                _sqlAccountsCommand = new SqlCommand(query, _dbConnection);
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
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //MessageBox.Show(ex.StackTrace + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void bindAccounts(
            TextBox tbxAccountID, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxPassword, TextBox tbxLastName,
            TextBox tbxFirstName, Form form, out CurrencyManager accountsManager
        ) {
            string sqlQuery = "SELECT * from group2fa212330.Accounts";

            _sqlAccountsCommand = new SqlCommand(sqlQuery, _dbConnection);

            _daAccounts = new SqlDataAdapter(_sqlAccountsCommand);
            DTAccounts.Clear();
            _daAccounts.Fill(DTAccounts);

            accountsManager = (CurrencyManager)form.BindingContext[DTAccounts];

            tbxAccountID.DataBindings.Add("Text", DTAccounts, "AccountID");
            tbxEmail.DataBindings.Add("Text", DTAccounts, "Email");
            tbxUsername.DataBindings.Add("Text", DTAccounts, "Username");
            tbxPassword.DataBindings.Add("Text", DTAccounts, "Password");
            tbxLastName.DataBindings.Add("Text", DTAccounts, "Lastname");
            tbxFirstName.DataBindings.Add("Text", DTAccounts, "Firstname");
        }

        public static void changeCategory(CurrencyManager currency, ComboBox cbCategory) {
            cbCategory.SelectedIndex = cbCategory.FindString(DTMenu.Rows[currency.Position]["CategoryName"].ToString());
        }

        public static void changeMenuItemImage(string text) {
            OpenFileDialog ofdImage = new OpenFileDialog();

            ofdImage.InitialDirectory = Directory.GetCurrentDirectory();

            ofdImage.ValidateNames = true;
            ofdImage.AddExtension = false;
            ofdImage.Filter = "PNG File|*.png|JPEG File|*.jpg";
            ofdImage.Title = "Image to Upload";

            if (ofdImage.ShowDialog() == DialogResult.OK) {
                byte[] image = File.ReadAllBytes(ofdImage.FileName);
            }

            try {
                string insertQuery = "UPDATE group2fa212330.Images WHERE ";
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public static void closeDatabase() {
            try {
                _dbConnection.Close();

                _dbConnection.Dispose();
                _daAccounts.Dispose();
                _daEmployees.Dispose();
                _daCategory.Dispose();
                _daMenu.Dispose();
                _daOrderItems.Dispose();
                _daOrders.Dispose();
                DTCategories.Dispose();
                DTMenu.Dispose();
                DTOrders.Dispose();
                DTOrderItems.Dispose();
                DTAccounts.Dispose();
                DTEmployees.Dispose();
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "Error Opening Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public static void commandAccount() {
            try {
                SqlCommandBuilder update = new SqlCommandBuilder(_daAccounts);
                _daAccounts.Update(DTAccounts);
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void deactivateAccount(int accountID) {
            string query = "UPDATE group2fa212330.Accounts SET isActive = 0 WHERE AccountID =" + accountID;
            _sqlAccountsCommand = new SqlCommand(query, _dbConnection);
            _sqlAccountsCommand.ExecuteNonQuery();
        }

        public static void deleteAccount(string[] text) {
            try {
                string query = $"DELETE FROM group2fa212330.Accounts WHERE AccountID = {text[0]}";

                SqlCommand _sqlDdlCommand = new SqlCommand(query, _dbConnection);
                _sqlDdlCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //displaying the specific items wherever the user is in the form
        public static void displayMenuItems(DataGridView dgvDisplay, int categoryId) {
            //   _cntDBConnection = new SqlConnection(CONNECT_STRING);
            //string query =
            //    "SELECT ItemID, ItemName AS 'Item', ItemDescription AS 'Description', FORMAT(Price, 'C') AS Price, Image FROM group2fa212330.Menu INNER JOIN group2fa212330.Images ON Menu.ImageID = Images.ImageID WHERE CategoryID = " +
            //    categoryId;
            string query
                = "SELECT ItemID, ItemName AS 'Item', ItemDescription AS 'Description', FORMAT(Price, 'C') AS Price, Image FROM group2fa212330.Menu INNER JOIN group2fa212330.Images ON Menu.ImageID = Images.ImageID WHERE CategoryID = " +
                  categoryId;
            _sqlMenuCommand = new SqlCommand(query, _dbConnection);
            _daMenu.SelectCommand = _sqlMenuCommand;
            dgvDisplay.Rows.Clear();
            DTMenu.Clear();
            _daMenu.Fill(DTMenu);
            dgvDisplay.DataSource = DTMenu;

            dgvDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDisplay.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public static void fillInPersonalInformation(
            TextBox tbxAccountID, TextBox tbxEmail, TextBox tbxUsername, TextBox tbxName, TextBox tbxPassword
        ) {
            try {
                string query
                    = "SELECT AccountID, Email, Username, CONCAT(FirstName,' ', LastName) AS Name, Password FROM group2fa212330.Accounts WHERE AccountID = " +
                      AccountID;
                _sqlAccountsCommand = new SqlCommand(query, _dbConnection);
                _daAccounts = new SqlDataAdapter();
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                DTAccounts = new DataTable();
                _daAccounts.Fill(DTAccounts);

                tbxAccountID.DataBindings.Add("Text", DTAccounts, "AccountID");
                tbxEmail.DataBindings.Add("Text", DTAccounts, "Email");
                tbxUsername.DataBindings.Add("Text", DTAccounts, "Username");
                tbxName.DataBindings.Add("Text", DTAccounts, "Name");
                tbxPassword.DataBindings.Add("Text", DTAccounts, "Password");
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void finalizeOrder(decimal tip) {
            try {
                //1. Insert an empty order record with the accountid, paymentid, and orderdate
                string query = "INSERT INTO group2fa212330.Orders(AccountID, PaymentID, OrderDate, Tip) " + "VALUES(" +
                               AccountID + "," + DTPayment.Rows[0]["PaymentID"] + ",'" + DateTime.Now + "'," + tip +
                               ")";
                _sqlOrdersCommand = new SqlCommand(query, _dbConnection);
                _sqlOrdersCommand.ExecuteNonQuery();

                //for each item id in cart, add that item with the order id to the order items table with the quantity in cart
                getNewOrderID();

                foreach (KeyValuePair<int, MenuItem> items in Cart.myCart) {
                    query = "INSERT INTO group2fa212330.OrderItems VALUES(" + Cart.OrderID + ", " + items.Key + ", " +
                            items.Value.Quantity + ")";
                    _sqlOrdersCommand = new SqlCommand(query, _dbConnection);
                    _sqlOrdersCommand.ExecuteNonQuery();
                }

                Cart.myCart.Clear();
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "Finalize Order Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public static void generatePassword(int argument, string newUserPassword = null) {
            string password = string.Empty;
            try {
                switch (argument) {
                    case 1: //replaces old password with new password
                        password
                            = $"UPDATE group2fa212330.Accounts SET Password = '{newUserPassword}', OneTimePassword = NULL WHERE AccountID = {AccountID}";
                        break;
                    case 2: //generates new one time password
                        password = "DECLARE @password varchar(20) " +
                                   "exec group2fa212330.spRandomPassword @len = 10, @output = @password out " +
                                   "UPDATE group2fa212330.Accounts " + "SET OneTimePassword = @password " +
                                   $"WHERE Email = '{Email}'";
                        break;
                }

                _sqlAccountsCommand = new SqlCommand(password, _dbConnection);
                _sqlAccountsCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void getNewOrderID() {
            string query = "SELECT MAX(OrderID) AS OrderID FROM group2fa212330.Orders";
            _sqlOrdersCommand = new SqlCommand(query, _dbConnection);
            _daOrders.SelectCommand = _sqlOrdersCommand;
            DTOrders = new DataTable();
            _daOrders.Fill(DTOrders);

            if (DTOrders.Rows.Count != 0)
                Cart.OrderID = (int)DTOrders.Rows[0]["OrderID"];

            _sqlOrdersCommand.Dispose();
            _daOrders.Dispose();
        }

        //method for the user to sign up and add the information onto the database
        public static void insertNewAccount(
            string fName, string lName, string username, string email, string password
        ) {
            try {
                bool emailOK = returnStatus(email);
                bool usernameOK = returnStatus(username, 1);

                if (emailOK && usernameOK) {
                    string query
                        = "INSERT INTO group2fa212330.Accounts(FirstName, LastName, Username, Email, Password, isEmployee, OneTimePassword) " +
                          "VALUES(@FName, @LName, @UName, @Email, @Password, 0, 1)";
                    _sqlAccountsCommand = new SqlCommand(query, _dbConnection);

                    _sqlAccountsCommand.Parameters.AddWithValue("@FName", fName);
                    _sqlAccountsCommand.Parameters.AddWithValue("@LName", lName);
                    _sqlAccountsCommand.Parameters.AddWithValue("@UName", username);
                    _sqlAccountsCommand.Parameters.AddWithValue("@Email", email);
                    _sqlAccountsCommand.Parameters.AddWithValue("@Password", password);
                    _sqlAccountsCommand.ExecuteNonQuery();
                    MessageBox.Show("Sign up was successful.", "SignUp", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool returnStatus(string variable, int type = 0) {
            string addition = "";
            string error = "";
            switch (type) {
                case 0:
                    addition = $"email = '{variable}'";
                    error = "Email is already associated with another account";
                    break;
                case 1:
                    addition = $"username = '{variable}'";
                    error = "Username is already taken";
                    break;
            }

            string query = $"SELECT * FROM group2fa212330.Accounts where {addition}";
            _sqlAccountsCommand = new SqlCommand(query, _dbConnection);
            _daAccounts.SelectCommand = _sqlAccountsCommand;
            _daAccounts.Fill(DTAccounts);
            if (DTAccounts.Rows.Count > 0) {
                MessageBox.Show(error, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _daAccounts.Dispose();
                _sqlAccountsCommand.Dispose();
                DTAccounts.Clear();
                return false;
            }

            _daAccounts.Dispose();
            _sqlAccountsCommand.Dispose();
            DTAccounts.Clear();

            return true;
        }

        //Method to validate if the user enters a valid email anywhere in the program
        public static bool isValidEmail(string email) {
            openDatabase();
            try {
                //using mail namespace to validate the email being passed in
                MailAddress address = new MailAddress(email);
                return address.Address == email;
            } catch {
                return false;
            }
        }

        public static void modifyMenu(
            TextBox tbItemName, TextBox tbItemID, TextBox tbDescription, TextBox tbPrice, ComboBox cbCategory,
            Form form, out CurrencyManager c, DataGridView dgvDisplay
        ) {
            c = null;

            try {
                string query = "SELECT " +
                               "ItemID, ItemName, ItemDescription, FORMAT(Price, 'C') AS Price, Image, CategoryName " +
                               "FROM group2fa212330.Menu AS M " + "   INNER JOIN group2fa212330.Images AS I " +
                               "       ON M.ImageID = I.ImageID " + "   INNER JOIN group2fa212330.Categories C " +
                               "       on M.CategoryID = C.CategoryID";

                _sqlMenuCommand = new SqlCommand(query, _dbConnection);
                _daMenu = new SqlDataAdapter();
                _daMenu.SelectCommand = _sqlMenuCommand;
                DTMenu = new DataTable();
                _daMenu.Fill(DTMenu);

                dgvDisplay.DataSource = DTMenu;
                dgvDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvDisplay.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                tbItemName.DataBindings.Add("Text", DTMenu, "ItemName");
                tbItemID.DataBindings.Add("Text", DTMenu, "ItemID");
                tbDescription.DataBindings.Add("Text", DTMenu, "ItemDescription");
                tbPrice.DataBindings.Add("Text", DTMenu, "Price");

                string categoryName = "SELECT * FROM group2fa212330.Categories";
                _sqlCategoryCommand = new SqlCommand(categoryName, _dbConnection);
                _daCategory.SelectCommand = _sqlCategoryCommand;
                _daCategory.Fill(DTCategories);
                cbCategory.DataSource = DTCategories;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
                cbCategory.DataBindings.Add("SelectedItem", DTCategories, "CategoryID");

                c = (CurrencyManager)form.BindingContext[DTMenu];
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void openDatabase() {
            try {
                _dbConnection = new SqlConnection(CONNECT_STRING);
                _dbConnection.Open();
            } catch (SqlException exception) {
                for (int i = 0; i < exception.Errors.Count; i++)
                    ErrorMessages.Append("Index #" + i + "\n" + "Message: " + exception.Errors[i].Message + "\n" +
                                         "LineNumber: " + exception.Errors[i].LineNumber + "\n" + "Source: " +
                                         exception.Errors[i].Source + "\n" + "Procedure: " +
                                         exception.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Disposing Publisher", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "Error Opening Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public static bool scanForPaymentOption() {
            try {
                string query = "SELECT * FROM group2fa212330.Payment WHERE AccountID = " + AccountID;
                SqlCommand _sqlPaymentCommand = new SqlCommand(query, _dbConnection);
                SqlDataAdapter _daPayment = new SqlDataAdapter(_sqlPaymentCommand);
                _daPayment.Fill(DTPayment);

                //if a payment exists return true else return false
                if (DTPayment.Rows.Count != 0)
                    return true;

                return false;
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public static void updateAccount(string[] text) {
            try {
                string query = "UPDATE group2fa212330.Accounts " + "SET Email = '" + text[1] + "', Username = '" +
                               text[2] + "', Password = '" + text[3] + "', " + "LastName = '" + text[4] +
                               "', FirstName = '" + text[5] + "' " + "WHERE AccountID = " + Convert.ToInt32(text[0]) +
                               "";

                SqlCommand _sqlDdlCommand = new SqlCommand(query, _dbConnection);
                _sqlDdlCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateMenuOnClose() {
            try {
                SqlCommandBuilder menuAdapterCommands = new SqlCommandBuilder(_daMenu);
                _daMenu.Update(DTMenu);
            } catch (SqlException ex) {
                if (ex is SqlException) {
                    //handles more specific SqlException here.
                    for (int i = 0; i < ex.Errors.Count; i++)
                        ErrorMessages.Append("Index #" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                             "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                             ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure +
                                             "\n");
                    MessageBox.Show(ErrorMessages.ToString(), "Error on UpdateOnClose", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                } else {
                    //handles generic ones here
                    MessageBox.Show(ex.Message, "Error on UpdateOnClose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void updatePicInPbx(int image, PictureBox pbxImage) {
            try {
                string query
                    = "SELECT Image FROM group2fa212330.Images as I INNER JOIN group2fa212330.Menu as M ON I.ImageID = M.ImageID WHERE ItemID = " +
                      image;
                SqlCommand _sqlImageCommand = new SqlCommand(query, _dbConnection);
                SqlDataAdapter _daImage = new SqlDataAdapter(_sqlImageCommand);
                DataTable _dtImage = new DataTable();
                _daImage.Fill(_dtImage);

                byte[] imageP = (byte[])_dtImage.Rows[0]["image"];

                MemoryStream memoryStream = new MemoryStream(imageP);

                pbxImage.Image = Image.FromStream(memoryStream);
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int verifyAccountStatus(string username, string password) {
            //function returns:
            //  -1  ->  no username found
            //   0  ->  no correct combination found
            //   1  ->  correct username and password
            //   2  ->  username and otp match

            //function also assigns the accountID

            try {
                //QUERY selects the accountid, username, password, and otp of account where username = username
                string query = "SELECT * " + "FROM group2fa212330.Accounts WHERE " + "username = '" + username + "'";

                _sqlAccountsCommand = new SqlCommand(query, _dbConnection);

                _daAccounts = new SqlDataAdapter(_sqlAccountsCommand);

                DTAccounts = new DataTable();
                _daAccounts.Fill(DTAccounts);

                if (DTAccounts.Rows.Count != 0) // if there is a unique username
                {
                    if (Convert.ToInt32(DTAccounts.Rows[0]["isActive"]) == 0) {
                        MessageBox
                            .Show("Your account is deactivated! Please contact tstcteamtwo@gmail.com to get this fixed thank you.",
                                  "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        AccountID = (int)DTAccounts
                            .Rows[0]["accountid"]; //return row 1 column cell value of column with the name"accountid"

                        //storing accounts first name and last name to use it later in the application
                        AccountFN = DTAccounts.Rows[0]["firstname"].ToString();
                        AccountLN = DTAccounts.Rows[0]["lastname"].ToString();
                        if (DTAccounts.Rows[0]["onetimepassword"] == DBNull.Value) {
                            //so if password doesn't equal password AND password does not equal one time password
                            if (password != (string)DTAccounts.Rows[0]["password"])
                                return 0; //wrong combination...
                            if (password == (string)DTAccounts.Rows[0]["password"])
                                return 1; //correct combination... nothing special -> open normal form
                        } else {
                            //so if password doesn't equal password AND password does not equal one time password
                            if ((password != (string)DTAccounts.Rows[0]["password"]) &&
                                (password != (string)DTAccounts.Rows[0]["onetimepassword"])) {
                                MessageBox.Show((string)DTAccounts.Rows[0]["password"] + " " + password + " " +
                                                (string)DTAccounts.Rows[0]["onetimepassword"]);
                                return 0; //wrong combination...
                            }

                            if (password == (string)DTAccounts.Rows[0]["password"])
                                return 1; //correct combination... nothing special -> open normal form
                            if ((password == (string)DTAccounts.Rows[0]["onetimepassword"]) ||
                                (DTAccounts.Rows[0]["onetimepassword"] != null))
                                return 2; //otp combination... special case -> need to reset password
                        }
                    }
                } else {
                    return -1; //no correct combination -> need to create account combination
                }
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            return -1;
        }

        public static int verifyEmployeeStatus() {
            //function returns:
            //   0  ->  is customer
            //   1  ->  is employee and not admin
            //   2  ->  is employee and admin

            //function also assigns the accountID

            string query = "select * from group2fa212330.employees where accountID = " + AccountID;

            _sqlEmployeesCommand = new SqlCommand(query, _dbConnection);

            _daEmployees = new SqlDataAdapter();

            _daEmployees.SelectCommand = _sqlEmployeesCommand;

            DTEmployees = new DataTable();
            _daEmployees.Fill(DTEmployees);

            if (DTEmployees.Rows.Count > 0) // if results return a row
            {
                if ((bool)DTEmployees.Rows[0]["IsAdmin"])
                    return 2; // admin

                return 1; //employee
            }

            return 0; //customer
        }

        //Returning the one time password of the user with the email that is provided, can't use get because
        //user hasn't been found
        public static string verifyOneTimePassword(string email) {
            Email = email;
            string result = string.Empty;
            try {
                //returning the accounts information that matches the email entered in the tbxForgot
                string query = "SELECT OneTimePassword FROM group2fa212330.Accounts WHERE EMAIL =  '" + Email + "'";
                _sqlAccountsCommand = new SqlCommand(query, _dbConnection);
                _daAccounts.SelectCommand = _sqlAccountsCommand;
                DTAccounts = new DataTable();
                _daAccounts.Fill(DTAccounts);

                //if the account exists
                if (DTAccounts.Rows.Count != 0) {
                    if (DTAccounts.Rows[0]["OneTimePassword"] == DBNull.Value) {
                        generatePassword(2);
                        _sqlAccountsCommand = new SqlCommand(query, _dbConnection);
                        _daAccounts.SelectCommand = _sqlAccountsCommand;
                        DTAccounts = new DataTable();
                        _daAccounts.Fill(DTAccounts);
                    }

                    //store the one time password to return in the forgot form
                    result = (string)DTAccounts.Rows[0]["OneTimePassword"];
                } else {
                    MessageBox.Show("No account associated with the email entered", "Reset Password",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (SqlException ex) {
                for (int i = 0; i < ex.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + ex.Errors[i].Message + "\n" +
                                         "LineNumber: " + ex.Errors[i].LineNumber + "\n" + "Source: " +
                                         ex.Errors[i].Source + "\n" + "Procedure: " + ex.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //returning OTP to send VIA email
            return result;
        }

        public static void bindEmployees(DataGridView dgvEmployees, string tempAccountID) {

            //MessageBox.Show(tempAccountID, "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try {
                string query
                    = $"SELECT * FROM group2fa212330.Employees where AccountID = {tempAccountID}";
                _sqlEmployeesCommand = new SqlCommand(query, _dbConnection);
                _daEmployees.SelectCommand = _sqlEmployeesCommand;

               // MessageBox.Show("cleared datagridview ", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //if (DTMenu.) {
                //    DTMenu.Clear();

                //}
                DTEmployees.Clear();
                _daEmployees.Fill(DTEmployees);
                dgvEmployees.DataSource = DTEmployees;

                //dgvEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                //dgvEmployees.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            } catch (SqlException exception) {
                for (int i = 0; i < exception.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + exception.Errors[i].Message + "\n" +
                                         "LineNumber: " + exception.Errors[i].LineNumber + "\n" + "Source: " +
                                         exception.Errors[i].Source + "\n" + "Procedure: " + exception.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void showPaycheck(
            Label lblEmployeeId, Label lblEmployeeName, Label lblHourlyRate, Label lblWeeklyHoursWorked,
            Label lblGrossPay, Label lblSocialSecurityWithheld, Label lblFicaWithheld, Label lblNetPay
        ) {
            try {

                string query = "SELECT " +
                               "ItemID, ItemName, ItemDescription, FORMAT(Price, 'C') AS Price, Image, CategoryName " +
                               "FROM group2fa212330.Menu AS M " + "   INNER JOIN group2fa212330.Images AS I " +
                               "       ON M.ImageID = I.ImageID " + "   INNER JOIN group2fa212330.Categories C " +
                               "       on M.CategoryID = C.CategoryID";


            } catch (SqlException exception) {
                for (int i = 0; i < exception.Errors.Count; i++)
                    ErrorMessages.Append("Index#" + i + "\n" + "Message: " + exception.Errors[i].Message + "\n" +
                                         "LineNumber: " + exception.Errors[i].LineNumber + "\n" + "Source: " +
                                         exception.Errors[i].Source + "\n" + "Procedure: " +
                                         exception.Errors[i].Procedure + "\n");

                MessageBox.Show(ErrorMessages.ToString(), "Error Closing Database", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show("Error:\n\t" + ex.Message, "ProgOps Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
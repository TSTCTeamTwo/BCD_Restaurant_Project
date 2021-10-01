using System;
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
        private static int totalItems;
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

        public static string AccountFirstname { get; set; } = string.Empty;
        public static string AccountLastname { get; set; } = string.Empty;
        public static string Username { get; set; } = string.Empty;
        public static int AccountID { get; set; } = 0;

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

            string query = "select * from group2fa212330.Accounts where username = '" + username + "' AND password = '" + password + "'";

            _sqlAccountsCommand = new SqlCommand(query, _cntDBConnection);

            _daAccounts = new SqlDataAdapter(selectCommand: _sqlAccountsCommand);
            
            _dtAccountsTable = new DataTable();
            _daAccounts.Fill(_dtAccountsTable);

            if (_dtAccountsTable.Rows.Count > 0) // if results return a row
            {
                accountID =
                    (int)_dtAccountsTable
                        .Rows[0]["AccountID"]; //return row 1 column cell value of column with the name"AccountID"
               // MessageBox.Show("Welcome "+_dtAccountsTable.Rows[0]["FirstName"]+"!");
            }

            //dispose all the connections
            return accountID;

        }

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

        public static void DisplayMenuItems(DataGridView dgvDisplay, int categoryId)
        {
            string query = "SELECT ItemName, ItemDescription, Price, Image FROM group2fa212330.Menu INNER JOIN group2fa212330.Images ON Menu.ImageID = Images.ImageID WHERE CategoryID = "+categoryId;
            _sqlMenuCommand = new SqlCommand(query, _cntDBConnection);
            _daMenu.SelectCommand = _sqlMenuCommand;
            dgvDisplay.Rows.Clear();
            _dtMenu.Clear();
            _daMenu.Fill(_dtMenu);
            dgvDisplay.DataSource = _dtMenu;

            dgvDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
        }

    }
}

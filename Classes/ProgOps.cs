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
    class ProgOps
    {
        private const string CONNECT_STRING = "Server=cstnt.tstc.edu;Database= inew2330fa21;User Id =group2fa212330;password=2547268";

        private static SqlConnection _cntDBConnection = new SqlConnection(CONNECT_STRING);

        private static SqlDataAdapter _daAccounts = new SqlDataAdapter();
        private static DataTable _dtAccounts = new DataTable();

        private static SqlDataAdapter _daEmployees = new SqlDataAdapter();
        private static DataTable _dtEmployees = new DataTable();

        private static readonly StringBuilder _errorMessages = new StringBuilder();

        public static void openDatabase()
        {
            try
            {
                _cntDBConnection.Open();
                MessageBox.Show("Connection to database was successfully opened.", "Database Connection",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Connection to database was successfully closed.", "Database Connection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                _cntDBConnection.Dispose();
                _daAccounts.Dispose();
                _daEmployees.Dispose();
                _dtAccounts.Dispose();
                _dtEmployees.Dispose();

            }catch(SqlException ex)
            {
                if(ex is SqlException)
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

    }
}

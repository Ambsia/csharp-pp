using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PasswordProtector
{
    class Error
    {
        private string errorDescription;
        private int errorRiskLevel;
        private object userID;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;

        DateTime dateTimeOccured;

        string connectionString;
        //really want to handle the exeception well here
        //pass exeception and find out what it was

        public Error(string errorDescription, int errorRiskLevel, object userID, DateTime dateTimeOccured)
        {
            this.errorDescription = errorDescription;
            this.errorRiskLevel = errorRiskLevel;
            this.userID = userID;
            this.dateTimeOccured = dateTimeOccured;
        }

        public string ErrorDescription
        {
            get { return errorDescription; } 
            set { errorDescription = value; }
        }
        public int ErrorRiskLevel
        {
            get { return errorRiskLevel; }
            set { errorRiskLevel = value; }
        }


        public void InsertError()
        {

            connectionString = frmMain.GetSqlConnectionString().ConnectionString;
            try
            {
                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    using (sqlCommand = new SqlCommand("Insert into ProgramError (ErrorRiskLevel,ErrorDescription,UserID,DateOccured,TimeOccured)" +
                          "VALUES (@ErrorRiskLevel, @ErrorDescription, @UserID, @DateOccured, @TimeOccured)", sqlConnection))
                    {



                        sqlCommand.Parameters.Add(new SqlParameter("@ErrorRiskLevel", SqlDbType.SmallInt));
                        sqlCommand.Parameters.Add(new SqlParameter("@ErrorDescription", SqlDbType.NVarChar));
                        sqlCommand.Parameters.Add(new SqlParameter("@UserID", SqlDbType.NChar));
                        sqlCommand.Parameters.Add(new SqlParameter("@DateOccured", SqlDbType.NChar));
                        sqlCommand.Parameters.Add(new SqlParameter("@TimeOccured", SqlDbType.NChar));

                        if (userID == null)
                            userID = "Account Creation";

                        sqlCommand.Parameters["@ErrorRiskLevel"].Value = errorRiskLevel;
                        sqlCommand.Parameters["@ErrorDescription"].Value = errorDescription;
                        sqlCommand.Parameters["@UserID"].Value = userID;
                        sqlCommand.Parameters["@DateOccured"].Value = dateTimeOccured.ToString("MMMM dd, yyyy");
                        sqlCommand.Parameters["@TimeOccured"].Value = dateTimeOccured.ToString("HH:mm:ss");
                    }
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("A database exception occured, please try again. This error has been noted and sent to an admin", "Database Malfunction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}

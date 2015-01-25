using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace PasswordProtector
{
    public class Validation
    {

    
        private string exception;
        private Credential credential;
        private Account account;

        private SqlConnection sqlConnection;
        private Error error;
        private Regex regex;
        private SqlCommand sqlCommand;


        public Validation(Credential credential)
        {
            this.credential = credential;
            account = null;
        }

        public Validation(Account account)
        {
            this.account = account;
            credential = null;
        }

        public bool PasswordContainUsername()
        {
            return account.UserPassword.Contains(account.UserName);
        }

        public bool EmailAddressValidation()
        {
          
            //first regular expression! looks for starting chars of type alphanumeric (must be 4 in length or more), 
            //then looks for proceding @ with 3 or more chars then looks for . with at least 1 but less than 4 char after
            Regex emailValidation = new Regex(@"^([a-zA-Z0-9]{4,})+\@[a-z]{3,}\..[.a-z]{1,4}$");
            return emailValidation.IsMatch(account.UserEmail);
        }


        public string DuplicateUsername()
        {
            try
            {
                using (sqlConnection = new SqlConnection(frmMain.GetSqlConnectionString().ConnectionString))
                {
                    sqlConnection.Open();
                    using (sqlCommand = new SqlCommand("Select AccountUsername From Account Where AccountUsername = @Username", sqlConnection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("Username", account.UserName));
                        using (SqlDataReader rdr = sqlCommand.ExecuteReader())
                        {
                            while (rdr.Read())
                                return "True";
                            return "False";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                error = new Error(exception = e.ToString().Length > int.MaxValue ? "not enough space" : e.ToString(), 2, null, DateTime.Now);
                error.InsertError();
                return "Error";
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        public bool InvalidCharacters()
        {
            regex = new Regex("[^A-Za-z0-9_]");

            return regex.IsMatch(account.UserName);
        }


        public int StringLength(string _string)
        {
            return _string.Length;
        }

        public bool EmptyFields()
        {
            if (account == null)
                return (credential.UserName == "" || credential.UserPassword == "");
            else
                return (account.UserName == "" || account.UserPassword == "");
        }


        public int PasswordStrength()
        {
           Regex regexWeakPasswordAlpha = new Regex("^[A-Za-z]*$");
           Regex regexWeakPasswordNumeric = new Regex("^[0-9]*$");

           if (regexWeakPasswordAlpha.IsMatch(account.UserPassword) || regexWeakPasswordNumeric.IsMatch(account.UserPassword))
           {
               return 0;
           }
           else
           {
               return 1; 
           }
        }
    }

}

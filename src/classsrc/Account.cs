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
using System.Security.Cryptography;

namespace PasswordProtector
{
    public class Account
    {
        private string userName;
        private string userPassword;
        private string userEmail;
        private DateTime userCreationDate;
        private int userLevel;
        private int userPin;
        private object accountID;


        private string accountSalt;
        private string currentPasswordHash;

        public Account(string userName, string userPassword, string userEmail, DateTime userCreationDate, int userPin, int userLevel, object accountID)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.userEmail = userEmail;
            this.userCreationDate = userCreationDate;
            this.userPin = userPin;
            this.userLevel = userLevel;
            this.accountID = accountID;
            this.accountSalt = "";
            this.currentPasswordHash = "";
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }

        public DateTime UserCreationDate
        {
            get { return userCreationDate; }
        }

        public int UserLevel
        {
            get { return userLevel; }
        }

        public object AccountID
        {
            get { return accountID; }
        }

        public int UserPin
        {
            get { return userPin; }
            set { userPin = value; }
        }

        public void CreateAccount()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(frmMain.GetSqlConnectionString().ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Insert into Account (AccountUsername,AccountPassword,AccountEmail,AccountCreationDate,AccountSalt)" + "VALUES (@Username, @Password, @Email, @CreationDate, @Salt)", sqlConnection))
                    {

                        Random rndNum = new Random(System.DateTime.Now.Millisecond);

                        int numFirstPhase = rndNum.Next(100000, Int32.MaxValue);
                        int numSecondPhase = numSecondPhase = numFirstPhase % ((userCreationDate.Millisecond + 531) * 2729);
                        long numThirdPhase = (numSecondPhase * 31) * 7;
                        accountSalt = Convert.ToString(numThirdPhase);

                        sqlCommand.Parameters.Add(new SqlParameter("@Username", userName));
                        sqlCommand.Parameters.Add(new SqlParameter("@Password", HashPassword(userPassword + accountSalt)));
                        sqlCommand.Parameters.Add(new SqlParameter("@Email", userEmail));
                        sqlCommand.Parameters.Add(new SqlParameter("@CreationDate", userCreationDate.ToString("MMMM dd, yy")));
                        sqlCommand.Parameters.Add(new SqlParameter("@Salt", accountSalt));

                        

                        if (sqlCommand.ExecuteNonQuery() == 1)
                        {
                            MessageDialog.InfoMessageBox("Account Created");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Error error = new Error(e.ToString(), 2, null, DateTime.Now);
                error.InsertError();
            }
        }


        public void InsertPin()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(frmMain.GetSqlConnectionString().ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Update Account SET AccountPin=@Pin From Account Where AccountUsername = @Username AND AccountPassword = @Password ", sqlConnection))
                    {

                        sqlCommand.Parameters.Add(new SqlParameter("@Username", userName));
                        sqlCommand.Parameters.Add(new SqlParameter("@Password", HashPassword(userPassword + accountSalt)));
                        sqlCommand.Parameters.Add(new SqlParameter("@Pin", userPin));

                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Error error = new Error(e.ToString(), 2, null, DateTime.Now);
                error.InsertError();
            }
        }

        public bool AccountLogin()
        {
            try
            {
                bool accountFound = false;
                using (SqlConnection sqlConnection = new SqlConnection(frmMain.GetSqlConnectionString().ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Select AccountUsername,AccountSalt From Account Where AccountUsername = @Username", sqlConnection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@Username", userName));
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                accountSalt = Convert.ToString(sqlDataReader["AccountSalt"]).Trim(' ');
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
     
                    using (SqlCommand sqlCommand = new SqlCommand("Select AccountUsername,AccountPassword,AccountEmail,AccountLevel,AccountID,AccountPin,AccountCreationDate From Account Where AccountUsername = @Username AND AccountPassword = @Password", sqlConnection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@Username", userName));
                        sqlCommand.Parameters.Add(new SqlParameter("@Password", HashPassword(userPassword + accountSalt)));
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.HasRows == false)
                                return false;

                            if (sqlDataReader.Read() && accountFound == false)
                            {
                                accountFound = true;

                                this.currentPasswordHash = HashPassword(userPassword + accountSalt);

                                this.accountID = Convert.ToString(sqlDataReader["AccountID"]).Trim(' ');
                                this.userLevel = Convert.ToInt32(sqlDataReader["AccountLevel"]);
                                this.userEmail = Convert.ToString(sqlDataReader["AccountEmail"]).Trim(' ');
                                this.userCreationDate = Convert.ToDateTime(sqlDataReader["AccountCreationDate"]);
                                this.userPin = Convert.ToInt32(sqlDataReader["AccountPin"]);

                                
                                return true;

                            }
                            else
                                return false;
                        }
                    }
                }
            }
            catch (Exception e)
            {

                Error error = new Error(e.ToString(), 2, null, DateTime.Now);
                error.InsertError();
                return false;
            }
        }

        private string HashPassword(string saltedPassword)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            SHA1 sha1;
            
            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            sha1 = new SHA1CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(saltedPassword);

            encodedBytes = sha1.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return Regex.Replace(BitConverter.ToString(encodedBytes), "-", "").ToLower();
        }

        public bool ComparePassword(string password)
        {
            return HashPassword(password + this.accountSalt) == this.currentPasswordHash;
        }
    }
}
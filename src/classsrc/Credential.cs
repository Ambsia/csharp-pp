using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PasswordProtector
{

    public class Credential : IEnumerable<Tuple<Credential, Image>>
    {
        private static List<Tuple<Credential, Image>> listOfCredentials = new List<Tuple<Credential, Image>>();

        private object accountId;
        private object userID;
        private string userName;           //                            //
        private string password;           //                            //
        private string type;               //                            // 
        private bool pinProtection;        // DATA INFORMATION VARIABLES //
        private DateTime dateAdded;        //                            //
        private DateTime dateModified;     //                            //
        private string websiteAssociate;

        public Credential()
        {
            this.accountId = "";
            this.userID = "";
            this.userName = "";
            this.password = "";
            this.type = "";
            this.pinProtection = false;
            this.dateAdded = DateTime.Now;
            this.dateModified = DateTime.Now;
            this.websiteAssociate = "";
        }

        public IEnumerator<Tuple<Credential, Image>> GetEnumerator()
        {
            return listOfCredentials.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string UserPassword
        {
            get { return password; }
            set { password = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public bool PinProtection
        {
            get { return pinProtection; }
            set { pinProtection = value; }
        }

        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }

        public DateTime DateModified
        {
            get { return dateModified; }
            set { dateModified = value; }
        }

        public string WebsiteAssociate
        {
            get { return websiteAssociate; }
            set { websiteAssociate = value; }
        }

        public int GetSizeOfList()
        {
            return listOfCredentials.Count;
        }

        public Tuple<Credential, Image> GetCredential(int index)
        {
            Tuple<Credential, Image> credential = null;
            if (index < 0 || index > listOfCredentials.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
                credential = listOfCredentials[index];
            return credential;
        }

        public void RemoveCredential(int index)
        {
            if (index < 0 || index >= listOfCredentials.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                listOfCredentials.RemoveAt(index);
                this.RemoveData(this.userID);
            }
        }


        //  string faviconGrab = string.Format(@"http://getfavicon.appspot.com/{0}", websiteAddress);
        // string faviconGrab = string.Format(websiteAddress + "favicon.ico");
        // string faviconGrab = string.Format(@"http://www.google.com/s2/favicons?domain={0}", websiteAddress);
        //string faviconGrab = string.Format(@"http://grabicon.com/", websiteAddress);


        //private bool FetchWebsiteFavicon(string websiteAddress, string fileSavePath)
        //{
        //    WebRequest.DefaultWebProxy = null;

        //    if (File.Exists(fileSavePath)) 
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
        //        {
        //            string faviconGrab;
        //            try
        //            {
        //                using (WebClient webClient = new WebClient()) //first attempt, look for a favicon in the root
        //                {
        //                    webClient.Proxy = null;
        //                    faviconGrab = string.Format(@"http://{0}/favicon.ico", websiteAddress);
        //                    webClient.DownloadFile(faviconGrab, fileSavePath + ".ico");
        //                    return true;
        //                }
        //            }
        //            catch (WebException webException) // if the first attempt fails, let us use a website that finds us the favicon
        //            {
        //                using (WebClient webClient = new WebClient())
        //                {
        //                    faviconGrab = string.Format(@"http://grabicon.com/icon?domain={0}&size=46", websiteAddress);
        //                    webClient.Proxy = null;

        //                    webClient.DownloadFile(faviconGrab, fileSavePath);
        //                    return true;
        //                }   
        //            }
        //            catch (Exception e)
        //            {
        //                Error error = new Error(e.ToString(), 3, null, DateTime.Now);
        //                error.InsertError();
        //                return false;
        //            }
        //        } 
        //        else 
        //        {
        //            MessageDialog.ErrorMessageBox("You are not connected to the internet.");
        //            return false;
        //        }
        //    }       
        //}

        private byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            ms.Seek(0, SeekOrigin.Begin);
            return Image.FromStream(ms);
        }

        private Image GetFavicon()
        {
            DirectoryInfo info = new DirectoryInfo(@".\src\Favicons\");
            string iconFilePath = string.Format(@"{0}", info.FullName);

            WebRequest.DefaultWebProxy = null;

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                string faviconGrab;
                try
                {
                    using (WebClient webClient = new WebClient()) //first attempt, look for a favicon in the root
                    {
                        webClient.Proxy = null;

                        faviconGrab = string.Format(@"http://{0}/favicon.ico", websiteAssociate);
                        iconFilePath += websiteAssociate + ".ico";
                        webClient.DownloadFile(faviconGrab, iconFilePath);

                        using (var Stream = new FileStream(iconFilePath, FileMode.Open, FileAccess.Read))
                        {
                            using (var Reader = new BinaryReader(Stream))
                            {
                                // put those bytes into a memory stream and "rewind" the memory stream
                                return ByteArrayToImage(Reader.ReadBytes((int)Stream.Length));
                            }
                        }
                    }
                }
                catch (WebException webException) // if the first attempt fails, let us use a website that finds us the favicon
                {
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.Proxy = null;

                        faviconGrab = string.Format(@"http://grabicon.com/icon?domain={0}&size=46", websiteAssociate);
                        iconFilePath += websiteAssociate + ".png";
                        webClient.DownloadFile(faviconGrab, iconFilePath);

                        using (var Stream = new FileStream(iconFilePath, FileMode.Open, FileAccess.Read))
                        {
                            using (var Reader = new BinaryReader(Stream))
                            {
                                // put those bytes into a memory stream and "rewind" the memory stream
                                return ByteArrayToImage(Reader.ReadBytes((int)Stream.Length));
                            }
                        }
                    }
                }
                catch (Exception e) // if this fails all hope is lost.
                {
                    return null;
                }
            }
            else
            {
                MessageDialog.ErrorMessageBox("You are not connected to the internet.");
                iconFilePath = string.Format(@"{0}default.png", info.FullName);
                using (var Stream = new FileStream(iconFilePath, FileMode.Open, FileAccess.Read))
                {
                    using (var Reader = new BinaryReader(Stream))
                    {
                        // put those bytes into a memory stream and "rewind" the memory stream
                        return ByteArrayToImage(Reader.ReadBytes((int)Stream.Length));
                    }
                }

            }
        }
       

                 

            //string iconSaveName = "";



            // Environment.CurrentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //DirectoryInfo info = new DirectoryInfo(@".\src\Favicons\");
            /*if (websiteAssociate.Length > 7)
            {
                iconSaveName = websiteAssociate.Remove(0, 7);

                iconFilePath = string.Format(@"{0}{1}.png",info.FullName, iconSaveName);
            }*/
            //iconFilePath = string.Format(@"{0}{1}", info.FullName, this.websiteAssociate);
            //if (FetchWebsiteFavicon(websiteAssociate, iconFilePath))
            //{
        //    try
        //    {
        //        using (var Stream = new FileStream(iconFilePath, FileMode.Open, FileAccess.Read))
        //        {
        //            using (var Reader = new BinaryReader(Stream))
        //            {
        //                // put those bytes into a memory stream and "rewind" the memory stream
        //                return ByteArrayToImage(Reader.ReadBytes((int)Stream.Length));
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Error error = new Error(e.ToString(), 3, null, DateTime.Now);
        //        error.InsertError();
        //        return null;
        //    }
        //    }
        //    else
        //    {
        //        try
        //        {
        //            iconFilePath = string.Format(@"{0}default.png", info.FullName);
        //            using (var Stream = new FileStream(iconFilePath, FileMode.Open, FileAccess.Read))
        //            {
        //                using (var Reader = new BinaryReader(Stream))
        //                {
        //                    // put those bytes into a memory stream and "rewind" the memory stream
        //                    return ByteArrayToImage(Reader.ReadBytes((int)Stream.Length));
        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Error error = new Error(e.ToString(), 3, null, DateTime.Now);
        //            error.InsertError();
        //            return null;
        //        }
        //    }

        //}


        public Image GetImage(int index)
        {
            if (index <= listOfCredentials.Count && index >= 0)
                return listOfCredentials[index].Item2;
            else
                return null;
        }



        public void EditCredential(int index)
        {
            this.ReplaceData();

            listOfCredentials.RemoveAt(index);

            listOfCredentials.Insert(index, new Tuple<Credential, Image>(this, GetFavicon()));
        }


        public void AddCredential(object accountId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(frmMain.GetSqlConnectionString().ConnectionString))
                {
                    Image favicon;
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Insert into Credential (Username,Password,UserID,pinProtection,Type,DateAdded,DateModified,WebsiteAssociate,WebsiteFavicon)" +
                        "VALUES (@Username, @Password, @UserID, @PinProtection, @Type, @DateAdded, @DateModified, @WebsiteAssociate, @WebsiteFavicon) SELECT SCOPE_IDENTITY()", sqlConnection))
                    {


                        string encryptedusername = Cryptography.Encrypt(userName, Convert.ToString(Convert.ToInt32(accountId) * 3109));
                        string encryptedpass = Cryptography.Encrypt(password, Convert.ToString(Convert.ToInt32(accountId) * 3109));

                        favicon = GetFavicon();

                        sqlCommand.Parameters.Add(new SqlParameter("@Username", encryptedusername));
                        sqlCommand.Parameters.Add(new SqlParameter("@Password", encryptedpass));
                        sqlCommand.Parameters.Add(new SqlParameter("@UserID", accountId));
                        sqlCommand.Parameters.Add(new SqlParameter("@PinProtection", pinProtection));
                        sqlCommand.Parameters.Add(new SqlParameter("@Type", type));
                        sqlCommand.Parameters.Add(new SqlParameter("@DateAdded", dateAdded.ToString("MMMM dd, yyyy")));
                        sqlCommand.Parameters.Add(new SqlParameter("@DateModified", dateModified.ToString("MMMM dd, yyyy")));
                        sqlCommand.Parameters.Add(new SqlParameter("@WebsiteAssociate", websiteAssociate));
                        sqlCommand.Parameters.Add(new SqlParameter("@WebsiteFavicon", ImageToByteArray(favicon)));
                        this.userID = sqlCommand.ExecuteScalar();
                        sqlConnection.Close();
                    }
                    listOfCredentials.Add(new Tuple<Credential, Image>(this, favicon));
                }
            }
            catch (Exception e)
            {
                Error error = new Error(e.ToString(), 2, accountId, DateTime.Now);
                error.InsertError();
            }
        }

        public bool ReplaceData()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(frmMain.GetSqlConnectionString().ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Update Credential SET Username=@NewUsername, Password=@NewPassword, pinProtection=@NewPinProtection" +
                                                       " ,Type=@NewType,DateModified=@DateModified,WebsiteAssociate=@NewWebsiteAssociate,WebsiteFavicon=@NewFavicon From Credential Where ID = @ID", sqlConnection))
                    {

                        string encryptedUsername = Cryptography.Encrypt(userName, Convert.ToString(Convert.ToInt32(accountId) * 3109));
                        string encryptedPassword = Cryptography.Encrypt(password, Convert.ToString(Convert.ToInt32(accountId) * 3109));

                        sqlCommand.Parameters.Add(new SqlParameter("@ID", this.userID));
                        sqlCommand.Parameters.Add(new SqlParameter("@NewUsername", encryptedUsername));
                        sqlCommand.Parameters.Add(new SqlParameter("@NewPassword", encryptedPassword));
                        sqlCommand.Parameters.Add(new SqlParameter("@NewPinProtection", pinProtection));
                        sqlCommand.Parameters.Add(new SqlParameter("@NewType", type));
                        sqlCommand.Parameters.Add(new SqlParameter("@DateModified", dateModified.ToString("MMMM dd, yyyy")));
                        sqlCommand.Parameters.Add(new SqlParameter("@NewWebsiteAssociate", websiteAssociate));
                        sqlCommand.Parameters.Add(new SqlParameter("@NewFavicon", ImageToByteArray(GetFavicon())));

                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        return true;
                    }

                }

            }
            catch (Exception e)
            {
                Error error = new Error(e.ToString(), 2, accountId, DateTime.Now);
                error.InsertError();
                return false;
            }
        }

        public bool RemoveData(object credentialID)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(frmMain.GetSqlConnectionString().ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Delete From Credential Where ID = @ID", sqlConnection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("ID", credentialID));
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Error error = new Error(e.ToString(), 2, accountId, DateTime.Now);
                error.InsertError();
                return false;
            }
        }


        public void PopulateCredentialList(object accountId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(frmMain.GetSqlConnectionString().ConnectionString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("Select ID,Username,Password,UserID,PinProtection,Type,DateAdded,DateModified,WebsiteAssociate,WebsiteFavicon From Credential Where UserID = @ID", sqlConnection))
                    {
                        sqlCommand.Parameters.Add(new SqlParameter("@ID", accountId));

                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            if (sqlDataReader.HasRows == true)
                            {
                                while (sqlDataReader.Read())
                                {
                                    var credential = new Credential
                                    {
                                        userID = Convert.ToString(sqlDataReader["ID"]).Trim(),
                                        userName = userName = Cryptography.Decrypt(Convert.ToString(sqlDataReader["Username"]).Trim(), Convert.ToString(Convert.ToInt32(accountId) * 3109)),
                                        password = Cryptography.Decrypt(Convert.ToString(sqlDataReader["Password"]).Trim(), Convert.ToString(Convert.ToInt32(accountId) * 3109)), //decrypts the password
                                        type = Convert.ToString(sqlDataReader["Type"]).Trim(),
                                        pinProtection = Convert.ToBoolean(sqlDataReader["PinProtection"]),
                                        dateAdded = Convert.ToDateTime(sqlDataReader["DateAdded"]),
                                        dateModified = Convert.ToDateTime(sqlDataReader["DateModified"]),
                                        accountId = this.accountId,
                                        websiteAssociate = Convert.ToString(sqlDataReader["WebsiteAssociate"]).Trim()

                                    };

                                    var imageBytes = (byte[])sqlDataReader["WebsiteFavicon"];

                                    listOfCredentials.Add(new Tuple<Credential, Image>(credential, ByteArrayToImage(imageBytes)));
                                }
                            }
                            sqlConnection.Close();
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Error error = new Error(e.ToString(), 2, accountId, DateTime.Now);
                error.InsertError();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Collections.Specialized;

namespace PasswordProtector
{
    public partial class frmDashBoard : Form
    {

        //global variable types/objects
        private bool isFunctionAddAccount = false;
        private bool removeMultiple;
        private bool quit = false;
        private Account account;

        //Credential credential;

        private Credential userCredentials;

        private Error validationError;

        /// <summary> ACTUAL FORM EVENT METHODS
        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////

        //constructor passing the account logged in to the dashboard form
        public frmDashBoard(Account account)
        {

            //shows this form
            string welcomeMessage = string.Format("Hello {0}, please enter your security pin.", account.UserName);


            userCredentials = new Credential();
            this.account = account;

            //initializing objects
            validationError = new Error("Input Error", 0, account.AccountID, DateTime.Now);

            //data = new Credential(null, null, null, null, false, DateTime.Now, DateTime.Now, account.UserID, null);

        
            userCredentials.PopulateCredentialList(account.AccountID);



            InitializeComponent();

            if (account.UserPin == 0 || Microsoft.VisualBasic.Interaction.InputBox(welcomeMessage, "Security", "").Equals(Convert.ToString(account.UserPin)))
                this.ShowDialog();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            


            HidePanels(pnlCredentials);
            //removes all the columns except the first one that is to be displayed, rest of the columns information can still be touched

            for (int i = lvUserCredentials.Columns.Count - 1; i != 0; i = lvUserCredentials.Columns.Count - 1)
                lvUserCredentials.Columns.RemoveAt(i);


            RecolourListView();

            FillListView();
        }

        private void frmDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {

            //checks to make sure the user actually wanted to log out when they hit the close
            if (quit != true)
            {
                if (!Logout())
                {
                    //cancel form closing event true
                    e.Cancel = true;
                }
                else
                {
                    quit = true;
                    //calls system exit

                    Application.Exit();
                }
            }

        }


        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        /// </summary>

        /// <summary> METHODS
        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////

        private void FillListView()
        {
            imageList1.Images.Clear();
            ListViewItem item;
            // userCredentials.sort();
            foreach (var tuple in userCredentials)
            {
                item = new ListViewItem(new[] { tuple.Item1.UserName + Environment.NewLine + tuple.Item1.WebsiteAssociate,
                                                                    tuple.Item1.UserName,
                                                                    tuple.Item1.WebsiteAssociate, 
                                                                    Convert.ToString(tuple.Item1.UserID), 
                                                                    tuple.Item1.UserPassword,
                                                                    tuple.Item1.Type,
                                                                    Convert.ToString(tuple.Item1.PinProtection),
                                                                    Convert.ToString(tuple.Item1.DateAdded), 
                                                                    Convert.ToString(tuple.Item1.DateModified) });
                lvUserCredentials.Items.Add(item);


                imageList1.Images.Add(tuple.Item2);
                item.ImageIndex = (lvUserCredentials.Items.Count - 1);
            }
        }

        private void ValidateSelection(Action FunctionToComplete, Label currentLabel)
        {
            int selectionCount = lvUserCredentials.SelectedItems.Count;

            if (isFunctionAddAccount == true)
            {
                SetPanelLabels(currentLabel, pnlCredentials);
                FunctionToComplete();
            }
            else
            {
                if (selectionCount == 0)
                {
                    MessageDialog.ErrorMessageBox("You must select a credential to do this.");
                }
                else
                {
                    if (lvUserCredentials.SelectedItems.Count > 1 && !removeMultiple)
                    {
                        MessageDialog.ErrorMessageBox("You must only select one row at a time.");
                    }
                    else
                    {
                        lvUserCredentials.Select();
                        bool credentialPinProtect = Convert.ToBoolean(lvUserCredentials.SelectedItems[0].SubItems[6].Text);
                        if (account.UserLevel == 9999)
                        {
                            SetPanelLabels(currentLabel, pnlCredentials);
                            FunctionToComplete();
                        }
                        else if (credentialPinProtect)
                        {
                            if (account.UserPin != 0)
                            {
                                if (RequiresPin())
                                {
                                    MessageDialog.ErrorMessageBox("You need to go through more security steps to complete this action.");
                                }
                                else
                                {
                                    SetPanelLabels(currentLabel, pnlCredentials);
                                    FunctionToComplete();
                                }
                            }
                            else
                            {
                                MessageDialog.ErrorMessageBox("You have not yet set a pin up with your account, you must do so in order to use pin protection.");
                            }
                        }
                        else if (!credentialPinProtect)
                        {
                            SetPanelLabels(currentLabel, pnlCredentials);
                            FunctionToComplete();
                        }
                    }
                }
            }
        }//handles selection of credentials edting and adding etc 

        private bool RequiresPin()
        {
            //if (txtUserPin.Text == account.UserPin)
            //{
            //return false;
            //}
            return true;
        } // checks if a credential the user is editing has extra protection 


        private void ViewCredential()
        {
            int index = lvUserCredentials.SelectedIndices[0];

            Tuple<Credential, Image> credentialViewed = userCredentials.GetCredential(index);



            frmViewCredential viewSelectedCredential = new frmViewCredential(credentialViewed.Item1, credentialViewed.Item2);

            if (viewSelectedCredential.ShowDialog() == System.Windows.Forms.DialogResult.Abort)
            {
                viewSelectedCredential.Close();
            }
        }

        private void AddCredential()
        {
            Credential newCredential = new Credential(); //instead of using the account id to generate a random key..

            ListViewItem item;
            frmNewCredential newCredentials = new frmNewCredential(newCredential);

            validationError = new Error("Validation Error", 0, account.AccountID, DateTime.Now);

            if (newCredentials.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Validation validate = new Validation(newCredential);
                if (validate.EmptyFields())
                {
                    MessageDialog.ErrorMessageBox("You must fill in all fields.");
                }
                else if (validate.StringLength(newCredential.UserName) < 5 || validate.StringLength(newCredential.UserPassword) < 5)
                {
                    MessageDialog.ErrorMessageBox("Username and password both need to be over 5 characters long.");
                }
                else if (!validate.ValidateWebsiteAddress())
                {
                    MessageDialog.ErrorMessageBox("Website address could not be validated");
                }
                else
                {
                    newCredential.AddCredential(account.AccountID); // inserts account into database then adds account to credential list 

                    item = new ListViewItem(new[] { newCredential.UserName + Environment.NewLine + newCredential.WebsiteAssociate, // adds credential to list 
                                                                    newCredential.UserName,
                                                                    newCredential.WebsiteAssociate, 
                                                                    Convert.ToString(newCredential.UserID), 
                                                                    newCredential.UserPassword,
                                                                    newCredential.Type,
                                                                    Convert.ToString(newCredential.PinProtection),
                                                                    Convert.ToString(newCredential.DateAdded), 
                                                                    Convert.ToString(newCredential.DateModified) });

                    lvUserCredentials.Items.Add(item);

                    imageList1.Images.Add(newCredential.GetImage(userCredentials.GetSizeOfList() - 1));
                    item.ImageIndex = (lvUserCredentials.Items.Count - 1);
                    RecalImageListIndex();
                }
                RecolourListView();
            }
            else
            {
                newCredentials.Close();

            }


        }// allows the user to add a credential to their account

        private void EditCredential()
        {

            int index = lvUserCredentials.SelectedIndices[0];

            Credential credentialToEdit = userCredentials.GetCredential(index).Item1;


            frmEditCredential editSelectedCredential = new frmEditCredential(credentialToEdit);

            if (editSelectedCredential.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Validation validate = new Validation(credentialToEdit);

                if (validate.EmptyFields())
                {
                    MessageDialog.ErrorMessageBox("You must fill in all fields.");
                }
                else if (validate.StringLength(credentialToEdit.UserName) < 5 || validate.StringLength(credentialToEdit.UserPassword) < 5)
                {
                    MessageDialog.ErrorMessageBox("Username and password both need to be over 5 characters long.");
                }
                else if (!validate.ValidateWebsiteAddress())
                {
                    MessageDialog.ErrorMessageBox("Website address could not be validated");
                }
                else
                {
                    credentialToEdit.EditCredential(index);

                    lvUserCredentials.Items[index].SubItems[0].Text = credentialToEdit.UserName + Environment.NewLine + credentialToEdit.WebsiteAssociate;
                    lvUserCredentials.Items[index].SubItems[1].Text = credentialToEdit.UserName;
                    lvUserCredentials.Items[index].SubItems[2].Text = credentialToEdit.WebsiteAssociate;
                    lvUserCredentials.Items[index].SubItems[3].Text = Convert.ToString(credentialToEdit.UserID);
                    lvUserCredentials.Items[index].SubItems[4].Text = credentialToEdit.UserPassword;
                    lvUserCredentials.Items[index].SubItems[5].Text = credentialToEdit.Type;
                    lvUserCredentials.Items[index].SubItems[6].Text = Convert.ToString(credentialToEdit.PinProtection);
                    lvUserCredentials.Items[index].SubItems[7].Text = Convert.ToString(credentialToEdit.DateAdded);
                    lvUserCredentials.Items[index].SubItems[8].Text = Convert.ToString(credentialToEdit.DateModified);

                    //userCredentials.GetCredential(index).Item1.ToString();
                    //cannot just assign serCredentials.GetCredential(index).Item2 because it will be the original size of the downloaded image resizing below
                    //create a bitmap object and place the new image into it
                    Bitmap image = (Bitmap)userCredentials.GetCredential(index).Item2;
                    //create a size object of 70 by 60
                    Size newSize = new Size(46, 46);
                    //Size newSize = new Size(70, 60);
                    //create another bitmap object of image and newsize together
                    Bitmap newImage = new Bitmap((Image)image, newSize);

                    imageList1.Images[index] = newImage;
                }
            }
            else
            {
                editSelectedCredential.Close();

            }

            //PasswordStrength(); 
        }// allows the user to edit a credential 


        private void RemoveCredential()
        {
            int index = lvUserCredentials.SelectedIndices[0];
            string message = string.Format("Are you sure you want to remove this selected credential {0} from your account ", lvUserCredentials.SelectedItems[0].SubItems[1].Text);
            if (MessageBox.Show(message, "Delete Credential", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                lblRemove.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
                userCredentials.GetCredential(index).Item1.RemoveCredential(index);
                lvUserCredentials.SelectedItems[0].Remove();
                imageList1.Images.RemoveAt(index);
                RecalImageListIndex();
            }
            RecolourListView();
        }

        private void RemoveMultipleCredentials()
        {
            string message = string.Format("Are you sure you want to remove the {0} selected credentials from your account?", lvUserCredentials.SelectedItems.Count);

            if (MessageBox.Show(message, "Delete Credentials", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (var selectedItem in lvUserCredentials.SelectedItems)
                {
                    userCredentials.GetCredential(lvUserCredentials.SelectedIndices[0]).Item1.RemoveCredential(lvUserCredentials.SelectedIndices[0]);

                    imageList1.Images.RemoveAt(lvUserCredentials.SelectedIndices[0]);

                    lvUserCredentials.SelectedItems[0].Remove();
                    RecalImageListIndex();//calibration of image indexes must take place here
                }

            }
            RecolourListView();
        }

        private bool Logout()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (dialogResult == DialogResult.Yes);
        } // Asks the user if they really want to log out, if they so system exit is called

        private void RecalImageListIndex()
        {
            int i = 0;
            while (i < lvUserCredentials.Items.Count)
            {
                if (i + 1 >= lvUserCredentials.Items.Count) //break if current index plus 1 is equal or more than total count
                    break;
                else
                {
                    if (i == 0 && lvUserCredentials.Items[i].ImageIndex > 0) // if image index is 0 and item at index 0 image index is greater than 0 then it is wrong. both must be 0
                    {
                        lvUserCredentials.Items[i].ImageIndex--;
                    }
                    if (lvUserCredentials.Items[i].ImageIndex == lvUserCredentials.Items[i + 1].ImageIndex - 2) // if image index at i is euqal to the index of ((i + 1)- 2) it is wrong image index at i must be i and image index at i + 1 must be i + 1..
                    {
                        lvUserCredentials.Items[i + 1].ImageIndex--;
                    }
                    if (lvUserCredentials.Items[i].ImageIndex == lvUserCredentials.Items[i + 1].ImageIndex) // if the image index at i is equal to the image index at i + 1 it is wrong
                    {
                        lvUserCredentials.Items[i].ImageIndex--;
                    }
                }

                i++;
            }
        } // RE CALIBRATES IMAGE INDEX SO ALL IMAGES ARE INDEXED RESPECTIVLY

        private void RecolourListView()
        {
            foreach (ListViewItem listItem in lvUserCredentials.Items)
            {
                listItem.BackColor = listItem.Index % 2 == 0 ? System.Drawing.ColorTranslator.FromHtml("#0D0D0D") : Color.Black;
            }
        }


        //private void PasswordStrength()
        //{
        //    Regex regexWeakPasswordAlpha = new Regex("^[A-Za-z]*$"); //just alpha characters 
        //    Regex regexWeakPasswordNumeric = new Regex("^[0-9]*$"); //just numeric 

        //    string specialCharacters = @"([<>\?\*\\\""/\|])+"; // special chars [ < > \ ? * " " / | ]
        //    Regex regexStrongPassword = new Regex(specialCharacters);

        //    int i;
        //    i = 0;
        //    while (i < passwordList.Count)
        //    {
        //        if (regexStrongPassword.IsMatch(passwordList[i]) && !regexWeakPasswordAlpha.IsMatch(passwordList[i]) && !regexWeakPasswordNumeric.IsMatch(passwordList[i]))
        //        {
        //            listView1.Items[i].BackColor = Color.Green;
        //        }
        //        else if (regexWeakPasswordAlpha.IsMatch(passwordList[i]) || regexWeakPasswordNumeric.IsMatch(passwordList[i]))
        //        {
        //            listView1.Items[i].BackColor = Color.Red;
        //        }
        //        else
        //        {
        //            listView1.Items[i].BackColor = Color.Orange;
        //        }
        //        i++;
        //    }
        //}
        //no longer a password list, need to loop through all of the listview passwords instead?

        private void SetGroupBoxLabels(Label lbl)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Label)
                    if (((Label)control).Name == lblTittle.Name)
                        ((Label)control).ForeColor = ((Label)control).ForeColor;
                    else if (((Label)control).Name == lbl.Name)
                        ((Label)control).ForeColor = Color.White;
                    else
                        ((Label)control).ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            }
        }//sets and changes colour of all group box labels

        private void SetPanelLabels(Label lbl, Panel pnl)
        {

            foreach (Control control in pnl.Controls)
            {
                if (control is Label)
                    if (((Label)control).Name == lblTittle.Name || ((Label)control).Name == lblUsername.Name
                                                                || ((Label)control).Name == lblPassword.Name
                                                                || ((Label)control).Name == lblEmail.Name
                                                                || ((Label)control).Name == lblYourAccount.Name
                                                                || ((Label)control).Name == lblDateCreated.Name
                                                                || ((Label)control).Name == lblPin.Name
                                                                || ((Label)control).Name == lblActUsername.Name
                                                                || ((Label)control).Name == lblActDateCreated.Name
                                                                || ((Label)control).Name == lblActPin.Name
                                                                || ((Label)control).Name == lblTotalCredentials.Name
                                                                || ((Label)control).Name == lblActTotalCredentials.Name
                                                                || ((Label)control).Name == lblStrongPasswords.Name
                                                                )
                        ((Label)control).ForeColor = ((Label)control).ForeColor;
                    else if (((Label)control).Name == lbl.Name)
                        ((Label)control).ForeColor = Color.White;
                    else
                        ((Label)control).ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            }
        }//sets and changes colour of all corresponding panel box labels



        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        /// </summary>





        /// <summary> FORM CONTROL EVENTS
        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////


        private void lblView_Click(object sender, EventArgs e)
        {
            ValidateSelection(() => ViewCredential(), (Label)sender);

            lblView.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

            isFunctionAddAccount = true;

            ValidateSelection(() => AddCredential(), (Label)sender);

            isFunctionAddAccount = false;

            lblAdd.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            ValidateSelection(() => EditCredential(), (Label)sender);

            lblEdit.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            if (lvUserCredentials.SelectedItems.Count > 1)
            {
                removeMultiple = true;
                ValidateSelection(() => RemoveMultipleCredentials(), lblRemove);
            }
            else
                ValidateSelection(() => RemoveCredential(), lblRemove);

            lblRemove.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

            removeMultiple = false;
        }

        private void lblCredentials_Click(object sender, EventArgs e)
        {
            SetGroupBoxLabels((Label)sender);
            HidePanels(pnlCredentials);
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            SetGroupBoxLabels((Label)sender);
            HidePanels(pnlAccount);
            lblActUsername.Text = account.UserName;
            txtActPassword.Text = account.UserPassword;
            txtActEmail.Text = account.UserEmail.Trim();

            lblActDateCreated.Text = Convert.ToString(account.UserCreationDate.ToString("MM/dd/yyyy"));
            if (Convert.ToString(account.UserPin) == "0")
            {
                lblChangePin.Visible = false;
                lblSetUpPin.Visible = true;
                lblActPin.Text = "None";
            }
            else
            {
                lblActPin.Text = Convert.ToString(account.UserPin);
            }
            lblActTotalCredentials.Text = Convert.ToString(lvUserCredentials.Items.Count);
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            SetGroupBoxLabels((Label)sender);
            HidePanels(pnlSettings);
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            SetGroupBoxLabels((Label)sender);
            HidePanels(pnlAbout);
        }


        private void HidePanels(Panel pnl) // hides all panels other than the specified pnl
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Panel)
                {
                    if (control.Name != pnl.Name)
                        control.Hide();
                    else
                    {
                        control.Show();
                        control.Location = pnlCredentials.Location;
                    }
                }
            }
        }
        private void cmbAutoBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<String> listOfRandomWebsites = new List<String>();
            listOfRandomWebsites.Add("http://outlook.com");
            listOfRandomWebsites.Add("http://amazon.com");
            listOfRandomWebsites.Add("http://reddit.com");
            listOfRandomWebsites.Add("http://google.com");
            listOfRandomWebsites.Add("http://torn.com");

            switch (cmbAutoBox.SelectedIndex)
            {
                case 0:
                    AddNCredential(listOfRandomWebsites, 5);
                    break;
                case 1:
                    AddNCredential(listOfRandomWebsites, 1);
                    break;
                case 2:
                    AddNCredential(listOfRandomWebsites, 500);
                    break;
            }
        }

        private void AddNCredential(List<String> listOfWebs, int i)
        {
            Random n = new Random();
            ListViewItem item;
           
            for (int k = 0; k < i; k++)
            {
                string testNumber = k.ToString();
                Credential data = new Credential();
                data.UserID = null;
                data.UserName = testNumber;
                data.UserPassword = testNumber;
                data.Type = testNumber;
                data.PinProtection = false;
                data.DateAdded = DateTime.Now;
                data.DateModified = DateTime.Now;
                data.WebsiteAssociate = "http://google.com";
                

                data.AddCredential(account.AccountID); // inserts account into database then adds account to credential list 

                item = new ListViewItem(new[] { data.UserName + Environment.NewLine + data.WebsiteAssociate, // adds credential to list 
                                                                    data.UserName,
                                                                    data.WebsiteAssociate, 
                                                                    Convert.ToString(data.UserID), 
                                                                    data.UserPassword,
                                                                    data.Type,
                                                                    Convert.ToString(data.PinProtection),
                                                                    Convert.ToString(data.DateAdded), 
                                                                    Convert.ToString(data.DateModified) });

                lvUserCredentials.Items.Add(item);

                imageList1.Images.Add(data.GetImage(userCredentials.GetSizeOfList() - 1));
                item.ImageIndex = (lvUserCredentials.Items.Count - 1);

                RecalImageListIndex();
            }
        }
        private void NavigateToWebsite(Credential credential)
        {
            //WebBrowser webBrowser1 = new WebBrowser();
            //string URL = @"https://idpedir.dmu.ac.uk/nidp/app/login?";
            //string user = "";
            //string pass = ".";
            //string authHdr = "Authorization: Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(user + ":" + pass)) + "\r\n";

            //webBrowser1.Url = new Uri(URL);
            //webBrowser1.Navigate(URL, null, null, authHdr);
            //webBrowser1.Refresh();

            //string URLL = @"https://accounts.google.com/ServiceLogin?service=youtube";
            //string user1 = "";
            //string pass1 = ".";
            //string authHdr1 = "Authorization: Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(user1 + ":" + pass1)) + "\r\n";

            //webBrowser1.Url = new Uri(URLL);
            //webBrowser1.Navigate(URLL);

            //Color g = Color.Red;
            //webBrowser1.Document.BackColor = g;
            //var client = new CookieAwareWebClient();

            //client.BaseAddress = @"https://accounts.google.com/ServiceLogin?service=youtube";
            //var loginData = new NameValueCollection();
            //loginData.Add("login", "@.com");
            //loginData.Add("password", ".");
            //client.UploadValues("login.php", "POST", loginData);

            ////Now you are logged in and can request pages    
            //string htmlSource = client.DownloadString("index.php");
            //if (!loggedin)
            //{
            //    try
            //    {

            //        doc = webBrowser1.Document;
            //        HtmlElement username = doc.GetElementById("Email");
            //        HtmlElement passsword = doc.GetElementById("Passwd");
            //        HtmlElement submit = doc.GetElementById("signIn");
            //        if (username == null || passsword == null || submit == null)
            //            MessageBox.Show("null");

            //        username.SetAttribute("value", "@.com");
            //        passsword.SetAttribute("value", ".");
            //        submit.InvokeMember("click");
            //        loggedin = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //    finally
            //    {

            //    }
            //}
            //System.Diagnostics.Process.Start("http://" + credential.WebsiteAssociate);
            //webBrowser1.Document.
            //   lblGoToWebsite.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            ////HtmlElement password = doc.GetElementById("Password");
            ////HtmlElement submit = doc.GetElementById("submit");
            ////tester.SetAttribute("value", "");
            ////password.SetAttribute("value", ".");
            ////submit.InvokeMember("click");

            //var client = new CookieAwareWebClient();

            //client.BaseAddress = @"https://google.com";
            //var loginData = new NameValueCollection();
            //loginData.Add("login", "@");
            //loginData.Add("password", ".");
            //client.UploadValues("login.php", "POST", loginData);

            ////Now you are logged in and can request pages    
            //string htmlSource = client.DownloadString("index.php");
        }


        private void lblGoToWebsite_Click(object sender, EventArgs e)
        {
            //SetPanelLabels(lblGoToWebsite, pnlCredentials);
            ValidateSelection(() => NavigateToWebsite(userCredentials.GetCredential(lvUserCredentials.SelectedIndices[0]).Item1), lblGoToWebsite);
            int i = 0;
            while (i++ != 50000000) ;

            lblGoToWebsite.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

        }

        private void lblChangeUsername_Click(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlAccount);
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlAccount);
        }

        private void lblChangeEmail_Click(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlAccount);
        }

        private void lblDeleteAccount_Click(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlAccount);
        }

        private void lblChangePin_Click(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlAccount);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlAccount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvUserCredentials.View = View.Tile;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: lvUserCredentials.View = View.Details; break;
                case 1: lvUserCredentials.View = View.LargeIcon; break;
                case 2: lvUserCredentials.View = View.List; break;
                case 3: lvUserCredentials.View = View.SmallIcon; break;
                case 4: lvUserCredentials.View = View.Tile; break;
            }

        }

        private void lblSetUpPin_Click(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlAccount);

            string welcomeMessage = string.Format("{0} Please enter your password.", account.UserName);

            string password = Microsoft.VisualBasic.Interaction.InputBox(welcomeMessage, "Security", "");

            if (account.ComparePassword(password))
            {
                int accountPin = 0;
                string pin = Microsoft.VisualBasic.Interaction.InputBox("Please enter a 4 digit pin.", "Security", "");
                string pin2 = Microsoft.VisualBasic.Interaction.InputBox("Please enter it again.", "Security", "");

                if (Int32.TryParse(pin, out accountPin) && Int32.TryParse(pin2, out accountPin))
                {
                    if (pin == pin2)
                    {
                        account.UserPin = accountPin;
                        account.InsertPin();
                        lblSetUpPin.Visible = false;
                        lblChangePin.Visible = true;
                        lblActPin.Text = accountPin + "";
                        MessageDialog.InfoMessageBox("Pin: " + accountPin + ", successfully added to your account");
                    }
                    else
                        MessageDialog.ErrorMessageBox("The two pins do not match.");
                }
                else
                    MessageDialog.ErrorMessageBox("The pin has to be an integer value.");
            }
            else
                MessageDialog.ErrorMessageBox("Incorrect paasword, please try again.");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lvUserCredentials_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
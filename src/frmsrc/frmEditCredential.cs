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


namespace PasswordProtector
{
    public partial class frmEditCredential : Form
    {
        private Credential credential;
        private DateTime now;

        public frmEditCredential(Credential credential)
        {
            this.credential = credential;

            now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            InitializeComponent();
            
        }

        private void EditCredential_Load(object sender, EventArgs e)
        {
            txtUserName.Text = credential.UserName;
            txtPassword.Text = credential.UserPassword;
            txtWebsite.Text = credential.WebsiteAssociate;
            //PasswordStrength();
        }

        private void btnEditCredential_Click(object sender, EventArgs e)
        {
            credential.UserName = txtUserName.Text;
            credential.UserPassword = txtPassword.Text;
            credential.WebsiteAssociate = txtWebsite.Text;
            credential.DateModified = now;
        }

        //public void PasswordStrength()
        //{
        //    Regex regexWeakPasswordAlpha = new Regex("^[A-Za-z]*$"); //just alpha characters 
        //    Regex regexWeakPasswordNumeric = new Regex("^[0-9]*$"); //just numeric 

        //    string specialCharacters = @"([<>\?\*\\\""/\|])+"; // special chars [ < > \ ? * " " / | ]
        //    Regex regexStrongPassword = new Regex(specialCharacters);




        //    if (regexStrongPassword.IsMatch(data.UserPassword) && !regexWeakPasswordAlpha.IsMatch(data.UserPassword) &&
        //        !regexWeakPasswordNumeric.IsMatch(data.UserPassword))
        //        {
        //            lblPassStrength.Text = "Strong";
        //            lblPassStrength.ForeColor = Color.Green;
        //        }
        //    else if (regexWeakPasswordAlpha.IsMatch(data.UserPassword) || regexWeakPasswordNumeric.IsMatch(data.UserPassword))
        //        {
        //            lblPassStrength.Text = "Weak";
        //            lblPassStrength.ForeColor = Color.Red;
        //        }
        //        else
        //        {
        //            lblPassStrength.Text = "So So";
        //            lblPassStrength.ForeColor = Color.Orange;
        //        }

            
        //}


        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = chkShowPassword.Checked == true ? (char)0 : (char)42; ;
        }

        private void txtpinProtection_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditCredential_FormClosed(object sender, FormClosedEventArgs e)
        {
   
        }

        private void txtWebsite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

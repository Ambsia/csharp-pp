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
    public partial class frmNewCredential : Form
    {


        private Credential dataHandle;

        public frmNewCredential(Credential dataHandle)
        {
            this.dataHandle = dataHandle;
            InitializeComponent();

        }

        private void btnAddCredential_Click(object sender, EventArgs e)
        {

            //  if (account.UserPin == 0 )
            //{
            dataHandle.UserName = txtUserName.Text;
            dataHandle.UserPassword = txtPassword.Text;
            dataHandle.WebsiteAssociate = txtWebsite.Text;
            dataHandle.DateAdded = DateTime.Now;
            dataHandle.DateModified = DateTime.Now;
            // }
            //else
            //{
            //    dataHandle.PinProtection = cmbPinProtection.Text;
            //    dataHandle.Type = cmbTypeOfAccount.Text;
            //    dataHandle.UserName = txtUserName.Text;
            //    dataHandle.Password = txtPassword.Text;
            //    dataHandle.DateAdded = DateTime.Now; 
            //    dataHandle.DateModified = DateTime.Now;  
            //}



            this.Close();

        }


        private void chkShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            this.txtPassword.PasswordChar = chkShowPassword.Checked == true ? (char)0 : (char)42;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            dataHandle = null;
            this.Dispose();
        }

        private void frmNewCredential_Load(object sender, EventArgs e)
        {

        }

    }
}
//
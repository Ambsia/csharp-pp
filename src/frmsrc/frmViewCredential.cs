using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmViewCredential : Form
    {
        private Credential credential;
        private Image credentialImage;

        public frmViewCredential(Credential credential, Image credentialImage)
        {
            this.credential = credential;
            this.credentialImage = credentialImage;
            InitializeComponent();
        }

        private void ViewCredential_Load(object sender, EventArgs e)
        {
            txtUserName.Text = credential.UserName;
            txtPassword.Text = credential.UserPassword;
            txtWebsite.Text = credential.WebsiteAssociate;
            picCredentialFavicon.Image = credentialImage;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            char passwordChar = chkShowPassword.Checked == true ? (char)0 : (char)42;

            this.txtPassword.PasswordChar = passwordChar;
        }

        private void ViewCredential_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}

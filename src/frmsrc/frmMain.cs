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
using System.IO;

namespace PasswordProtector
{
    // author: Alex Boseley
    public partial class frmMain : Form
    {
        //C:\Users\Alex\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database Files\Database.mdf
        //SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Database FilesDatabase.mdf;Integrated Security=True");
        //SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Alex\Documents\Visual Studio 2012\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database Files\Database.mdf;Integrated Security=True");
        //public static SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Database Files\Database.mdf;Integrated Security=True");
        
        //public static SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\TEST\WindowsFormsApplication1\WindowsFormsApplication1\Database Files\Database.mdf;Integrated Security=True");
        // public static SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\TEST\WindowsFormsApplication1\;Integrated Security=True");

        //public static SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=I:\TEST\WindowsFormsApplication1\WindowsFormsApplication1\Database Files\Database.mdf;Integrated Security=True");

        //(LocalDB)\v11.0;AttachDbFilename=


        private Account account;
        private frmDashBoard userDashBoard;
        private Validation validation;

        private Error validationError;

        private bool showPasswordOn = false;
        private bool showRegisterPasswordOn = false;

        private static SqlConnection sc = new SqlConnection("");

        public frmMain()
        {
            InitializeComponent();
            grpControlBox.Size = new Size(387, 584);
            this.Size = new Size(396, 605);

            Environment.CurrentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            DirectoryInfo info = new DirectoryInfo(".");
            lock (info)
            {
                sc.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + info.FullName + @"\src\Database Files\Database.mdf;Integrated Security=True";
            }
        }

        public static SqlConnection GetSqlConnectionString()
        {
            return sc;
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            pnlLogin.Hide();
            SetGroupBoxLabels((Label)sender);
            pnlReigster.Location = new Point(23, 179);
            pnlReigster.Show();

            showPasswordOn = false;
            showRegisterPasswordOn = false;

            this.txtPassword.PasswordChar = showPasswordOn == true ? (char)0 : (char)42;


            lblRegisterShowPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            lblShowPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            validationError = new Error("Validation Error", 0, null, DateTime.Now);

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            pnlReigster.Hide();
            SetGroupBoxLabels((Label)sender);
            pnlLogin.Location = new Point(23, 179);
            pnlLogin.Show();

            showPasswordOn = false;
            showRegisterPasswordOn = false;

            this.txtRegisterPassword.PasswordChar = showPasswordOn == true ? (char)0 : (char)42;


            lblRegisterShowPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            lblShowPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

        }

        private void lblShowPassword_Click(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlReigster);
        }


        private void lblShowPassword_Click_1(object sender, EventArgs e)
        {
            SetPanelLabels((Label)sender, pnlLogin);
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(pnlReigster);
        }


        private void lblLogin_Click_1(object sender, EventArgs e)
        {
            account = new Account(txtUsername.Text, txtPassword.Text, txtRegisterEmail.Text, DateTime.Now, 0, 0, 0);

            validation = new Validation(account);

            if (validation.EmptyFields())
            {
                MessageDialog.ErrorMessageBox("You must fill in all fields.");
            }
            else
            {
                if (account.AccountLogin())
                {
                    this.Hide();
                    
                    userDashBoard = new frmDashBoard(account);
                }
                else
                {
                    MessageDialog.ErrorMessageBox("Account can not be found, please try again.");
                }
            }
            ClearTextBoxes(pnlLogin);
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {

            account = new Account(txtRegisterUsername.Text, txtRegisterPassword.Text, txtRegisterEmail.Text, DateTime.Now, 0, 0, 0);

            validation = new Validation(account);
            if (validation.EmptyFields())
            {
                MessageDialog.ErrorMessageBox("You must fill in all fields.");
            }
            else
            {
                if (validation.PasswordContainUsername())
                {
                    MessageDialog.ErrorMessageBox("Your password must not contain your username");
                }
                else
                {
                    if (validation.PasswordStrength() == 0)
                    {
                        MessageDialog.ErrorMessageBox("Your password must contain both alpha and numeric characters.");
                    }
                    else
                    {
                        if (validation.EmailAddressValidation())
                        {
                            if (validation.InvalidCharacters())
                            {
                                MessageDialog.ErrorMessageBox("Please use alphabetic and numeric characters only.");
                            }
                            else
                            {
                                if (validation.StringLength(account.UserName) < 5 || validation.StringLength(account.UserPassword) < 5 ||
                                    validation.StringLength(account.UserName) > 12 || validation.StringLength(account.UserPassword) > 12)
                                {
                                    MessageDialog.ErrorMessageBox("Username and password both need to between 5 and 12 characters long.");
                                }
                                else
                                {
                                    switch (validation.DuplicateUsername())
                                    {
                                        case "True": MessageDialog.ErrorMessageBox("That username is occupied, please choose another one."); break;
                                        case "False": account.CreateAccount(); break;
                                        case "Error": break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageDialog.ErrorMessageBox("Email Address incorrect format");
                        }
                    }
                }
            }
            ClearTextBoxes(this.pnlReigster);
        }

        private void ClearTextBoxes(Panel pnl)
        {
            foreach (Control control in pnl.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }


        private void SetPanelLabels(Label lbl, Panel pnl)
        {
            foreach (Control control in pnl.Controls)
            {
                if (control is Label)
                {
                    if (((Label)control).Name == lblRegisterShowPassword.Name)
                    {
                        if (showRegisterPasswordOn == false)
                        {
                            ((Label)control).ForeColor = Color.White;
                            showRegisterPasswordOn = true;
                        }
                        else
                        {
                            ((Label)control).ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
                            showRegisterPasswordOn = false;
                        }
                        this.txtRegisterPassword.PasswordChar = showRegisterPasswordOn == true ? (char)0 : (char)42;
                    }
                    if (((Label)control).Name == lblShowPassword.Name)
                    {
                        if (showPasswordOn == false)
                        {
                            ((Label)control).ForeColor = Color.White;
                            showPasswordOn = true;

                        }
                        else
                        {
                            ((Label)control).ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");
                            showPasswordOn = false;
                        }
                        this.txtPassword.PasswordChar = showPasswordOn == true ? (char)0 : (char)42;
                    }
                }
            }


        }

        private void SetGroupBoxLabels(Label lbl)
        {
            foreach (Control control in grpControlBox.Controls)
            {
                if (control is Label)
                {
                    if (((Label)control).Name == lblTittle.Name)
                    {
                        ((Label)control).ForeColor = ((Label)control).ForeColor;
                    }
                    else if (((Label)control).Name == lbl.Name)
                    {
                        ((Label)control).ForeColor = Color.White;
                    }
                    else
                        ((Label)control).ForeColor = System.Drawing.ColorTranslator.FromHtml("#404040");

                }
            }
        }

        private void lblClear_Click1(object sender, EventArgs e)
        {
            ClearTextBoxes(pnlLogin);
        }

        private void grpControlBox_Enter(object sender, EventArgs e)
        {

        }

    }
}

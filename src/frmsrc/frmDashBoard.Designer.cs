namespace WindowsFormsApplication1
{
    partial class frmDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTittle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAboutTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.lblSetUpPin = new System.Windows.Forms.Label();
            this.txtActEmail = new System.Windows.Forms.TextBox();
            this.txtActPassword = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblPasswordGen = new System.Windows.Forms.Label();
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.lblChangePin = new System.Windows.Forms.Label();
            this.lblChangeEmail = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.lblChangeUsername = new System.Windows.Forms.Label();
            this.lblActPin = new System.Windows.Forms.Label();
            this.lblActTotalCredentials = new System.Windows.Forms.Label();
            this.lblActDateCreated = new System.Windows.Forms.Label();
            this.lblActUsername = new System.Windows.Forms.Label();
            this.lblTotalCredentials = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStrongPasswords = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblYourAccount = new System.Windows.Forms.Label();
            this.cmbAutoBox = new System.Windows.Forms.ComboBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.pnlCredentials = new System.Windows.Forms.Panel();
            this.lblGoToWebsite = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lvUserCredentials = new System.Windows.Forms.ListView();
            this.ColUsernameNWeb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColWebsite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblView = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlCredentials.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(0, 10);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(398, 51);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Password Protector";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlAbout);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pnlSettings);
            this.groupBox1.Controls.Add(this.pnlAccount);
            this.groupBox1.Controls.Add(this.cmbAutoBox);
            this.groupBox1.Controls.Add(this.lblAbout);
            this.groupBox1.Controls.Add(this.lblSettings);
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.lblCredentials);
            this.groupBox1.Controls.Add(this.pnlCredentials);
            this.groupBox1.Controls.Add(this.lblTittle);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-2, -9);
            this.groupBox1.MinimumSize = new System.Drawing.Size(396, 577);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(1647, 577);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pnlAbout
            // 
            this.pnlAbout.Controls.Add(this.textBox1);
            this.pnlAbout.Controls.Add(this.lblAboutTitle);
            this.pnlAbout.Controls.Add(this.lblVersion);
            this.pnlAbout.Controls.Add(this.lblAuthor);
            this.pnlAbout.Location = new System.Drawing.Point(1239, 121);
            this.pnlAbout.MinimumSize = new System.Drawing.Size(356, 415);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(356, 415);
            this.pnlAbout.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(18, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 108);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "This application allows you to store credentials in a safe environment, locally u" +
    "sing AES 256 encryption to keep your credentials safe.";
            // 
            // lblAboutTitle
            // 
            this.lblAboutTitle.AutoSize = true;
            this.lblAboutTitle.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutTitle.ForeColor = System.Drawing.Color.White;
            this.lblAboutTitle.Location = new System.Drawing.Point(124, 5);
            this.lblAboutTitle.Name = "lblAboutTitle";
            this.lblAboutTitle.Size = new System.Drawing.Size(107, 46);
            this.lblAboutTitle.TabIndex = 10;
            this.lblAboutTitle.Text = "About";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(13, 252);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(102, 25);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Vesion: v1.0";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(13, 212);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(167, 25);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Author: Alex Boseley";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Details",
            "Large Icon",
            "List",
            "Small Icon",
            "Tile"});
            this.comboBox1.Location = new System.Drawing.Point(24, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Location = new System.Drawing.Point(833, 152);
            this.pnlSettings.MinimumSize = new System.Drawing.Size(356, 415);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(356, 415);
            this.pnlSettings.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(91, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "settings panel";
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.lblSetUpPin);
            this.pnlAccount.Controls.Add(this.txtActEmail);
            this.pnlAccount.Controls.Add(this.txtActPassword);
            this.pnlAccount.Controls.Add(this.lblPin);
            this.pnlAccount.Controls.Add(this.lblPasswordGen);
            this.pnlAccount.Controls.Add(this.lblDeleteAccount);
            this.pnlAccount.Controls.Add(this.lblChangePin);
            this.pnlAccount.Controls.Add(this.lblChangeEmail);
            this.pnlAccount.Controls.Add(this.lblChangePassword);
            this.pnlAccount.Controls.Add(this.lblChangeUsername);
            this.pnlAccount.Controls.Add(this.lblActPin);
            this.pnlAccount.Controls.Add(this.lblActTotalCredentials);
            this.pnlAccount.Controls.Add(this.lblActDateCreated);
            this.pnlAccount.Controls.Add(this.lblActUsername);
            this.pnlAccount.Controls.Add(this.lblTotalCredentials);
            this.pnlAccount.Controls.Add(this.lblDateCreated);
            this.pnlAccount.Controls.Add(this.lblPassword);
            this.pnlAccount.Controls.Add(this.lblEmail);
            this.pnlAccount.Controls.Add(this.lblStrongPasswords);
            this.pnlAccount.Controls.Add(this.lblUsername);
            this.pnlAccount.Controls.Add(this.lblYourAccount);
            this.pnlAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlAccount.Location = new System.Drawing.Point(420, 154);
            this.pnlAccount.MinimumSize = new System.Drawing.Size(356, 415);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(356, 415);
            this.pnlAccount.TabIndex = 6;
            // 
            // lblSetUpPin
            // 
            this.lblSetUpPin.AutoSize = true;
            this.lblSetUpPin.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetUpPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSetUpPin.Location = new System.Drawing.Point(247, 172);
            this.lblSetUpPin.Name = "lblSetUpPin";
            this.lblSetUpPin.Size = new System.Drawing.Size(62, 25);
            this.lblSetUpPin.TabIndex = 17;
            this.lblSetUpPin.Text = "Set Up";
            this.lblSetUpPin.Visible = false;
            this.lblSetUpPin.Click += new System.EventHandler(this.lblSetUpPin_Click);
            // 
            // txtActEmail
            // 
            this.txtActEmail.BackColor = System.Drawing.Color.Black;
            this.txtActEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActEmail.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txtActEmail.ForeColor = System.Drawing.Color.White;
            this.txtActEmail.HideSelection = false;
            this.txtActEmail.Location = new System.Drawing.Point(129, 140);
            this.txtActEmail.Name = "txtActEmail";
            this.txtActEmail.ReadOnly = true;
            this.txtActEmail.Size = new System.Drawing.Size(117, 24);
            this.txtActEmail.TabIndex = 16;
            // 
            // txtActPassword
            // 
            this.txtActPassword.BackColor = System.Drawing.Color.Black;
            this.txtActPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActPassword.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txtActPassword.ForeColor = System.Drawing.Color.White;
            this.txtActPassword.Location = new System.Drawing.Point(129, 107);
            this.txtActPassword.Name = "txtActPassword";
            this.txtActPassword.PasswordChar = '*';
            this.txtActPassword.ReadOnly = true;
            this.txtActPassword.Size = new System.Drawing.Size(117, 24);
            this.txtActPassword.TabIndex = 14;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.ForeColor = System.Drawing.Color.White;
            this.lblPin.Location = new System.Drawing.Point(78, 172);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(40, 25);
            this.lblPin.TabIndex = 13;
            this.lblPin.Text = "Pin:";
            // 
            // lblPasswordGen
            // 
            this.lblPasswordGen.AutoSize = true;
            this.lblPasswordGen.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblPasswordGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPasswordGen.Location = new System.Drawing.Point(86, 372);
            this.lblPasswordGen.Name = "lblPasswordGen";
            this.lblPasswordGen.Size = new System.Drawing.Size(199, 30);
            this.lblPasswordGen.TabIndex = 12;
            this.lblPasswordGen.Text = "Password Generator";
            this.lblPasswordGen.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.lblDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDeleteAccount.Location = new System.Drawing.Point(162, 207);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(156, 30);
            this.lblDeleteAccount.TabIndex = 12;
            this.lblDeleteAccount.Text = "Delete Account";
            this.lblDeleteAccount.Click += new System.EventHandler(this.lblDeleteAccount_Click);
            // 
            // lblChangePin
            // 
            this.lblChangePin.AutoSize = true;
            this.lblChangePin.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChangePin.Location = new System.Drawing.Point(247, 172);
            this.lblChangePin.Name = "lblChangePin";
            this.lblChangePin.Size = new System.Drawing.Size(71, 25);
            this.lblChangePin.TabIndex = 12;
            this.lblChangePin.Text = "Change";
            this.lblChangePin.Click += new System.EventHandler(this.lblChangePin_Click);
            // 
            // lblChangeEmail
            // 
            this.lblChangeEmail.AutoSize = true;
            this.lblChangeEmail.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChangeEmail.Location = new System.Drawing.Point(247, 139);
            this.lblChangeEmail.Name = "lblChangeEmail";
            this.lblChangeEmail.Size = new System.Drawing.Size(71, 25);
            this.lblChangeEmail.TabIndex = 12;
            this.lblChangeEmail.Text = "Change";
            this.lblChangeEmail.Click += new System.EventHandler(this.lblChangeEmail_Click);
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChangePassword.Location = new System.Drawing.Point(247, 106);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(71, 25);
            this.lblChangePassword.TabIndex = 12;
            this.lblChangePassword.Text = "Change";
            this.lblChangePassword.Click += new System.EventHandler(this.lblChangePassword_Click);
            // 
            // lblChangeUsername
            // 
            this.lblChangeUsername.AutoSize = true;
            this.lblChangeUsername.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChangeUsername.Location = new System.Drawing.Point(247, 73);
            this.lblChangeUsername.Name = "lblChangeUsername";
            this.lblChangeUsername.Size = new System.Drawing.Size(71, 25);
            this.lblChangeUsername.TabIndex = 12;
            this.lblChangeUsername.Text = "Change";
            this.lblChangeUsername.Click += new System.EventHandler(this.lblChangeUsername_Click);
            // 
            // lblActPin
            // 
            this.lblActPin.AutoSize = true;
            this.lblActPin.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActPin.ForeColor = System.Drawing.Color.White;
            this.lblActPin.Location = new System.Drawing.Point(124, 172);
            this.lblActPin.Name = "lblActPin";
            this.lblActPin.Size = new System.Drawing.Size(32, 25);
            this.lblActPin.TabIndex = 11;
            this.lblActPin.Text = ".....";
            // 
            // lblActTotalCredentials
            // 
            this.lblActTotalCredentials.AutoSize = true;
            this.lblActTotalCredentials.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActTotalCredentials.ForeColor = System.Drawing.Color.White;
            this.lblActTotalCredentials.Location = new System.Drawing.Point(162, 253);
            this.lblActTotalCredentials.Name = "lblActTotalCredentials";
            this.lblActTotalCredentials.Size = new System.Drawing.Size(32, 25);
            this.lblActTotalCredentials.TabIndex = 11;
            this.lblActTotalCredentials.Text = ".....";
            // 
            // lblActDateCreated
            // 
            this.lblActDateCreated.AutoSize = true;
            this.lblActDateCreated.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActDateCreated.ForeColor = System.Drawing.Color.White;
            this.lblActDateCreated.Location = new System.Drawing.Point(162, 341);
            this.lblActDateCreated.Name = "lblActDateCreated";
            this.lblActDateCreated.Size = new System.Drawing.Size(32, 25);
            this.lblActDateCreated.TabIndex = 11;
            this.lblActDateCreated.Text = ".....";
            // 
            // lblActUsername
            // 
            this.lblActUsername.AutoSize = true;
            this.lblActUsername.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActUsername.ForeColor = System.Drawing.Color.White;
            this.lblActUsername.Location = new System.Drawing.Point(124, 73);
            this.lblActUsername.Name = "lblActUsername";
            this.lblActUsername.Size = new System.Drawing.Size(32, 25);
            this.lblActUsername.TabIndex = 11;
            this.lblActUsername.Text = ".....";
            // 
            // lblTotalCredentials
            // 
            this.lblTotalCredentials.AutoSize = true;
            this.lblTotalCredentials.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredentials.ForeColor = System.Drawing.Color.White;
            this.lblTotalCredentials.Location = new System.Drawing.Point(14, 253);
            this.lblTotalCredentials.Name = "lblTotalCredentials";
            this.lblTotalCredentials.Size = new System.Drawing.Size(142, 25);
            this.lblTotalCredentials.TabIndex = 10;
            this.lblTotalCredentials.Text = "Total Credentials:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.ForeColor = System.Drawing.Color.White;
            this.lblDateCreated.Location = new System.Drawing.Point(41, 341);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(115, 25);
            this.lblDateCreated.TabIndex = 10;
            this.lblDateCreated.Text = "Date Created:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(31, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 25);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(61, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 25);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblStrongPasswords
            // 
            this.lblStrongPasswords.AutoSize = true;
            this.lblStrongPasswords.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrongPasswords.ForeColor = System.Drawing.Color.White;
            this.lblStrongPasswords.Location = new System.Drawing.Point(7, 287);
            this.lblStrongPasswords.Name = "lblStrongPasswords";
            this.lblStrongPasswords.Size = new System.Drawing.Size(149, 25);
            this.lblStrongPasswords.TabIndex = 10;
            this.lblStrongPasswords.Text = "Strong Passwords:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(25, 73);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 25);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username:";
            // 
            // lblYourAccount
            // 
            this.lblYourAccount.AutoSize = true;
            this.lblYourAccount.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAccount.ForeColor = System.Drawing.Color.White;
            this.lblYourAccount.Location = new System.Drawing.Point(74, 1);
            this.lblYourAccount.Name = "lblYourAccount";
            this.lblYourAccount.Size = new System.Drawing.Size(211, 46);
            this.lblYourAccount.TabIndex = 9;
            this.lblYourAccount.Text = "Your Account";
            // 
            // cmbAutoBox
            // 
            this.cmbAutoBox.FormattingEnabled = true;
            this.cmbAutoBox.Items.AddRange(new object[] {
            "Add 5 Credentials",
            "Add 1 Credential",
            "Add 500 Credentials"});
            this.cmbAutoBox.Location = new System.Drawing.Point(179, 78);
            this.cmbAutoBox.Name = "cmbAutoBox";
            this.cmbAutoBox.Size = new System.Drawing.Size(150, 21);
            this.cmbAutoBox.TabIndex = 5;
            this.cmbAutoBox.SelectionChangeCommitted += new System.EventHandler(this.cmbAutoBox_SelectionChangeCommitted);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAbout.Location = new System.Drawing.Point(296, 121);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(64, 28);
            this.lblAbout.TabIndex = 4;
            this.lblAbout.Text = "About";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSettings.Location = new System.Drawing.Point(212, 121);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(78, 28);
            this.lblSettings.TabIndex = 4;
            this.lblSettings.Text = "Settings";
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAccount.Location = new System.Drawing.Point(124, 121);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(82, 28);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "Account";
            this.lblAccount.Click += new System.EventHandler(this.lblAccount_Click);
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredentials.ForeColor = System.Drawing.Color.White;
            this.lblCredentials.Location = new System.Drawing.Point(13, 121);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(105, 28);
            this.lblCredentials.TabIndex = 4;
            this.lblCredentials.Text = "Credentails";
            this.lblCredentials.Click += new System.EventHandler(this.lblCredentials_Click);
            // 
            // pnlCredentials
            // 
            this.pnlCredentials.Controls.Add(this.lblGoToWebsite);
            this.pnlCredentials.Controls.Add(this.lblEdit);
            this.pnlCredentials.Controls.Add(this.lvUserCredentials);
            this.pnlCredentials.Controls.Add(this.lblRemove);
            this.pnlCredentials.Controls.Add(this.lblView);
            this.pnlCredentials.Controls.Add(this.lblAdd);
            this.pnlCredentials.Location = new System.Drawing.Point(10, 152);
            this.pnlCredentials.MinimumSize = new System.Drawing.Size(356, 415);
            this.pnlCredentials.Name = "pnlCredentials";
            this.pnlCredentials.Size = new System.Drawing.Size(356, 415);
            this.pnlCredentials.TabIndex = 3;
            // 
            // lblGoToWebsite
            // 
            this.lblGoToWebsite.AutoSize = true;
            this.lblGoToWebsite.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoToWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGoToWebsite.Location = new System.Drawing.Point(113, 343);
            this.lblGoToWebsite.Name = "lblGoToWebsite";
            this.lblGoToWebsite.Size = new System.Drawing.Size(144, 30);
            this.lblGoToWebsite.TabIndex = 29;
            this.lblGoToWebsite.Text = "Take me here!";
            this.lblGoToWebsite.Click += new System.EventHandler(this.lblGoToWebsite_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEdit.Location = new System.Drawing.Point(178, 374);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(48, 30);
            this.lblEdit.TabIndex = 28;
            this.lblEdit.Text = "Edit";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // lvUserCredentials
            // 
            this.lvUserCredentials.BackColor = System.Drawing.Color.Black;
            this.lvUserCredentials.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvUserCredentials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColUsernameNWeb,
            this.ColUsername,
            this.ColWebsite,
            this.ColID,
            this.ColPassword,
            this.ColType,
            this.ColPin,
            this.ColDateAdded,
            this.ColDateModified});
            this.lvUserCredentials.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lvUserCredentials.ForeColor = System.Drawing.Color.White;
            this.lvUserCredentials.FullRowSelect = true;
            this.lvUserCredentials.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvUserCredentials.LargeImageList = this.imageList1;
            this.lvUserCredentials.Location = new System.Drawing.Point(3, 3);
            this.lvUserCredentials.Name = "lvUserCredentials";
            this.lvUserCredentials.Size = new System.Drawing.Size(353, 315);
            this.lvUserCredentials.SmallImageList = this.imageList1;
            this.lvUserCredentials.TabIndex = 25;
            this.lvUserCredentials.UseCompatibleStateImageBehavior = false;
            this.lvUserCredentials.View = System.Windows.Forms.View.Details;
            this.lvUserCredentials.SelectedIndexChanged += new System.EventHandler(this.lvUserCredentials_SelectedIndexChanged);
            // 
            // ColUsernameNWeb
            // 
            this.ColUsernameNWeb.Text = "Username N Web";
            this.ColUsernameNWeb.Width = 336;
            // 
            // ColUsername
            // 
            this.ColUsername.Text = "Username";
            // 
            // ColWebsite
            // 
            this.ColWebsite.Text = "Website";
            // 
            // ColID
            // 
            this.ColID.Text = "Id";
            // 
            // ColPassword
            // 
            this.ColPassword.Text = "Password";
            // 
            // ColType
            // 
            this.ColType.Text = "Type";
            // 
            // ColPin
            // 
            this.ColPin.Text = "Pin";
            // 
            // ColDateAdded
            // 
            this.ColDateAdded.Text = "Date Added";
            // 
            // ColDateModified
            // 
            this.ColDateModified.Text = "Date Modified";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(46, 46);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRemove.Location = new System.Drawing.Point(255, 374);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(87, 30);
            this.lblRemove.TabIndex = 28;
            this.lblRemove.Text = "Remove";
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblView.Location = new System.Drawing.Point(12, 374);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(57, 30);
            this.lblView.TabIndex = 28;
            this.lblView.Text = "View";
            this.lblView.Click += new System.EventHandler(this.lblView_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAdd.Location = new System.Drawing.Point(94, 374);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(51, 30);
            this.lblAdd.TabIndex = 28;
            this.lblAdd.Text = "Add";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 567);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(396, 605);
            this.Name = "frmDashBoard";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Password Protector 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashBoard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.pnlCredentials.ResumeLayout(false);
            this.pnlCredentials.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlCredentials;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblCredentials;
        private System.Windows.Forms.ListView lvUserCredentials;
        private System.Windows.Forms.ColumnHeader ColUsernameNWeb;
        private System.Windows.Forms.ColumnHeader ColWebsite;
        private System.Windows.Forms.ColumnHeader ColID;
        private System.Windows.Forms.ColumnHeader ColPassword;
        private System.Windows.Forms.ColumnHeader ColType;
        private System.Windows.Forms.ColumnHeader ColPin;
        private System.Windows.Forms.ColumnHeader ColDateAdded;
        private System.Windows.Forms.ColumnHeader ColDateModified;
        private System.Windows.Forms.ColumnHeader ColUsername;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGoToWebsite;
        private System.Windows.Forms.Label lblChangeEmail;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Label lblChangeUsername;
        private System.Windows.Forms.Label lblActDateCreated;
        private System.Windows.Forms.Label lblActUsername;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblYourAccount;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblChangePin;
        private System.Windows.Forms.Label lblActPin;
        private System.Windows.Forms.TextBox txtActPassword;
        private System.Windows.Forms.Label lblPasswordGen;
        private System.Windows.Forms.Label lblDeleteAccount;
        private System.Windows.Forms.Label lblActTotalCredentials;
        private System.Windows.Forms.Label lblTotalCredentials;
        private System.Windows.Forms.Label lblStrongPasswords;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtActEmail;
        private System.Windows.Forms.Label lblSetUpPin;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAboutTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cmbAutoBox;
    }
}
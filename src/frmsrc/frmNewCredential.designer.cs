namespace WindowsFormsApplication1
{
    partial class frmNewCredential
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAddCredential = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAddNewCredential = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(128, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(138, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(128, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(138, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(18, 51);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(104, 15);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username/Email: ";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // btnAddCredential
            // 
            this.btnAddCredential.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCredential.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddCredential.Location = new System.Drawing.Point(21, 140);
            this.btnAddCredential.Name = "btnAddCredential";
            this.btnAddCredential.Size = new System.Drawing.Size(124, 25);
            this.btnAddCredential.TabIndex = 4;
            this.btnAddCredential.Text = "Add new credential";
            this.btnAddCredential.UseVisualStyleBackColor = true;
            this.btnAddCredential.Click += new System.EventHandler(this.btnAddCredential_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(272, 70);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(103, 25);
            this.chkShowPassword.TabIndex = 5;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckStateChanged += new System.EventHandler(this.chkShowPassword_CheckStateChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(196, 141);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAddNewCredential
            // 
            this.lblAddNewCredential.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddNewCredential.AutoSize = true;
            this.lblAddNewCredential.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewCredential.Location = new System.Drawing.Point(106, 7);
            this.lblAddNewCredential.Name = "lblAddNewCredential";
            this.lblAddNewCredential.Size = new System.Drawing.Size(177, 26);
            this.lblAddNewCredential.TabIndex = 7;
            this.lblAddNewCredential.Text = "Add new credential";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWebsite.Location = new System.Drawing.Point(128, 101);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(138, 23);
            this.txtWebsite.TabIndex = 1;
            // 
            // lblWebsite
            // 
            this.lblWebsite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(18, 109);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(55, 15);
            this.lblWebsite.TabIndex = 1;
            this.lblWebsite.Text = "Website:";
            // 
            // NewCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(378, 178);
            this.Controls.Add(this.lblAddNewCredential);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnAddCredential);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewCredential";
            this.Text = "Password Protector 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAddCredential;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAddNewCredential;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label lblWebsite;
    }
}
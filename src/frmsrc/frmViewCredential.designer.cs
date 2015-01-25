namespace WindowsFormsApplication1
{
    partial class frmViewCredential
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
            this.lblViewCredential = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPassStrength = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.picCredentialFavicon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCredentialFavicon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewCredential
            // 
            this.lblViewCredential.AutoSize = true;
            this.lblViewCredential.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCredential.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblViewCredential.Location = new System.Drawing.Point(63, 9);
            this.lblViewCredential.Name = "lblViewCredential";
            this.lblViewCredential.Size = new System.Drawing.Size(205, 26);
            this.lblViewCredential.TabIndex = 8;
            this.lblViewCredential.Text = "Credential Information";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(27, 60);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(69, 15);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 96);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Location = new System.Drawing.Point(27, 129);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(112, 15);
            this.lblPasswordStrength.TabIndex = 9;
            this.lblPasswordStrength.Text = "Password Strength:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(102, 57);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(157, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 93);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(157, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(265, 91);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(103, 25);
            this.chkShowPassword.TabIndex = 10;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            this.chkShowPassword.CheckStateChanged += new System.EventHandler(this.chkShowPassword_CheckStateChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnClose.Location = new System.Drawing.Point(122, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 24);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblPassStrength
            // 
            this.lblPassStrength.AutoSize = true;
            this.lblPassStrength.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPassStrength.Location = new System.Drawing.Point(145, 129);
            this.lblPassStrength.Name = "lblPassStrength";
            this.lblPassStrength.Size = new System.Drawing.Size(25, 15);
            this.lblPassStrength.TabIndex = 12;
            this.lblPassStrength.Text = "......";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Location = new System.Drawing.Point(102, 158);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(117, 23);
            this.txtWebsite.TabIndex = 13;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(27, 161);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(55, 15);
            this.lblWebsite.TabIndex = 14;
            this.lblWebsite.Text = "Website:";
            // 
            // picCredentialFavicon
            // 
            this.picCredentialFavicon.Location = new System.Drawing.Point(226, 149);
            this.picCredentialFavicon.Name = "picCredentialFavicon";
            this.picCredentialFavicon.Size = new System.Drawing.Size(34, 32);
            this.picCredentialFavicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCredentialFavicon.TabIndex = 15;
            this.picCredentialFavicon.TabStop = false;
            // 
            // ViewCredential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(378, 227);
            this.Controls.Add(this.picCredentialFavicon);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.lblPassStrength);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblViewCredential);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewCredential";
            this.Text = "Password Protector 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewCredential_FormClosed);
            this.Load += new System.EventHandler(this.ViewCredential_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCredentialFavicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewCredential;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPassStrength;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.PictureBox picCredentialFavicon;

    }
}
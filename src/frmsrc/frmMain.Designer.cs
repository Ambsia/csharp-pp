namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.grpControlBox = new System.Windows.Forms.GroupBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblShowPassword = new System.Windows.Forms.Label();
            this.lblForggotenPassword = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlReigster = new System.Windows.Forms.Panel();
            this.lblRegisterClear = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblRegisterShowPassword = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblRegisterTitle = new System.Windows.Forms.Label();
            this.grpControlBox.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlReigster.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControlBox
            // 
            this.grpControlBox.Controls.Add(this.pnlLogin);
            this.grpControlBox.Controls.Add(this.pnlReigster);
            this.grpControlBox.Controls.Add(this.lblTittle);
            this.grpControlBox.Controls.Add(this.lblLoginTitle);
            this.grpControlBox.Controls.Add(this.lblRegisterTitle);
            this.grpControlBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpControlBox.Location = new System.Drawing.Point(-2, -9);
            this.grpControlBox.Name = "grpControlBox";
            this.grpControlBox.Padding = new System.Windows.Forms.Padding(20);
            this.grpControlBox.Size = new System.Drawing.Size(800, 556);
            this.grpControlBox.TabIndex = 1;
            this.grpControlBox.TabStop = false;
            this.grpControlBox.Text = "-";
            this.grpControlBox.Enter += new System.EventHandler(this.grpControlBox_Enter);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblShowPassword);
            this.pnlLogin.Controls.Add(this.lblForggotenPassword);
            this.pnlLogin.Controls.Add(this.lblClear);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Location = new System.Drawing.Point(387, 180);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(325, 370);
            this.pnlLogin.TabIndex = 2;
            // 
            // lblShowPassword
            // 
            this.lblShowPassword.AutoSize = true;
            this.lblShowPassword.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblShowPassword.Location = new System.Drawing.Point(139, 149);
            this.lblShowPassword.Name = "lblShowPassword";
            this.lblShowPassword.Size = new System.Drawing.Size(143, 28);
            this.lblShowPassword.TabIndex = 8;
            this.lblShowPassword.Text = "Show Password";
            this.lblShowPassword.Click += new System.EventHandler(this.lblShowPassword_Click_1);
            // 
            // lblForggotenPassword
            // 
            this.lblForggotenPassword.AutoSize = true;
            this.lblForggotenPassword.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForggotenPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblForggotenPassword.Location = new System.Drawing.Point(55, 335);
            this.lblForggotenPassword.Name = "lblForggotenPassword";
            this.lblForggotenPassword.Size = new System.Drawing.Size(205, 30);
            this.lblForggotenPassword.TabIndex = 0;
            this.lblForggotenPassword.Text = "Forgotten Password?";
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.Location = new System.Drawing.Point(202, 268);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(90, 45);
            this.lblClear.TabIndex = 7;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click1);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(32, 268);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(95, 45);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(126, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(166, 30);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(126, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(166, 30);
            this.txtUsername.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username";
            // 
            // pnlReigster
            // 
            this.pnlReigster.Controls.Add(this.lblRegisterClear);
            this.pnlReigster.Controls.Add(this.lblCreate);
            this.pnlReigster.Controls.Add(this.lblRegisterShowPassword);
            this.pnlReigster.Controls.Add(this.txtRegisterPassword);
            this.pnlReigster.Controls.Add(this.txtRegisterEmail);
            this.pnlReigster.Controls.Add(this.txtRegisterUsername);
            this.pnlReigster.Controls.Add(this.lblEmail);
            this.pnlReigster.Controls.Add(this.lblPassword);
            this.pnlReigster.Controls.Add(this.lblUsername);
            this.pnlReigster.Location = new System.Drawing.Point(23, 179);
            this.pnlReigster.Name = "pnlReigster";
            this.pnlReigster.Size = new System.Drawing.Size(325, 370);
            this.pnlReigster.TabIndex = 4;
            // 
            // lblRegisterClear
            // 
            this.lblRegisterClear.AutoSize = true;
            this.lblRegisterClear.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterClear.Location = new System.Drawing.Point(202, 288);
            this.lblRegisterClear.Name = "lblRegisterClear";
            this.lblRegisterClear.Size = new System.Drawing.Size(90, 45);
            this.lblRegisterClear.TabIndex = 7;
            this.lblRegisterClear.Text = "Clear";
            this.lblRegisterClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(32, 288);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(128, 45);
            this.lblCreate.TabIndex = 6;
            this.lblCreate.Text = "Register";
            this.lblCreate.Click += new System.EventHandler(this.lblCreate_Click);
            // 
            // lblRegisterShowPassword
            // 
            this.lblRegisterShowPassword.AutoSize = true;
            this.lblRegisterShowPassword.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRegisterShowPassword.Location = new System.Drawing.Point(143, 210);
            this.lblRegisterShowPassword.Name = "lblRegisterShowPassword";
            this.lblRegisterShowPassword.Size = new System.Drawing.Size(143, 28);
            this.lblRegisterShowPassword.TabIndex = 5;
            this.lblRegisterShowPassword.Text = "Show Password";
            this.lblRegisterShowPassword.Click += new System.EventHandler(this.lblShowPassword_Click);
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterPassword.Location = new System.Drawing.Point(127, 160);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(166, 30);
            this.txtRegisterPassword.TabIndex = 2;
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterEmail.Location = new System.Drawing.Point(126, 96);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(166, 30);
            this.txtRegisterEmail.TabIndex = 1;
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegisterUsername.Location = new System.Drawing.Point(126, 28);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(166, 30);
            this.txtRegisterUsername.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(54, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 32);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(13, 162);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 32);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(3, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 32);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(0, 10);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(398, 51);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "Password Protector";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLoginTitle.Location = new System.Drawing.Point(214, 112);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(140, 65);
            this.lblLoginTitle.TabIndex = 1;
            this.lblLoginTitle.Text = "Login";
            this.lblLoginTitle.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblRegisterTitle
            // 
            this.lblRegisterTitle.AutoSize = true;
            this.lblRegisterTitle.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTitle.ForeColor = System.Drawing.Color.White;
            this.lblRegisterTitle.Location = new System.Drawing.Point(10, 112);
            this.lblRegisterTitle.Name = "lblRegisterTitle";
            this.lblRegisterTitle.Size = new System.Drawing.Size(189, 65);
            this.lblRegisterTitle.TabIndex = 0;
            this.lblRegisterTitle.Text = "Register";
            this.lblRegisterTitle.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(893, 567);
            this.Controls.Add(this.grpControlBox);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.Text = "Password Protector 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpControlBox.ResumeLayout(false);
            this.grpControlBox.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlReigster.ResumeLayout(false);
            this.pnlReigster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpControlBox;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.Panel pnlReigster;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label lblRegisterShowPassword;
        private System.Windows.Forms.Label lblCreate;
        private System.Windows.Forms.Label lblRegisterClear;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblForggotenPassword;
        private System.Windows.Forms.Label lblShowPassword;

    }
}


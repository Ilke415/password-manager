
namespace PresentationLayer {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox_MinimalChar = new System.Windows.Forms.CheckBox();
            this.checkBox_SpecialChar = new System.Windows.Forms.CheckBox();
            this.checkBox_Number = new System.Windows.Forms.CheckBox();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.checkBox_Uppercase = new System.Windows.Forms.CheckBox();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Registration = new System.Windows.Forms.Panel();
            this.panel_4 = new System.Windows.Forms.Panel();
            this.panel_3 = new System.Windows.Forms.Panel();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.button_GeneratePassword = new System.Windows.Forms.Button();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.panel_LogIn = new System.Windows.Forms.Panel();
            this.label_PasswordLogin = new System.Windows.Forms.Label();
            this.label_EmailLogin = new System.Windows.Forms.Label();
            this.textBox_EmailLogin = new System.Windows.Forms.TextBox();
            this.textBox_PasswordLogin = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_RegisterChoose = new System.Windows.Forms.Button();
            this.button_LogInChoose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel_Registration.SuspendLayout();
            this.panel_LogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_MinimalChar
            // 
            this.checkBox_MinimalChar.AutoSize = true;
            this.checkBox_MinimalChar.Enabled = false;
            this.checkBox_MinimalChar.Location = new System.Drawing.Point(30, 188);
            this.checkBox_MinimalChar.Name = "checkBox_MinimalChar";
            this.checkBox_MinimalChar.Size = new System.Drawing.Size(129, 17);
            this.checkBox_MinimalChar.TabIndex = 23;
            this.checkBox_MinimalChar.Text = "At least 12 characters";
            this.checkBox_MinimalChar.UseVisualStyleBackColor = true;
            // 
            // checkBox_SpecialChar
            // 
            this.checkBox_SpecialChar.AutoSize = true;
            this.checkBox_SpecialChar.Enabled = false;
            this.checkBox_SpecialChar.Location = new System.Drawing.Point(30, 142);
            this.checkBox_SpecialChar.Name = "checkBox_SpecialChar";
            this.checkBox_SpecialChar.Size = new System.Drawing.Size(154, 17);
            this.checkBox_SpecialChar.TabIndex = 21;
            this.checkBox_SpecialChar.Text = "At least 1 special character";
            this.checkBox_SpecialChar.UseVisualStyleBackColor = true;
            // 
            // checkBox_Number
            // 
            this.checkBox_Number.AutoSize = true;
            this.checkBox_Number.Enabled = false;
            this.checkBox_Number.Location = new System.Drawing.Point(30, 165);
            this.checkBox_Number.Name = "checkBox_Number";
            this.checkBox_Number.Size = new System.Drawing.Size(108, 17);
            this.checkBox_Number.TabIndex = 20;
            this.checkBox_Number.Text = "At least 1 number";
            this.checkBox_Number.UseVisualStyleBackColor = true;
            // 
            // button_SignUp
            // 
            this.button_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_SignUp.FlatAppearance.BorderSize = 2;
            this.button_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SignUp.Location = new System.Drawing.Point(79, 268);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(161, 46);
            this.button_SignUp.TabIndex = 19;
            this.button_SignUp.Text = "SIGN UP";
            this.button_SignUp.UseVisualStyleBackColor = true;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            this.button_SignUp.MouseEnter += new System.EventHandler(this.button_SignUp_Enter);
            this.button_SignUp.MouseLeave += new System.EventHandler(this.button_SignUp_Leave);
            // 
            // checkBox_Uppercase
            // 
            this.checkBox_Uppercase.AutoSize = true;
            this.checkBox_Uppercase.Enabled = false;
            this.checkBox_Uppercase.Location = new System.Drawing.Point(30, 119);
            this.checkBox_Uppercase.Name = "checkBox_Uppercase";
            this.checkBox_Uppercase.Size = new System.Drawing.Size(149, 17);
            this.checkBox_Uppercase.TabIndex = 18;
            this.checkBox_Uppercase.Text = "At least 1 uppercase letter";
            this.checkBox_Uppercase.UseVisualStyleBackColor = true;
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ConfirmPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(21, 222);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(273, 26);
            this.textBox_ConfirmPassword.TabIndex = 17;
            this.textBox_ConfirmPassword.Text = "Confirm Password";
            this.textBox_ConfirmPassword.Enter += new System.EventHandler(this.textBox_ConfirmPassword_Enter);
            this.textBox_ConfirmPassword.Leave += new System.EventHandler(this.textBox_ConfirmPassword_Leave);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Password.Location = new System.Drawing.Point(21, 74);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(200, 26);
            this.textBox_Password.TabIndex = 16;
            this.textBox_Password.Text = "Password";
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            this.textBox_Password.Enter += new System.EventHandler(this.textBox_Password_Enter);
            this.textBox_Password.Leave += new System.EventHandler(this.textBox_Password_Leave);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Email.Location = new System.Drawing.Point(21, 28);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(273, 26);
            this.textBox_Email.TabIndex = 15;
            this.textBox_Email.Text = "Email";
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            this.textBox_Email.Enter += new System.EventHandler(this.textBox_Email_Enter);
            this.textBox_Email.Leave += new System.EventHandler(this.textBox_Email_Leave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 496);
            this.panel1.TabIndex = 12;
            // 
            // panel_Registration
            // 
            this.panel_Registration.Controls.Add(this.panel_4);
            this.panel_Registration.Controls.Add(this.panel_3);
            this.panel_Registration.Controls.Add(this.panel_2);
            this.panel_Registration.Controls.Add(this.panel_1);
            this.panel_Registration.Controls.Add(this.label_ConfirmPassword);
            this.panel_Registration.Controls.Add(this.button_GeneratePassword);
            this.panel_Registration.Controls.Add(this.label_Password);
            this.panel_Registration.Controls.Add(this.label_Email);
            this.panel_Registration.Controls.Add(this.checkBox_MinimalChar);
            this.panel_Registration.Controls.Add(this.textBox_Email);
            this.panel_Registration.Controls.Add(this.textBox_ConfirmPassword);
            this.panel_Registration.Controls.Add(this.checkBox_SpecialChar);
            this.panel_Registration.Controls.Add(this.textBox_Password);
            this.panel_Registration.Controls.Add(this.checkBox_Number);
            this.panel_Registration.Controls.Add(this.button_SignUp);
            this.panel_Registration.Controls.Add(this.checkBox_Uppercase);
            this.panel_Registration.Location = new System.Drawing.Point(306, 108);
            this.panel_Registration.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Registration.Name = "panel_Registration";
            this.panel_Registration.Size = new System.Drawing.Size(313, 379);
            this.panel_Registration.TabIndex = 24;
            this.panel_Registration.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel_4
            // 
            this.panel_4.BackColor = System.Drawing.Color.White;
            this.panel_4.Location = new System.Drawing.Point(171, 103);
            this.panel_4.Margin = new System.Windows.Forms.Padding(0);
            this.panel_4.Name = "panel_4";
            this.panel_4.Size = new System.Drawing.Size(50, 10);
            this.panel_4.TabIndex = 30;
            // 
            // panel_3
            // 
            this.panel_3.BackColor = System.Drawing.Color.White;
            this.panel_3.Location = new System.Drawing.Point(121, 103);
            this.panel_3.Margin = new System.Windows.Forms.Padding(0);
            this.panel_3.Name = "panel_3";
            this.panel_3.Size = new System.Drawing.Size(50, 10);
            this.panel_3.TabIndex = 30;
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.White;
            this.panel_2.Location = new System.Drawing.Point(71, 103);
            this.panel_2.Margin = new System.Windows.Forms.Padding(0);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(50, 10);
            this.panel_2.TabIndex = 30;
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.White;
            this.panel_1.Location = new System.Drawing.Point(21, 103);
            this.panel_1.Margin = new System.Windows.Forms.Padding(0);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(50, 10);
            this.panel_1.TabIndex = 29;
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.label_ConfirmPassword.Location = new System.Drawing.Point(18, 208);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(123, 13);
            this.label_ConfirmPassword.TabIndex = 29;
            this.label_ConfirmPassword.Text = "Passwords do not match";
            this.label_ConfirmPassword.Visible = false;
            // 
            // button_GeneratePassword
            // 
            this.button_GeneratePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_GeneratePassword.FlatAppearance.BorderSize = 2;
            this.button_GeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GeneratePassword.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GeneratePassword.Location = new System.Drawing.Point(221, 74);
            this.button_GeneratePassword.Name = "button_GeneratePassword";
            this.button_GeneratePassword.Size = new System.Drawing.Size(73, 26);
            this.button_GeneratePassword.TabIndex = 26;
            this.button_GeneratePassword.Text = "Generate";
            this.button_GeneratePassword.UseVisualStyleBackColor = true;
            this.button_GeneratePassword.Click += new System.EventHandler(this.button_GeneratePassword_Click);
            this.button_GeneratePassword.MouseEnter += new System.EventHandler(this.button_GeneratePassword_Enter);
            this.button_GeneratePassword.MouseLeave += new System.EventHandler(this.button_GeneratePassword_Leave);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.ForeColor = System.Drawing.Color.Red;
            this.label_Password.Location = new System.Drawing.Point(18, 58);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 13);
            this.label_Password.TabIndex = 25;
            this.label_Password.Text = "Invalid password";
            this.label_Password.Visible = false;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.ForeColor = System.Drawing.Color.Red;
            this.label_Email.Location = new System.Drawing.Point(18, 12);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(105, 13);
            this.label_Email.TabIndex = 24;
            this.label_Email.Text = "Invalid email address";
            this.label_Email.Visible = false;
            // 
            // panel_LogIn
            // 
            this.panel_LogIn.Controls.Add(this.label_PasswordLogin);
            this.panel_LogIn.Controls.Add(this.label_EmailLogin);
            this.panel_LogIn.Controls.Add(this.textBox_EmailLogin);
            this.panel_LogIn.Controls.Add(this.textBox_PasswordLogin);
            this.panel_LogIn.Controls.Add(this.button_LogIn);
            this.panel_LogIn.Location = new System.Drawing.Point(646, 117);
            this.panel_LogIn.Margin = new System.Windows.Forms.Padding(0);
            this.panel_LogIn.Name = "panel_LogIn";
            this.panel_LogIn.Size = new System.Drawing.Size(313, 379);
            this.panel_LogIn.TabIndex = 25;
            this.panel_LogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label_PasswordLogin
            // 
            this.label_PasswordLogin.AutoSize = true;
            this.label_PasswordLogin.ForeColor = System.Drawing.Color.Red;
            this.label_PasswordLogin.Location = new System.Drawing.Point(18, 58);
            this.label_PasswordLogin.Name = "label_PasswordLogin";
            this.label_PasswordLogin.Size = new System.Drawing.Size(86, 13);
            this.label_PasswordLogin.TabIndex = 26;
            this.label_PasswordLogin.Text = "Invalid password";
            this.label_PasswordLogin.Visible = false;
            this.label_PasswordLogin.Click += new System.EventHandler(this.label_PasswordLogin_Click);
            // 
            // label_EmailLogin
            // 
            this.label_EmailLogin.AutoSize = true;
            this.label_EmailLogin.ForeColor = System.Drawing.Color.Red;
            this.label_EmailLogin.Location = new System.Drawing.Point(18, 12);
            this.label_EmailLogin.Name = "label_EmailLogin";
            this.label_EmailLogin.Size = new System.Drawing.Size(105, 13);
            this.label_EmailLogin.TabIndex = 25;
            this.label_EmailLogin.Text = "Invalid email address";
            this.label_EmailLogin.Visible = false;
            // 
            // textBox_EmailLogin
            // 
            this.textBox_EmailLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmailLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_EmailLogin.Location = new System.Drawing.Point(21, 28);
            this.textBox_EmailLogin.Name = "textBox_EmailLogin";
            this.textBox_EmailLogin.Size = new System.Drawing.Size(273, 26);
            this.textBox_EmailLogin.TabIndex = 15;
            this.textBox_EmailLogin.Text = "Email";
            this.textBox_EmailLogin.Enter += new System.EventHandler(this.textBox_EmailLogin_Enter);
            this.textBox_EmailLogin.Leave += new System.EventHandler(this.textBox_EmailLogin_Leave);
            // 
            // textBox_PasswordLogin
            // 
            this.textBox_PasswordLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PasswordLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_PasswordLogin.Location = new System.Drawing.Point(21, 74);
            this.textBox_PasswordLogin.Name = "textBox_PasswordLogin";
            this.textBox_PasswordLogin.Size = new System.Drawing.Size(273, 26);
            this.textBox_PasswordLogin.TabIndex = 16;
            this.textBox_PasswordLogin.Text = "Password";
            this.textBox_PasswordLogin.Enter += new System.EventHandler(this.textBox_PasswordLogin_Enter);
            this.textBox_PasswordLogin.Leave += new System.EventHandler(this.textBox_PasswordLogin_Leave);
            // 
            // button_LogIn
            // 
            this.button_LogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_LogIn.FlatAppearance.BorderSize = 2;
            this.button_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogIn.ForeColor = System.Drawing.Color.Black;
            this.button_LogIn.Location = new System.Drawing.Point(83, 268);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(161, 46);
            this.button_LogIn.TabIndex = 19;
            this.button_LogIn.Text = "LOG IN";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.MouseEnter += new System.EventHandler(this.button_LogIn_Enter);
            this.button_LogIn.MouseLeave += new System.EventHandler(this.button_LogIn_Leave);
            // 
            // button_RegisterChoose
            // 
            this.button_RegisterChoose.BackColor = System.Drawing.SystemColors.Control;
            this.button_RegisterChoose.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_RegisterChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_RegisterChoose.FlatAppearance.BorderSize = 2;
            this.button_RegisterChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RegisterChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegisterChoose.ForeColor = System.Drawing.Color.Black;
            this.button_RegisterChoose.Location = new System.Drawing.Point(370, 36);
            this.button_RegisterChoose.Margin = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.button_RegisterChoose.Name = "button_RegisterChoose";
            this.button_RegisterChoose.Size = new System.Drawing.Size(92, 43);
            this.button_RegisterChoose.TabIndex = 26;
            this.button_RegisterChoose.Text = "REGISTER";
            this.button_RegisterChoose.UseVisualStyleBackColor = false;
            this.button_RegisterChoose.Click += new System.EventHandler(this.button_RegisterChoose_Click);
            // 
            // button_LogInChoose
            // 
            this.button_LogInChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_LogInChoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(85)))), ((int)(((byte)(148)))));
            this.button_LogInChoose.FlatAppearance.BorderSize = 2;
            this.button_LogInChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LogInChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogInChoose.ForeColor = System.Drawing.Color.White;
            this.button_LogInChoose.Location = new System.Drawing.Point(462, 36);
            this.button_LogInChoose.Margin = new System.Windows.Forms.Padding(0, 0, 64, 0);
            this.button_LogInChoose.Name = "button_LogInChoose";
            this.button_LogInChoose.Size = new System.Drawing.Size(92, 43);
            this.button_LogInChoose.TabIndex = 27;
            this.button_LogInChoose.Text = "LOG IN";
            this.button_LogInChoose.UseVisualStyleBackColor = false;
            this.button_LogInChoose.Click += new System.EventHandler(this.button_LogInChoose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 496);
            this.Controls.Add(this.panel_Registration);
            this.Controls.Add(this.button_RegisterChoose);
            this.Controls.Add(this.button_LogInChoose);
            this.Controls.Add(this.panel_LogIn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Registration.ResumeLayout(false);
            this.panel_Registration.PerformLayout();
            this.panel_LogIn.ResumeLayout(false);
            this.panel_LogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_MinimalChar;
        private System.Windows.Forms.CheckBox checkBox_SpecialChar;
        private System.Windows.Forms.CheckBox checkBox_Number;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.CheckBox checkBox_Uppercase;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Registration;
        private System.Windows.Forms.Panel panel_LogIn;
        private System.Windows.Forms.TextBox textBox_EmailLogin;
        private System.Windows.Forms.TextBox textBox_PasswordLogin;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_PasswordLogin;
        private System.Windows.Forms.Label label_EmailLogin;
        private System.Windows.Forms.Button button_RegisterChoose;
        private System.Windows.Forms.Button button_LogInChoose;
        private System.Windows.Forms.Button button_GeneratePassword;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Panel panel_4;
        private System.Windows.Forms.Panel panel_3;
        private System.Windows.Forms.Panel panel_2;
    }
}


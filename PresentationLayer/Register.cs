using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly IUserBusiness iUserBusiness;

        public Form1(IUserBusiness iUserBusiness)
        {
            this.iUserBusiness = iUserBusiness;
            InitializeComponent();
        }
        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_Email_Enter(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "Email")
                textBox_Email.Text = "";
            textBox_Email.ForeColor = Color.Black;
        }

        private void textBox_Email_Leave(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "")
            {
                textBox_Email.Text = "Email";
                textBox_Email.ForeColor = Color.Gray;
            }

        }

        private void textBox_Password_Enter(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "Password")
                textBox_Password.Text = "";
            textBox_Password.ForeColor = Color.Black;
            
        }
        private void textBox_Password_Leave(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.Text = "Password";
                textBox_Password.ForeColor = Color.Gray;
                textBox_Password.PasswordChar = '\0';
            }
        }
        private void textBox_ConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (textBox_ConfirmPassword.Text == "Confirm Password")
                textBox_ConfirmPassword.Text = "";
            textBox_ConfirmPassword.ForeColor = Color.Black;
            
        }
        private void textBox_ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (textBox_ConfirmPassword.Text == "")
            {
                textBox_ConfirmPassword.Text = "Confirm Password";
                textBox_ConfirmPassword.ForeColor = Color.Gray;
                textBox_ConfirmPassword.PasswordChar = '\0';
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_EmailLogin_Enter(object sender, EventArgs e)
        {
            if (textBox_EmailLogin.Text == "Email")
                textBox_EmailLogin.Text = "";
            textBox_EmailLogin.ForeColor = Color.Black;
        }

        private void textBox_EmailLogin_Leave(object sender, EventArgs e)
        {
            if (textBox_EmailLogin.Text == "")
            {
                textBox_EmailLogin.Text = "Email";
                textBox_EmailLogin.ForeColor = Color.Gray;
            }
        }

        private void textBox_PasswordLogin_Enter(object sender, EventArgs e)
        {
            if (textBox_PasswordLogin.Text == "Password")
                textBox_PasswordLogin.Text = "";
            textBox_PasswordLogin.ForeColor = Color.Black;
            
        }

        private void textBox_PasswordLogin_Leave(object sender, EventArgs e)
        {
            if (textBox_PasswordLogin.Text == "")
            {
                textBox_PasswordLogin.Text = "Password";
                textBox_PasswordLogin.ForeColor = Color.Gray;
                textBox_PasswordLogin.PasswordChar = '\0';
            }
        }

        private void label_PasswordLogin_Click(object sender, EventArgs e)
        {

        }

        private void button_SignUp_Enter(object sender, EventArgs e)
        {
            button_SignUp.BackColor = Color.FromArgb(35, 85, 148);
            button_SignUp.ForeColor = Color.White;
        }

        private void button_SignUp_Leave(object sender, EventArgs e)
        {
            button_SignUp.BackColor = Color.White;
            button_SignUp.ForeColor = Color.Black;
        }

        private void button_LogIn_Enter(object sender, EventArgs e)
        {
            button_LogIn.BackColor = Color.FromArgb(35, 85, 148);
            button_LogIn.ForeColor = Color.White;
        }

        private void button_LogIn_Leave(object sender, EventArgs e)
        {
            button_LogIn.BackColor = Color.White;
            button_LogIn.ForeColor = Color.Black;
        }

       

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_LogInChoose_Click(object sender, EventArgs e)
        {
            button_LogInChoose.BackColor = Color.FromArgb(35, 85, 148);
            button_LogInChoose.ForeColor = Color.White;
            button_RegisterChoose.BackColor = Color.White;
            button_RegisterChoose.ForeColor = Color.Black;
            panel_Registration.Visible = false;
            
            panel_LogIn.Visible = true;
            panel_LogIn.BringToFront();
        }

        private void button_RegisterChoose_Click(object sender, EventArgs e)
        {
            button_RegisterChoose.BackColor = Color.FromArgb(35, 85, 148);
            button_RegisterChoose.ForeColor = Color.White;
            button_LogInChoose.BackColor = Color.White;
            button_LogInChoose.ForeColor = Color.Black;
            panel_LogIn.Visible = false;
            panel_Registration.Visible = true;
            panel_Registration.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label_Email;
            panel_Registration.Visible = false;
            panel_LogIn.Visible = true;
          
            button_LogInChoose.PerformClick();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            int k = 0;
            string password = textBox_Password.Text;
            List<Boolean> checks = new List<Boolean>();
            checks = IsValidPassword(password);
            for (int i = 0; i < 4; i++)
            {
                bool check = checks[i];

                if (check)
                    k++;
            }
            if (k == 0)
            {
                panel_1.BackColor = Color.White;
                panel_2.BackColor = Color.White;
                panel_3.BackColor = Color.White;
                panel_4.BackColor = Color.White;
            }
            if (k > 0)

                panel_1.BackColor = Color.FromArgb(250, 54, 1);
            else
                panel_1.BackColor = Color.White;
            if (k > 1)
                panel_2.BackColor = Color.FromArgb(250, 130, 0);
            else
                panel_2.BackColor = Color.White;
            if (k > 2)
                panel_3.BackColor = Color.FromArgb(250, 213, 1);
            else
                panel_3.BackColor = Color.White;
            if (k > 3)
                panel_4.BackColor = Color.FromArgb(0, 128, 0);
            else
                panel_4.BackColor = Color.White;




           
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            string emailAddress = textBox_Email.Text;
            if (IsValidEmailAddress(emailAddress) == false)
                label_Email.Visible = true;
            if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                label_ConfirmPassword.Visible = true;
            if (textBox_Password.Text == "Password")
                label_Password.Visible = true;
            if (IsEmailAddressExist(textBox_Email.Text))
            {
                label_EmailExist.Visible = true;
                label_EmailExistLogin.Visible = true;
            }
            else
            {
                label_EmailExist.Visible = false;
                label_EmailExistLogin.Visible = false;

                string email = textBox_Email.Text.Trim();
                string password = textBox_Password.Text;

                iUserBusiness.InsertUser(password, email);

                string message = "Succesfull registration";
                MessageBox.Show(message);
            }
        }
        
        public Boolean IsValidEmailAddress(string emailAddress)
        {
            return iUserBusiness.IsValidEmailAddress(emailAddress);
        }
        public List<Boolean> IsValidPassword(string password)
        {
            return iUserBusiness.IsValidPassword(password);
        }
        public string CreateRandomPassword(int length)
        {
            return iUserBusiness.CreateRandomPassword(length);
        }
        public Boolean IsEmailAddressExist(string emailAddress)
        {
            return iUserBusiness.IsEmailAddressExist(emailAddress);
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Uppercase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_MinimalChar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_SpecialChar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Number_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowHideConfirmPassword_Click(object sender, EventArgs e)
        {
            TogglePasswordTextVisibility(new List<Button> { buttonShowHidePassword, buttonShowHideConfirmPassword }, new List<TextBox> { textBox_Password, textBox_ConfirmPassword });
        }
        private void buttonShowHidePassword_Click(object sender, EventArgs e)
        {
            TogglePasswordTextVisibility(new List<Button> { buttonShowHidePassword, buttonShowHideConfirmPassword }, new List<TextBox> { textBox_Password, textBox_ConfirmPassword });
        }
        private void label_EmailExistLogin_Click(object sender, EventArgs e)
        {

        }

        private void label_EmailExist_Click(object sender, EventArgs e)
        {

        }

        private void label_ConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        
        private void TogglePasswordTextVisibility(List<Button> buttons, List<TextBox> textBoxes)
        {
            foreach (var button in buttons)
            {
                if (textBoxes[0].UseSystemPasswordChar)

                    button.BackgroundImage = global::PresentationLayer.Properties.Resources.show;

                else
                    button.BackgroundImage = global::PresentationLayer.Properties.Resources.hide;

            }


            foreach (var textBox in textBoxes)
            {
                textBox.UseSystemPasswordChar = !textBox.UseSystemPasswordChar;
            }
        }
        private void ChangeRequirementsIcons(List<Button> buttons, List<bool> requirements)
        {

            // buttons[0] => buttonLength
            // buttons[1] => buttonNumbers
            // buttons[2] => buttonUppercase
            // buttons[3] => buttonLowercase

            for (int i = 0; i < requirements.Count - 1; i++)
            {
                if (requirements[i])
                    buttons[i].BackgroundImage = global::PresentationLayer.Properties.Resources.success;
                else
                    buttons[i].BackgroundImage = global::PresentationLayer.Properties.Resources.warning;
            }
        }

        private void ResetRequirementsIcons(List<Button> buttons)
        {
            foreach (var item in buttons)
            {
                item.BackgroundImage = global::PresentationLayer.Properties.Resources.blank;
            }

        }


       

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}

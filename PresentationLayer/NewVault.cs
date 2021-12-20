using Shared.Interfaces;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class NewVault : Form
    {
        private Thread thread;
        private readonly IVaultBusiness vaultBusiness;
        private int UserID;
        private string VaultKey;
   


        public NewVault(int UserID,string VaultKey,IVaultBusiness vaultBusiness)
        {   
            this.UserID = UserID;
            this.VaultKey = VaultKey;  
            this.vaultBusiness = vaultBusiness;
            InitializeComponent();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            String url = textBox_URL_New.Text;
            String name = textBox_Name_New.Text;
            String username = textBox_Email_New.Text;
            String password = textBox_Password_New.Text;
            if (textBox_URL_New.Text == "" || textBox_Name_New.Text == "" || textBox_Email_New.Text == "" || textBox_Password_New.Text == "")
            {
                Label_cancel.Visible = true;
                Label_cancel.Text = "Information missing";
            }
                
            else
            {
                VaultData vaultData = new VaultData(url, name, username, password);
                InsertVault(UserID, VaultKey, vaultData);

               // thread = new Thread(() => OpenVaultForm(user.UserID, user.EmailAddress, VaultKey, vaults, vaultBusiness, iUserBusiness));
                
                this.Dispose();
            }
                
        }
        private void OpenVaultForm(int UserID, string EmailAddress, string VaultKey, List<Vault> vaults, IVaultBusiness vaultBusiness)
        {
            Application.Run(new VaultForm(UserID, EmailAddress, VaultKey, vaults, vaultBusiness));
        }

        private void button_Confirm_Enter(object sender, EventArgs e)
        {
            button_Confirm.BackColor = Color.FromArgb(35, 85, 148);
            button_Confirm.ForeColor = Color.White;
        }

        private void button_Confirm_Leave(object sender, EventArgs e)
        {
            button_Confirm.BackColor = Color.White;
            button_Confirm.ForeColor = Color.Black;
        }
        private void NewVault_Load(object sender, EventArgs e)
        {

        }
        public void InsertVault(int userID, string vaultKey, VaultData vaultData)
        {
            vaultBusiness.InsertVault(userID, vaultKey, vaultData);

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (textBox_URL_New.Text != "" || textBox_Name_New.Text != "" || textBox_Email_New.Text != "" || textBox_Password_New.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("You have got unfinished work! Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    this.Dispose();
                }


                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            if (textBox_URL_New.Text == "" || textBox_Name_New.Text == "" || textBox_Email_New.Text == "" || textBox_Password_New.Text == "")
                this.Dispose();


        }
        private void buttonShowHideConfirmPassword_Click(object sender, EventArgs e)
        {
            TogglePasswordTextVisibility(new List<Button> { buttonShowHideConfirmPassword }, new List<TextBox> { textBox_Password_New });

        }
        private void TogglePasswordTextVisibility(List<Button> buttons, List<TextBox> textBoxes)
        {
            foreach (var button in buttons)
            {
                if (textBoxes[0].UseSystemPasswordChar)
                {
                    button.BackgroundImage = global::PresentationLayer.Properties.Resources.show;

                }
                else
                {
                    button.BackgroundImage = global::PresentationLayer.Properties.Resources.hide;

                }
            }
            foreach (var textBox in textBoxes)
            {
                textBox.UseSystemPasswordChar = !textBox.UseSystemPasswordChar;
            }
        }
    }
}

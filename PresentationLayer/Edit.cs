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
    public partial class Edit : Form
    {
        
        
        private readonly IVaultBusiness vaultBusiness;
        private int UserID;
        private int vaultId;
        private string VaultKey;
        
        private VaultData vaultData;

        public Edit(int UserID, string VaultKey, IVaultBusiness vaultBusiness,VaultData vaultData,int vaultId)
        {
            this.UserID = UserID;
            this.vaultData = vaultData;
            this.VaultKey = VaultKey;
            this.vaultId = vaultId;
            this.vaultBusiness = vaultBusiness;
            InitializeComponent();
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

        
        private void Edit_Load(object sender, EventArgs e)
        {
            

            textBox_URL_Edit.Text = vaultData.URL;
            textBox_Name_Edit.Text = vaultData.Name;
            textBox_Email_Edit.Text = vaultData.Username;
            textBox_Password_Edit.Text = vaultData.Password;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            String url = textBox_URL_Edit.Text;
            String name = textBox_Name_Edit.Text;
            String username = textBox_Email_Edit.Text;
            String password = textBox_Password_Edit.Text;

            if (textBox_URL_Edit.Text == "" || textBox_Name_Edit.Text == "" || textBox_Email_Edit.Text == "" || textBox_Password_Edit.Text == "")
            {
                Label_cancel_edit.Visible = true;
                Label_cancel_edit.Text = "Information missing";
            }

            else
            {

                VaultData vaultData = new VaultData(url, name, username, password);


                UpdateVault(UserID,vaultId,VaultKey,vaultData);


                this.Dispose();
            }
        }
        private void OpenVaultForm(int UserID, string EmailAddress, string VaultKey, List<Vault> vaults, IVaultBusiness vaultBusiness, IUserBusiness iUserBusiness)
        {
            Application.Run(new VaultForm(UserID, EmailAddress, VaultKey, vaults, vaultBusiness,  iUserBusiness));
        }
        public void UpdateVault(int userID, int vaultID, string vaultKey, VaultData vaultData)
        {
            vaultBusiness.UpdateVault(userID, vaultID, vaultKey, vaultData);

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (textBox_URL_Edit.Text != "" || textBox_Name_Edit.Text != "" || textBox_Email_Edit.Text != "" || textBox_Password_Edit.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("You have got unsaved changes! Are you sure you want to quit?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    this.Dispose();
                }


                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
            if (textBox_URL_Edit.Text == "" || textBox_Name_Edit.Text == "" || textBox_Email_Edit.Text == "" || textBox_Password_Edit.Text == "")
                this.Dispose();
        }


        private void buttonShowHideConfirmPassword_Click(object sender, EventArgs e)
        {
            TogglePasswordTextVisibility(new List<Button> { buttonShowHideConfirmPassword }, new List<TextBox> { textBox_Password_Edit });

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

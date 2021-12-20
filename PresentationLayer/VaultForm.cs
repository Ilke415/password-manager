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
    public partial class VaultForm : Form
    {
        private int UserID;
        private string EmailAddress;
        private string VaultKey;
        private List<Vault> vaults;
        private readonly IVaultBusiness vaultBusiness;
        public VaultForm(int UserID, string EmailAddress, string VaultKey, List<Vault> vaults, IVaultBusiness vaultBusiness)
        {
            this.UserID = UserID;
            this.EmailAddress = EmailAddress;
            this.VaultKey = VaultKey;
            this.vaults = vaults;
            this.vaultBusiness = vaultBusiness;
            InitializeComponent();
        }

        private void VaultForm_Load(object sender, EventArgs e)
        {
            labelUserEmailAddress.Text = EmailAddress;

            foreach (Vault vault in vaults)
            {
                VaultData vaultData = vault.VaultDataDecrypted;

                int vaultID = vault.VaultID;

                Panel panel = new Panel();
                panel.Padding = new Padding(15);
                panel.Margin = new Padding(0, 0, 20, 20);
                panel.Size = new Size(250, 145);
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Name = $"panelVault{vault.VaultID}";

                Label labelName = new Label();

                labelName.Text = vaultData.Name;

                labelName.Font = new Font("Elephant", 30.75F);
                labelName.AutoSize = true;
                labelName.Top = 10;
                panel.Controls.Add(labelName);


                Label labelUsername = new Label();


                labelUsername.Text = vaultData.Username;

                labelUsername.Font = new Font("Segoe UI", 12.75F);
                labelUsername.AutoSize = true;
                labelUsername.Margin = new Padding(30, 10, 10, 10);
                labelUsername.Top = 70;
                labelUsername.Left = 10;
                panel.Controls.Add(labelUsername);

                Label labelEdit = new Label();

                labelEdit.Text = "Edit";
                labelEdit.Font = new Font("Segoe UI", 12.75F);
                labelEdit.AutoSize = true;
                labelEdit.Margin = new Padding(30, 10, 10, 10);
                labelEdit.Top = 110;
                labelEdit.Left = 10;
                labelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
                labelEdit.Name = $"labelEdit{vault.VaultID}";
                labelEdit.Click += labelEdit_Click;
                panel.Controls.Add(labelEdit);




                Label labelDelete = new Label();

                labelDelete.Text = "Delete";
                labelDelete.ForeColor = Color.Red;
                labelDelete.Font = new Font("Segoe UI", 12.75F);
                labelDelete.AutoSize = true;
                labelDelete.Margin = new Padding(30, 10, 10, 10);
                labelDelete.Top = 110;
                labelDelete.Left = 50;
                labelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
                labelDelete.Name = $"labelDelete{vault.VaultID}";
                labelDelete.Click += labelDelete_Click;
                panel.Controls.Add(labelDelete);

                flowLayoutPanelMain.Controls.Add(panel);
            }

        }


        private void UpdateVaults(List<Vault> vaults)
        {


        }



        public void labelEdit_Click(object sender, EventArgs e)
        {
            Label labelEdit = sender as Label;

            string labelName = labelEdit.Name;

            string removedLabelName = labelName.Replace("labelEdit", "");

            int VaultID = Convert.ToInt32(removedLabelName);

            MessageBox.Show($"{VaultID}");
        }

        public int FindItemListIndex(List<Vault> vaults, int VaultID)
        {
            int index = 0;

            for (int i = 0; i < vaults.Count; i++)
            {
                if (vaults[i].VaultID == VaultID)
                    index = i;
            }


            return index;


        }

        public void labelDelete_Click(object sender, EventArgs e)
        {
            Label labelDelete = sender as Label;

            string labelName = labelDelete.Name;

            string removedLabelName = labelName.Replace("labelDelete", "");

            int VaultID = Convert.ToInt32(removedLabelName);

            Control panelToDelete = flowLayoutPanelMain.Controls.Find($"panelVault{VaultID}", true)[0];

            flowLayoutPanelMain.Controls.Remove(panelToDelete);


            int vaultIndex = FindItemListIndex(vaults, VaultID);

            this.vaults.RemoveAt(vaultIndex);

            string output = "";

            foreach (var item in vaults)
            {
                output += $"{item.VaultID}, ";
            }

            vaultBusiness.DeleteVault(this.UserID, VaultID);

            MessageBox.Show(output);

        }

        private void buttonAddNewVault_MouseHover(object sender, EventArgs e)
        {

            buttonAddNewVault.BackgroundImage = global::PresentationLayer.Properties.Resources.AddNewIconHover;

        }

        private void buttonAddNewVault_MouseLeave(object sender, EventArgs e)
        {
            buttonAddNewVault.BackgroundImage = global::PresentationLayer.Properties.Resources.AddNewIcon;
        }

        private void flowLayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


namespace PresentationLayer
{
    partial class VaultForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelUserEmailAddress = new System.Windows.Forms.Label();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddNewVault = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelUserIcon = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHeader.Controls.Add(this.labelUserEmailAddress);
            this.panelHeader.Controls.Add(this.panelUserIcon);
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelHeader.Location = new System.Drawing.Point(-8, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 70);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // labelUserEmailAddress
            // 
            this.labelUserEmailAddress.AutoSize = true;
            this.labelUserEmailAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserEmailAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelUserEmailAddress.Location = new System.Drawing.Point(131, 18);
            this.labelUserEmailAddress.Name = "labelUserEmailAddress";
            this.labelUserEmailAddress.Size = new System.Drawing.Size(194, 25);
            this.labelUserEmailAddress.TabIndex = 2;
            this.labelUserEmailAddress.Text = "example@email.com";
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelMain.Controls.Add(this.buttonAddNewVault);
            this.flowLayoutPanelMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(47, 98);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Padding = new System.Windows.Forms.Padding(35, 20, 20, 20);
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(883, 526);
            this.flowLayoutPanelMain.TabIndex = 3;
            this.flowLayoutPanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMain_Paint);
            // 
            // buttonAddNewVault
            // 
            this.buttonAddNewVault.BackgroundImage = global::PresentationLayer.Properties.Resources.AddNewIcon;
            this.buttonAddNewVault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddNewVault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNewVault.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAddNewVault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewVault.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddNewVault.Location = new System.Drawing.Point(35, 20);
            this.buttonAddNewVault.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.buttonAddNewVault.Name = "buttonAddNewVault";
            this.buttonAddNewVault.Size = new System.Drawing.Size(250, 150);
            this.buttonAddNewVault.TabIndex = 0;
            this.buttonAddNewVault.UseVisualStyleBackColor = true;
            this.buttonAddNewVault.Click += new System.EventHandler(this.buttonAddNewVault_Click);
            this.buttonAddNewVault.MouseEnter += new System.EventHandler(this.buttonAddNewVault_MouseHover);
            this.buttonAddNewVault.MouseLeave += new System.EventHandler(this.buttonAddNewVault_MouseLeave);
            // 
            // panelFooter
            // 
            this.panelFooter.BackgroundImage = global::PresentationLayer.Properties.Resources.FooterBackgroundImageResized;
            this.panelFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFooter.Location = new System.Drawing.Point(-8, 654);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1000, 105);
            this.panelFooter.TabIndex = 2;
            // 
            // panelUserIcon
            // 
            this.panelUserIcon.BackgroundImage = global::PresentationLayer.Properties.Resources.UserLoginIcon;
            this.panelUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUserIcon.Location = new System.Drawing.Point(69, 3);
            this.panelUserIcon.Name = "panelUserIcon";
            this.panelUserIcon.Size = new System.Drawing.Size(60, 60);
            this.panelUserIcon.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PresentationLayer.Properties.Resources.logoutIcon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(905, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // VaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(979, 755);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "VaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VaultForm";
            this.Load += new System.EventHandler(this.VaultForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelUserIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Label labelUserEmailAddress;
        private System.Windows.Forms.Button buttonAddNewVault;
    }
}
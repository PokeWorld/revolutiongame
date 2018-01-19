namespace Amethyst
{
    partial class UpgradeShop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listUpgrades = new System.Windows.Forms.ListBox();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.tmrUpdateTotal = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblUpgradeTitle = new System.Windows.Forms.Label();
            this.lblUpgradeDesc = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.lblUpgradeDesc);
            this.panel1.Controls.Add(this.lblUpgradeTitle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(392, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 600);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Upgrades";
            // 
            // listUpgrades
            // 
            this.listUpgrades.Font = new System.Drawing.Font("Lucida Console", 13F);
            this.listUpgrades.FormattingEnabled = true;
            this.listUpgrades.ItemHeight = 17;
            this.listUpgrades.Items.AddRange(new object[] {
            "Enable AdSense",
            "Unlock Leaderboards",
            "TestUpgrade3"});
            this.listUpgrades.Location = new System.Drawing.Point(19, 66);
            this.listUpgrades.Name = "listUpgrades";
            this.listUpgrades.Size = new System.Drawing.Size(367, 446);
            this.listUpgrades.TabIndex = 2;
            this.listUpgrades.SelectedIndexChanged += new System.EventHandler(this.listUpgrades_SelectedIndexChanged);
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.AutoSize = true;
            this.lblTotalCash.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.lblTotalCash.Location = new System.Drawing.Point(121, 547);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(152, 19);
            this.lblTotalCash.TabIndex = 3;
            this.lblTotalCash.Text = "Balance: $000";
            // 
            // tmrUpdateTotal
            // 
            this.tmrUpdateTotal.Enabled = true;
            this.tmrUpdateTotal.Interval = 10;
            this.tmrUpdateTotal.Tick += new System.EventHandler(this.tmrUpdateTotal_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.button1.Location = new System.Drawing.Point(337, 561);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUpgradeTitle
            // 
            this.lblUpgradeTitle.AutoSize = true;
            this.lblUpgradeTitle.Font = new System.Drawing.Font("Lucida Console", 18F);
            this.lblUpgradeTitle.Location = new System.Drawing.Point(3, 16);
            this.lblUpgradeTitle.Name = "lblUpgradeTitle";
            this.lblUpgradeTitle.Size = new System.Drawing.Size(290, 24);
            this.lblUpgradeTitle.TabIndex = 1;
            this.lblUpgradeTitle.Text = "Welcome to Upgrades!";
            // 
            // lblUpgradeDesc
            // 
            this.lblUpgradeDesc.AutoSize = true;
            this.lblUpgradeDesc.Font = new System.Drawing.Font("Lucida Console", 13F);
            this.lblUpgradeDesc.Location = new System.Drawing.Point(7, 66);
            this.lblUpgradeDesc.Name = "lblUpgradeDesc";
            this.lblUpgradeDesc.Size = new System.Drawing.Size(426, 126);
            this.lblUpgradeDesc.TabIndex = 2;
            this.lblUpgradeDesc.Text = "Here, you can purchase items that will\r\nimprove the quality of your site, or \r\npo" +
    "ssibly attract more users to your\r\nplatform. To get an upgrade, click\r\non an ite" +
    "m to the left to get started\r\n\r\n\r\n";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Lucida Console", 18F);
            this.lblCost.Location = new System.Drawing.Point(6, 566);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 24);
            this.lblCost.TabIndex = 3;
            // 
            // UpgradeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalCash);
            this.Controls.Add(this.listUpgrades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UpgradeShop";
            this.Size = new System.Drawing.Size(864, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listUpgrades;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Timer tmrUpdateTotal;
        private System.Windows.Forms.Label lblUpgradeDesc;
        private System.Windows.Forms.Label lblUpgradeTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCost;
    }
}

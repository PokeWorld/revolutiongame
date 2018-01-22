namespace Amethyst
{
    partial class desktop
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
            this.components = new System.ComponentModel.Container();
            this.panelBar = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiteAnaylytics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSiteController = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDodgeTheAd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpgradeShop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLeaderboard = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDayAdvance = new System.Windows.Forms.Button();
            this.lblDayCount = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.tmData = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.panelBar.Location = new System.Drawing.Point(0, 576);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(800, 24);
            this.panelBar.TabIndex = 0;
            this.panelBar.Text = "MenuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSiteAnaylytics,
            this.tsmSiteController,
            this.tsmDodgeTheAd,
            this.tsmUpgradeShop,
            this.tsmLeaderboard,
            this.ToolStripSeparator1,
            this.tsmShutdown});
            this.MenuToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.MenuToolStripMenuItem.Text = "Menu";
            // 
            // tsmSiteAnaylytics
            // 
            this.tsmSiteAnaylytics.Name = "tsmSiteAnaylytics";
            this.tsmSiteAnaylytics.Size = new System.Drawing.Size(161, 22);
            this.tsmSiteAnaylytics.Text = "Analytics";
            this.tsmSiteAnaylytics.Click += new System.EventHandler(this.tsmSiteAnaylytics_Click);
            // 
            // tsmSiteController
            // 
            this.tsmSiteController.Name = "tsmSiteController";
            this.tsmSiteController.Size = new System.Drawing.Size(161, 22);
            this.tsmSiteController.Text = "Control Panel";
            this.tsmSiteController.Click += new System.EventHandler(this.tsmSiteController_Click);
            // 
            // tsmDodgeTheAd
            // 
            this.tsmDodgeTheAd.Name = "tsmDodgeTheAd";
            this.tsmDodgeTheAd.Size = new System.Drawing.Size(161, 22);
            this.tsmDodgeTheAd.Text = "Dodge The Ad";
            this.tsmDodgeTheAd.Click += new System.EventHandler(this.tsmDodgeTheAd_Click);
            // 
            // tsmUpgradeShop
            // 
            this.tsmUpgradeShop.Name = "tsmUpgradeShop";
            this.tsmUpgradeShop.Size = new System.Drawing.Size(161, 22);
            this.tsmUpgradeShop.Text = "Upgrade Shop";
            this.tsmUpgradeShop.Click += new System.EventHandler(this.upgradeShopToolStripMenuItem_Click);
            // 
            // tsmLeaderboard
            // 
            this.tsmLeaderboard.Name = "tsmLeaderboard";
            this.tsmLeaderboard.Size = new System.Drawing.Size(161, 22);
            this.tsmLeaderboard.Text = "Leaderboard";
            this.tsmLeaderboard.Click += new System.EventHandler(this.leaderboardToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // tsmShutdown
            // 
            this.tsmShutdown.Name = "tsmShutdown";
            this.tsmShutdown.Size = new System.Drawing.Size(161, 22);
            this.tsmShutdown.Text = "Shutdown";
            this.tsmShutdown.Click += new System.EventHandler(this.tsmShutdown_Click);
            // 
            // btnDayAdvance
            // 
            this.btnDayAdvance.BackColor = System.Drawing.Color.Black;
            this.btnDayAdvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDayAdvance.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnDayAdvance.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDayAdvance.Location = new System.Drawing.Point(0, 70);
            this.btnDayAdvance.Name = "btnDayAdvance";
            this.btnDayAdvance.Size = new System.Drawing.Size(100, 23);
            this.btnDayAdvance.TabIndex = 1;
            this.btnDayAdvance.Text = "Day Advance";
            this.btnDayAdvance.UseVisualStyleBackColor = false;
            this.btnDayAdvance.Click += new System.EventHandler(this.btnDayAdvance_Click);
            // 
            // lblDayCount
            // 
            this.lblDayCount.AutoSize = true;
            this.lblDayCount.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.lblDayCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDayCount.Location = new System.Drawing.Point(3, 45);
            this.lblDayCount.Name = "lblDayCount";
            this.lblDayCount.Size = new System.Drawing.Size(61, 11);
            this.lblDayCount.TabIndex = 2;
            this.lblDayCount.Text = "Day Null";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestart.Location = new System.Drawing.Point(107, 70);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(93, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Reset Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.lblMoney.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMoney.Location = new System.Drawing.Point(118, 45);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(82, 11);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "Money: $NaN";
            // 
            // tmData
            // 
            this.tmData.Enabled = true;
            this.tmData.Tick += new System.EventHandler(this.tmData_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDayCount);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.lblMoney);
            this.panel1.Controls.Add(this.btnDayAdvance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 576);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sidebar";
            // 
            // desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.panelBar;
            this.Name = "desktop";
            this.Text = "desktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.desktop_Activated);
            this.Load += new System.EventHandler(this.desktop_Load);
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public System.Windows.Forms.MenuStrip panelBar;
        public System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tsmSiteController;
        public System.Windows.Forms.ToolStripMenuItem tsmShutdown;
        public System.Windows.Forms.ToolStripMenuItem tsmSiteAnaylytics;
        public System.Windows.Forms.ToolStripMenuItem tsmDodgeTheAd;
        public System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        public System.Windows.Forms.Button btnDayAdvance;
        public System.Windows.Forms.Button btnRestart;
        public System.Windows.Forms.Label lblDayCount;
        public System.Windows.Forms.Label lblMoney;
        public System.Windows.Forms.Timer tmData;
        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmUpgradeShop;
        private System.Windows.Forms.ToolStripMenuItem tsmLeaderboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
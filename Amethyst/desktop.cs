using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amethyst
{
    public partial class desktop : Form
    {
        WindowManager wm = new WindowManager();
        public desktop()
        {
            InitializeComponent();
        }

        private void desktop_Load(object sender, EventArgs e)
        {
            RPCManger.UpdateSatus("Desktop", "Managing the desktop", "icon");
            lblDayCount.Text = "Day " + Properties.Settings.Default.DayCount.ToString();
            lblMoney.Text = "Money: $" + Properties.Settings.Default.CashCount.ToString();
            if (!UpgradeMeta.checkUpgradeBought("Unlock Leaderboards")) tsmLeaderboard.Visible = false;
        }

        private void btnDayAdvance_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DayCount += 1;
            lblDayCount.Text = "Day " + Properties.Settings.Default.DayCount.ToString();
            Properties.Settings.Default.Users += Properties.Settings.Default.AdIntensity * 2;
            Properties.Settings.Default.CashCount -= Properties.Settings.Default.AdIntensity;
            lblMoney.Text = "Money: $" + Properties.Settings.Default.CashCount;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DayCount = 1;
            lblDayCount.Text = "Day " + Properties.Settings.Default.DayCount.ToString();
            Properties.Settings.Default.SiteName = "Undefined";
            Properties.Settings.Default.AdIntensity = 1;
            Properties.Settings.Default.Users = 10;
            Properties.Settings.Default.CashCount = 100;
            lblMoney.Text = "Money: $" + Properties.Settings.Default.CashCount;
        }

        private void tmData_Tick(object sender, EventArgs e)
        {
            lblMoney.Text = "Money: $" + Properties.Settings.Default.CashCount;
        }

        private void tsmDodgeTheAd_Click(object sender, EventArgs e)
        {
            wm.createWindow(new DodgeTheAd(), "Dodge The Ad", "Dodging sketchy ads", "dodgethead", Properties.Resources.DodgeTheAd);
        }

        private void tsmSiteController_Click(object sender, EventArgs e)
        {
            wm.createWindow(new SiteControl(), "Site Control", "Controlling the site", "controlpanel", Properties.Resources.ControlPanel);
        }

        private void tsmSiteAnaylytics_Click(object sender, EventArgs e)
        {
            wm.createWindow(new SiteAnalytics(), "Site Analytics", "Checking Stats", "analytics", Properties.Resources.AnalyticsNew);
        }
      
        private void tsmShutdown_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void desktop_Activated(object sender, EventArgs e)
        {
            RPCManger.UpdateSatus("Desktop", "Managing the desktop", "logo");
        }

        private void upgradeShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.createWindow(new UpgradeShop(), "Upgrade Shop", "Upgrading " + Properties.Settings.Default.SiteName, "controlpanel", Properties.Resources.ControlPanel);
        }

        private void leaderboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wm.createWindow(new InProgressPlaceholder(), "Critical", "Viewing the error", "AnalyticsNew", Properties.Resources.AnalyticsNew);
        }
    }
}

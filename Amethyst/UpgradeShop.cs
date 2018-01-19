using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amethyst
{
    public partial class UpgradeShop : UserControl
    {
        WindowManager wm = new WindowManager();
        public UpgradeShop()
        {
            InitializeComponent();
        }

        private void tmrUpdateTotal_Tick(object sender, EventArgs e)
        {
            lblTotalCash.Text = "Balance: $" + Properties.Settings.Default.CashCount.ToString();
        }

        private void listUpgrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listUpgrades.SelectedIndex;

            if (listUpgrades.SelectedItem != null && listUpgrades.SelectedItem.ToString() == "Enable AdSense")
            {
                lblUpgradeTitle.Text = "Enable AdSense";
                lblUpgradeDesc.Text = "This allows you to put ads on your network\r\nto make money from it.";
                lblCost.Text = "Cost: $50";
            }

            if (listUpgrades.SelectedItem != null && listUpgrades.SelectedItem.ToString() == "Unlock Leaderboards")
            {
                lblUpgradeTitle.Text = "Unlock Leaderboards";
                lblUpgradeDesc.Text = "Now, you can see your standing versus \r\nother networks in this handy application!";
                lblCost.Text = "Cost: $95";
            }

            if (listUpgrades.SelectedItem != null && listUpgrades.SelectedItem.ToString() == "TestUpgrade3")
            {
                lblUpgradeTitle.Text = "TestUpgrade3";
                lblUpgradeDesc.Text = "You must be getting sick and tired\r\nof these strings by now.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listUpgrades.SelectedItem != null && listUpgrades.SelectedItem.ToString() == "Enable AdSense")
            {
                if (Properties.Settings.Default.adsense1Puchased == false)
                {
                    if (Properties.Settings.Default.CashCount < 50) return;
                    Properties.Settings.Default.adsense1Puchased = true;
                    Properties.Settings.Default.CashCount -= 50;    
                }
                
            }
            if (listUpgrades.SelectedItem != null && listUpgrades.SelectedItem.ToString() == "Unlock Leaderboards")
            {
                if (Properties.Settings.Default.leaderboardsPurchased == false)
                {
                    if (Properties.Settings.Default.CashCount < 95) return;
                    Properties.Settings.Default.leaderboardsPurchased = true;
                    Properties.Settings.Default.CashCount -= 95;
                }

            }

        }
    }
}

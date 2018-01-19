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
            if (listUpgrades.SelectedItem == null) return;
            lblUpgradeTitle.Text = listUpgrades.SelectedItem.ToString();
            lblUpgradeDesc.Text = UpgradeMeta.getUpgradeDescription(listUpgrades.SelectedItem.ToString());
            lblCost.Text = UpgradeMeta.getUpgradePrice(listUpgrades.SelectedItem.ToString()).ToString();
            if (Properties.Settings.Default.CashCount < UpgradeMeta.getUpgradePrice(listUpgrades.SelectedItem.ToString()))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listUpgrades.SelectedItem == null) return;
            UpgradeMeta.buyUpgrade(listUpgrades.SelectedItem.ToString());
            listUpgrades.Items.Clear();
            foreach (string i in UpgradeMeta.listUpgradesAvaiable())
            {
                listUpgrades.Items.Add(i);
            }
        }

        private void UpgradeShop_Load(object sender, EventArgs e)
        {
            foreach (string i in UpgradeMeta.listUpgradesAvaiable())
            {
                listUpgrades.Items.Add(i);
            }
        }
    }
}

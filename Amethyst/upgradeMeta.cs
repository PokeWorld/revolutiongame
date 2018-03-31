using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amethyst
{
    static class UpgradeMeta
    {
        static Dictionary<string, string> upgradeDescriptions = new Dictionary<string, string>();
        static Dictionary<string, int> upgradePrices = new Dictionary<string, int>();
        public static void load()
        {
            upgradeDescriptions.Add("Enable AdSense", "This allows you to put ads on your network\r\nto make money from it.");
            upgradeDescriptions.Add("Unlock Leaderboards", "Now, you can see your standing versus \r\nother networks in this handy application!");
            upgradeDescriptions.Add("Exploiter", "Exploit the enemy networks and take down their sites for a short period of time. This may have some negative consequences though...");

            upgradePrices.Add("Enable AdSense", 50);
            upgradePrices.Add("Unlock Leaderboards", 95);
            upgradePrices.Add("Exploiter", 150);
        }
        
        public static int getUpgradePrice(string upgradeName)
        {
            int price;
            upgradePrices.TryGetValue(upgradeName, out price);
            return price;
        }
        
        public static string getUpgradeDescription(string upgradeName)
        {
            string description;
            upgradeDescriptions.TryGetValue(upgradeName, out description);
            return description;
        }

        public static List<String> listUpgradesAvaiable()
        {
            List<String> upgrades = new List<string>();
            foreach (DictionaryEntry i in Properties.Settings.Default.upgradesAvailable)
            {
                if (Properties.Settings.Default.upgradesBought.Contains(i.Key)) break;
                if (i.Value != null &&
                    !Properties.Settings.Default.upgradesBought.Contains(
                    i.Value)) break;
                upgrades.Add(i.Key.ToString());
            }
            return upgrades;
        }

        public static bool checkUpgradeBought(string upgradeName)
        {
            return (Properties.Settings.Default.upgradesBought.Contains(upgradeName) ? true : false);
        }

        public static void buyUpgrade(string upgradeName)
        {
            Properties.Settings.Default.upgradesBought.Add(
                upgradeName,
                Properties.Settings.Default.upgradesAvailable[upgradeName]);
            Properties.Settings.Default.upgradesAvailable.Remove(upgradeName);
            Properties.Settings.Default.CashCount -= getUpgradePrice(upgradeName);
        }
    }
}

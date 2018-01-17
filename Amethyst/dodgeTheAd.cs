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
    public partial class DodgeTheAd : UserControl
    {
        int score = 0;
        Dictionary<String, Boolean> items = new Dictionary<String, Boolean>();
        public DodgeTheAd()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool question = items[lblAd.Text];
            bool answer;
            if (comboxYesOrNo.Text == "Yes")
                answer = true;
            else if (comboxYesOrNo.Text == "No")
                answer = false;
            else
            {
                MessageBox.Show("You have to select an option");
                return;
            }
            if (question == answer)
            {
                score += 1;
                Properties.Settings.Default.CashCount += 1;
            }
            comboxYesOrNo.SelectedIndex = 0;
            lblScore.Text = score.ToString();
            lblAd.Text = items.Keys.ElementAt(new Random().Next(1,items.Count));
        }

        private void dodgeTheAd_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.graphicsFriendly)
            {
                btnCheck.FlatStyle = FlatStyle.Flat;
                comboxYesOrNo.FlatStyle = FlatStyle.Flat;
            }
            comboxYesOrNo.SelectedIndex = 0;
            items.Add("Ad for the newest version of Microsoft Windows", true);
            items.Add("Ad for the new Facebook network", true);
            items.Add("Ad for your site, " + Properties.Settings.Default.SiteName, true);
            items.Add("Ad for the Pirate Bay torrenting site.", false);
            items.Add("adf.ly link that is not trusted", false);
            items.Add("Link to a fishy forum that you do not like", false);
            items.Add("eBay link", true);
            items.Add("Windows Blue-Screen In Browser Pop-Up", false);
            items.Add("A link to a media converter", false);
            items.Add("Link to small software site", false);
            items.Add("Custom Themes for Windows on Microsoft Site", true);
            items.Add("Link to site where PC games are sold on disk", true);
            items.Add("Link to a some-what fishy looking 'AVG'", true);
            items.Add("Link the an irc chat that contains NSFW", false);
            items.Add("Picture of the google search engine", true);
            items.Add("NSFW pictures", false);
            items.Add("Link to a website that is no longer existent", false);
            items.Add("Link to an online dating website", true);
        }
    }
}

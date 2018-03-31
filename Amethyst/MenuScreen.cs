using System;
using System.Windows.Forms;

namespace Amethyst
{
    public partial class MenuScreen : Form
    {

        public MenuScreen()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmGraphic_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DayCount > 730)
                Properties.Settings.Default.graphicsFriendly = false;
            else
                Properties.Settings.Default.graphicsFriendly = true;
        }

        private void tmText_Tick(object sender, EventArgs e)
        {
            switch (new Random().Next(1, 10))
            {
                case 10:
                    lblAdvice.Text = "I promise this will be finished by \r\nmid 2019";
                    setColor(System.Drawing.Color.Aqua);
                    break;
                case 9:
                    lblAdvice.Text = "Puzzled? Go to the 'Site Controller' \r\napplication to get started.";
                    setColor(System.Drawing.Color.OrangeRed);
                    break;
                case 8:
                    lblAdvice.Text = "Now in C#, and FINALLY open source!";
                    setColor(System.Drawing.Color.Crimson);
                    break;
                case 7:
                    lblAdvice.Text = "Hi! I am a bug. Just kidding.";
                    setColor(System.Drawing.Color.LimeGreen);
                    break;
                case 6:
                    lblAdvice.Text = "If Rylan was a developer, this \r\nwould be Google Cod. :fish:";
                    setColor(System.Drawing.Color.Salmon);
                    break;
                case 5:
                    lblAdvice.Text = "Seriously, don't run this at\r\nANYTHING higher than 1080p";
                    setColor(System.Drawing.Color.Black);
                    break;
                case 4:
                    lblAdvice.Text = "We have Rich Presence! Now \r\ngo off to show your buddies!";
                    setColor(System.Drawing.Color.CadetBlue);
                    break;
                case 3:
                    lblAdvice.Text = "Feeling bored of ShiftOS 0.0.3\r\ngameplay? Visit the Upgrade Shop!\r\nNow with the clunkiest code you will ever see, \r\nyou can purchase upgrades!";
                    setColor(System.Drawing.Color.DeepPink);
                    break;
                case 2:
                    lblAdvice.Text = "Tech Demo 1. (c) Pallet";
                    setColor(System.Drawing.Color.Teal);
                    break;
                default:
                    lblAdvice.Text = "More gameplay than ForumLife";

                    break;
            }
        }

        public void setColor(System.Drawing.Color color)
        {
            BackColor = color;
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            new desktop().Show();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            RPCManger.start("Menu Screen", "Browsing the Menu Screen");
            if (Properties.Settings.Default.upgradesAvailable == null)
            {
                Properties.Settings.Default.upgradesAvailable = new System.Collections.Hashtable();
                Properties.Settings.Default.upgradesBought = new System.Collections.Hashtable();
                Properties.Settings.Default.upgradesAvailable.Add("Enable AdSense", null);
                Properties.Settings.Default.upgradesAvailable.Add("Unlock Leaderboards", null);
                Properties.Settings.Default.upgradesAvailable.Add("Exploiter", null);
            }
            UpgradeMeta.load();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = System.Drawing.Color.FromArgb(25, 0, 0, 0);
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            new desktop().Show();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

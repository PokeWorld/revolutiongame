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
                    lblAdvice.Text = "I promise this will be finished by mid 2019";
                    break;
                case 9:
                    lblAdvice.Text = "Puzzled? Go to the 'Site Controller' application to get started.";
                    break;
                case 8:
                    lblAdvice.Text = "Still in C#, and VERY CLOSED SOURCE.";
                    break;
                case 7:
                    lblAdvice.Text = "Hi! I am a bug. Just kidding.";
                    break;
                case 6:
                    lblAdvice.Text = "If Rylan was a developer, this would be Google Cod. :fish:";
                    break;
                case 5:
                    lblAdvice.Text = "Seriously, don't run this at ANYTHING higher than 1080p";
                    break;
                case 4:
                    lblAdvice.Text = "Does C# support Discord Rich Presence? If so, it will be here (eventually)";
                    break;
                case 3:
                    lblAdvice.Text = "bytes and bits";
                    break;
                case 2:
                    lblAdvice.Text = "Tech Demo 1. (c) Pallet Games";
                    break;
                default:
                    lblAdvice.Text = "hi im out of ideas";
                    break;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            new desktop().Show();
        }
    }
}

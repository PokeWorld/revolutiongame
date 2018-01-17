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
                    this.BackColor = System.Drawing.Color.Aqua;
                    btnPlay.BackColor = System.Drawing.Color.Aqua;
                    btnExit.BackColor = System.Drawing.Color.Aqua;
                    break;
                case 9:
                    lblAdvice.Text = "Puzzled? Go to the 'Site Controller' application to get started.";
                    this.BackColor = System.Drawing.Color.OrangeRed;
                    btnPlay.BackColor = System.Drawing.Color.OrangeRed;
                    btnExit.BackColor = System.Drawing.Color.OrangeRed;
                    break;
                case 8:
                    lblAdvice.Text = "Now in C#, and still VERY CLOSED SOURCE.";
                    this.BackColor = System.Drawing.Color.Crimson;
                    btnPlay.BackColor = System.Drawing.Color.Crimson;
                    btnExit.BackColor = System.Drawing.Color.Crimson;
                    break;
                case 7:
                    lblAdvice.Text = "Hi! I am a bug. Just kidding.";
                    this.BackColor = System.Drawing.Color.LimeGreen;
                    btnPlay.BackColor = System.Drawing.Color.LimeGreen;
                    btnExit.BackColor = System.Drawing.Color.LimeGreen;
                    break;
                case 6:
                    lblAdvice.Text = "If Rylan was a developer, this would be Google Cod. :fish:";
                    this.BackColor = System.Drawing.Color.Salmon;
                    btnPlay.BackColor = System.Drawing.Color.Salmon;
                    btnExit.BackColor = System.Drawing.Color.Salmon;
                    break;
                case 5:
                    lblAdvice.Text = "Seriously, don't run this at ANYTHING higher than 1080p";
                    this.BackColor = System.Drawing.Color.Black;
                    btnPlay.BackColor = System.Drawing.Color.Black;
                    btnExit.BackColor = System.Drawing.Color.Black;
                    break;
                case 4:
                    lblAdvice.Text = "Does C# support Discord Rich Presence? If so, it will be here (eventually)";
                    this.BackColor = System.Drawing.Color.CadetBlue;
                    btnPlay.BackColor = System.Drawing.Color.CadetBlue;
                    btnExit.BackColor = System.Drawing.Color.CadetBlue;
                    break;
                case 3:
                    lblAdvice.Text = "bytes and bits";
                    this.BackColor = System.Drawing.Color.DeepPink;
                    btnPlay.BackColor = System.Drawing.Color.DeepPink;
                    btnExit.BackColor = System.Drawing.Color.DeepPink;
                    break;
                case 2:
                    lblAdvice.Text = "Tech Demo 1. (c) Pallet Games";
                    this.BackColor = System.Drawing.Color.Teal;
                    btnPlay.BackColor = System.Drawing.Color.Teal;
                    btnExit.BackColor = System.Drawing.Color.Teal;
                    break;
                default:
                    lblAdvice.Text = "More gameplay than ForumLife";
                    this.BackColor = System.Drawing.Color.DarkMagenta;
                    btnPlay.BackColor = System.Drawing.Color.Purple;
                    btnExit.BackColor = System.Drawing.Color.Purple;
                    break;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            new desktop().Show();
        }
    }
}

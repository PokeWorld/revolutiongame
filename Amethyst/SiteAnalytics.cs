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
    public partial class SiteAnalytics : UserControl
    {
        public SiteAnalytics()
        {
            InitializeComponent();
        }

        private void tmData_Tick(object sender, EventArgs e)
        {
            lblSiteName.Text = "Network Name: " + Properties.Settings.Default.SiteName;
            lblAdIntensity.Text = "Advertising Intensity: " + Properties.Settings.Default.AdIntensity.ToString();
            lblUserCount.Text = "Users: " + Properties.Settings.Default.Users.ToString();
            lblAdsense.Text = "AdSense? : " + UpgradeMeta.checkUpgradeBought("Enable AdSense");
        }
    }
}

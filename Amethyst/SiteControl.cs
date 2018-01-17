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
    public partial class SiteControl : UserControl
    {
        public SiteControl()
        {
            InitializeComponent();
        }

        private void btnSetIntensity_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AdIntensity = trackbarAdIntense.Value;
        }

        private void btnSetName_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SiteName = txtbxsetSiteName.Text;
        }

        private void SiteControl_Load(object sender, EventArgs e)
        {
            txtbxsetSiteName.Text = Properties.Settings.Default.SiteName;
            trackbarAdIntense.Value = Properties.Settings.Default.AdIntensity;
            if (!Properties.Settings.Default.graphicsFriendly)
            {
                btnSetIntensity.FlatStyle = FlatStyle.Flat;
                btnSetName.FlatStyle = FlatStyle.Flat;
            }
        }

        private void trackbarAdIntense_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AdIntensity = trackbarAdIntense.Value;
        }
    }
}

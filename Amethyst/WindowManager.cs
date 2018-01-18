using System;
using System.Windows.Forms;

namespace Amethyst
{
    class WindowManager
    {
        public void createWindow(UserControl program, String name, String rpcData)
        {
            @base window = new @base()
            {
                Height = program.Height + 30,
                Width = program.Width
            };
            program.Parent = window.pnlContent;
            program.BringToFront();
            program.Dock = DockStyle.Fill;
            window.lblProg.Text = name;
            if  (Properties.Settings.Default.graphicsFriendly == false)  window.Opacity = 0;
            window.TopMost = true;
            window.Tag = rpcData;
            window.Show();
        }
    }
}

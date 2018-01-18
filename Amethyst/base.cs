using System;
using System.Drawing;
using System.Windows.Forms;

namespace Amethyst
{
    public partial class @base : Form
    {
        bool drag;
        int mousex;
        int mousey;
        public @base()
        {
            InitializeComponent();
        }

        #region titlebar
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Top = Cursor.Position.Y - mousey;
                Left = Cursor.Position.X - mousex;
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - Left;
            mousey = Cursor.Position.Y - Top;
        }

        private void pnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion
        #region timers
        private void tmClose_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity == 0) Dispose();
        }

        private void tmOpen_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity == 1) tmOpen.Enabled = false;
        }
        #endregion
        #region closing
        private void base_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.graphicsFriendly == true) Dispose();
            tmClose.Enabled = true;
            e.Cancel = true;
        }

        private void base_Load(object sender, EventArgs e)
        {
            tmOpen.Enabled = true;
        }
        #endregion
        #region inactive titlebars
        private void base_Activated(object sender, EventArgs e)
        {
            RPCManger.UpdateSatus(lblProg.Text, Tag.ToString());
            if (Properties.Settings.Default.graphicsFriendly == true) return;
            pnlTitle.BackColor = Color.White;
            lblProg.ForeColor = SystemColors.ControlText;
            lblProg.BackColor = pnlTitle.BackColor;
        }

        private void base_Deactivate(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.graphicsFriendly == true) return;
            pnlTitle.BackColor = Color.WhiteSmoke;
            lblProg.ForeColor = SystemColors.ControlDark;
            lblProg.BackColor = pnlTitle.BackColor;
        }
#endregion
    }
}

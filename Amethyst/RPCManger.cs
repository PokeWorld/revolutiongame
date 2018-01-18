using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amethyst
{
    static class RPCManger
    {
        static DiscordRPC.RichPresence presence = new DiscordRPC.RichPresence();
        static DiscordRPC.EventHandlers handlers;
        public static string details;
        public static string state;

        public static void start(string newDetails, string newstate)
        {
            details = newDetails;
            state = newstate;
            handlers = new DiscordRPC.EventHandlers();
            DiscordRPC.Initialize("403321568148848640", ref handlers, true, "");
            presence.details = Utf8String(details);
            presence.state = Utf8String(state);
            presence.largeImageText = Application.ProductName;
            presence.largeImageKey = "logo";
            presence.smallImageKey = "logo";
            presence.smallImageText = "Main Menu";
            presence.instance = false;
            DiscordRPC.UpdatePresence(ref presence);
            DiscordRPC.RunCallbacks();
        }

        private static UTF8Encoding UTF8 { get; } = new UTF8Encoding(false);

        public static IntPtr Utf8String(string str)
        {
            var bts = UTF8.GetBytes(str);

            var ptr = Marshal.AllocHGlobal(bts.Length + 1);
            Marshal.Copy(bts, 0, ptr, bts.Length);
            bts[0] = 0;
            Marshal.Copy(bts, 0, ptr + bts.Length, 1);

            return ptr;
        }


        public static void UpdateSatus(string newDetails, string newstate, string rpcname)
        {
            presence.details = Utf8String(newDetails);
            presence.state = Utf8String(newstate);
            presence.largeImageText = Application.ProductName;
            presence.largeImageKey = "logo";
            presence.smallImageKey = rpcname;
            presence.smallImageText = newDetails;
            presence.instance = false;
            DiscordRPC.UpdatePresence(ref presence);
            DiscordRPC.RunCallbacks();
        }

        public static void StopStatus()
        {
            DiscordRPC.Shutdown();
        }
    }
}

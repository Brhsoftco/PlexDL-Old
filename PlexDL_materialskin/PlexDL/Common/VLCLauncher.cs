using PlexDL.UI;
using PlexDL.Common.Structures;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PlexDL.Common
{
    public static class VLCLauncher
    {
        public static void LaunchVLC(DownloadInfo stream)
        {
            try
            {
                Process p = new Process();
                string vlc = Home.settings.Player.VLCMediaPlayerPath;
                string arg = Home.settings.Player.VLCMediaPlayerArgs;
                arg = arg.Replace("%TITLE%", "\"" + stream.ContentTitle + "\"");
                arg = arg.Replace("%FILE%", "\"" + stream.Link + "\"");
                p.StartInfo.FileName = vlc;
                p.StartInfo.Arguments = arg;
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred whilst trying to launch VLC\n\n" + ex.ToString(), "Launch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Home.recordException(ex.Message, "VLCLaunchError");
                return;
            }
        }
    }
}
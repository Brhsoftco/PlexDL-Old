using MaterialSkin.Controls;
using System;

namespace PlexDL.UI
{
    public partial class frmChromecast : MaterialForm
    {
        //private ObservableCollection<Chromecast> chromecasts;

        public frmChromecast()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            /*
            lstChromecasts.Items.Clear();
            chromecasts = await ChromecastService.Current.StartLocatingDevices("192.168.0.25");
            foreach (Chromecast c in chromecasts)
            {
                lstChromecasts.Items.Add(c.FriendlyName);
            }
            */
        }

        private void lstChromecasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (!(lstChromecasts.SelectedItem.ToString() == ""))
            {
                Chromecast cc = new Chromecast();
                foreach (Chromecast c in chromecasts)
                {
                    if (c.FriendlyName == lstChromecasts.SelectedItem.ToString())
                    {
                        cc = c;
                        return;
                    }
                }
                lblAddressValue.Text = cc.DeviceUri.Host;
                lblNameValue.Text = cc.FriendlyName;
                lblPortValue.Text = cc.DeviceUri.Port.ToString();
            }
            */
        }
    }
}
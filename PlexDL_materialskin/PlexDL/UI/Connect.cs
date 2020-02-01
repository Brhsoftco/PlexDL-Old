using MaterialSkin.Controls;
using PlexDL.Common;
using PlexDL.Common.Structures;
using System;
using System.Windows.Forms;

namespace PlexDL.UI
{
    public partial class Connect : MaterialForm
    {
        public ConnectionInformation ConnectionInfo { get; set; } = new ConnectionInformation();

        public AppOptions settings;

        public Timer t1 = new Timer();

        public bool connectionStarted = false;

        public Connect()
        {
            InitializeComponent();

            //Setup material design skin
            MaterialSkin.MaterialSkinManager materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            /*materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue400,MaterialSkin.Primary.Blue500,MaterialSkin.Primary.Blue500,MaterialSkin.Accent.LightBlue200,MaterialSkin.TextShade.WHITE

                );*/
        }

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }

        private void frmConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((settings.Generic.AnimationSpeed > 0) && (connectionStarted == false))
            {
                e.Cancel = true;
                t1 = new Timer();
                t1.Interval = settings.Generic.AnimationSpeed;
                t1.Tick += new EventHandler(fadeOut);  //this calls the fade out function
                t1.Start();

                if (Opacity == 0)
                {
                    //resume the event - the program can be closed
                    e.Cancel = false;
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //if (!verifyText(txtPlexIP.Text))
            //{
            //MessageBox.Show("Please enter a valid IP Address/Hostname", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            // else if (!(System.Text.RegularExpressions.Regex.IsMatch(txtPlexPort.Text, @"^\d+$")))
            //{
            //MessageBox.Show("Please enter a valid TCP Port", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }
            if (!verifyText(txtAccountToken.Text))
            {
                MessageBox.Show("Please enter a valid account token. A token must be 20 characters in length with no spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //ConnectionInfo.PlexAddress = txtPlexIP.Text;
                //ConnectionInfo.PlexPort = Convert.ToInt32(txtPlexPort.Text);
                ConnectionInfo.PlexAccountToken = txtAccountToken.Text;
                ConnectionInfo.RelaysOnly = chkRelays.Checked;
                connectionStarted = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool verifyText(string input)
        {
            int len = input.Length;
            int spacecount = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spacecount++;
                }
            }

            if ((spacecount > 0) || (input == "") || (len != 20))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            connectionStarted = false;
            settings = Home.settings;
            if (settings.Generic.AnimationSpeed > 0)
            {
                Opacity = 0;      //first the opacity is 0

                t1.Interval = settings.Generic.AnimationSpeed;  //we'll increase the opacity every 10ms
                t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity
                t1.Start();
            }
            //txtPlexIP.Text = ConnectionInfo.PlexAddress;
            //txtPlexPort.Text = ConnectionInfo.PlexPort.ToString();
            txtAccountToken.Text = ConnectionInfo.PlexAccountToken;
            chkRelays.Checked = ConnectionInfo.RelaysOnly;
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {
        }

        private void lblAccountToken_Click(object sender, EventArgs e)
        {
        }

        private void txtAccountToken_Click(object sender, EventArgs e)
        {
        }
    }
}
using MaterialSkin.Controls;
using PlexDL.Common;
using PlexDL.Common.Structures;
using PVS.MediaPlayer;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;

namespace PlexDL.UI
{
    public partial class frmPlayer : MaterialForm
    {
        public Timer t1 = new Timer();

        private Player mPlayer;

        public AppOptions settings;
        public PlexObject StreamingContent { get; set; }

        public DataTable TitlesTable;

        public string PlayingPosition, Duration;

        public frmPlayer()
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

        public XmlDocument GetXMLTransaction(string uri, string secret)
        {
            //Declare XMLResponse document
            XmlDocument XMLResponse = null;
            //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebRequest objHttpWebRequest;
            //Declare an HTTP-specific implementation of the WebResponse class
            HttpWebResponse objHttpWebResponse = null;
            //Declare a generic view of a sequence of bytes
            Stream objResponseStream = null;
            //Declare XMLReader
            XmlTextReader objXMLReader;

            string fullUri = uri + secret;

            //MessageBox.Show(uri + secret);

            //Creates an HttpWebRequest for the specified URL.
            objHttpWebRequest = (HttpWebRequest)WebRequest.Create(fullUri);

            //---------- Start HttpRequest
            try
            {
                //Set HttpWebRequest properties
                objHttpWebRequest.Method = "GET";
                //---------- End HttpRequest
                //Sends the HttpWebRequest, and waits for a response.
                objHttpWebResponse = (HttpWebResponse)objHttpWebRequest.GetResponse();
                //---------- Start HttpResponse, Return code 200
                if (objHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    //Get response stream
                    objResponseStream = objHttpWebResponse.GetResponseStream();
                    //Load response stream into XMLReader
                    objXMLReader = new XmlTextReader(objResponseStream);
                    //Declare XMLDocument
                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(objXMLReader);
                    //Set XMLResponse object returned from XMLReader
                    XMLResponse = xmldoc;
                    //Close XMLReader
                    objXMLReader.Close();
                }
                else if (objHttpWebResponse.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("The web server denied access to the resource. Check your token and try again.");
                }
                //Close Steam
                objResponseStream.Close();
                //Close HttpWebResponse
                objHttpWebResponse.Close();
            }
            finally
            {
                //Release objects
                objXMLReader = null;
                objResponseStream = null;
                objHttpWebResponse = null;
                objHttpWebRequest = null;
            }
            return XMLResponse;
        }

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {
            string FormTitle = StreamingContent.StreamInformation.ContentTitle;
            this.Text = FormTitle;
            //player.URL = StreamingContent.StreamUrl;

            settings = frmMain.settings;

            if (!Player.MFPresent) MessageBox.Show("MediaFoundation is not installed. The player will not be able to stream the selected content :(");

            mPlayer = new Player(pnlPlayer);
            mPlayer.Sliders.Position.TrackBar = trkDuration;
            mPlayer.Events.MediaPositionChanged += mPlayer_MediaPositionChanged;
            mPlayer.Events.MediaEnded += mPlayer_ContentFinished;
            mPlayer.Events.MediaStarted += mPlayer_ContentStarted;
            //MessageBox.Show(TitlesTable.Rows.Count + "\n" +StreamingContent.StreamIndex);
            //MessageBox.Show("Duration: "+StreamingContent.ContentDuration+"\nSize: "+StreamingContent.ByteLength);
        }

        private void frmPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (settings.AnimationSpeed > 0)
            {
                e.Cancel = true;
                t1 = new Timer();
                t1.Interval = settings.AnimationSpeed;
                t1.Tick += new EventHandler(fadeOut);  //this calls the fade out function
                t1.Start();

                if (Opacity == 0)
                {
                    //resume the event - the program can be closed
                    e.Cancel = false;
                }
            }
            mPlayer.Dispose();
        }

        private void mPlayer_ContentFinished(object sender, EventArgs e)
        {
            SetIconPlay();
        }

        private void mPlayer_ContentStarted(object sender, EventArgs e)
        {

        }

        private void mPlayer_MediaPositionChanged(object sender, PositionEventArgs e)
        {
            TimeSpan fromStart = TimeSpan.FromTicks(e.FromStart);
            TimeSpan toStop = TimeSpan.FromTicks(e.ToStop);

            lblTimeSoFar.Text = fromStart.ToString(@"hh\:mm\:ss");
            lblTotalDuration.Text = toStop.ToString(@"hh\:mm\:ss");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopyLink_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(StreamingContent.StreamInformation.Link);
        }

        private void tmrCopied_Tick(object sender, EventArgs e)
        {
            //btnCopyLink.Text = "Copy Stream Link";
            tmrCopied.Stop();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
        }

        private void tmrRefreshUI_Tick(object sender, EventArgs e)
        {
            /*
            PlayingPosition = CalculateTime(vdo.CurrentPosition);
            lblTimeSoFar.Text = PlayingPosition;
            pbDuration.Value = (int)vdo.CurrentPosition;
            */
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            if (mPlayer.Playing)
            {
                mPlayer.Stop();
                mPlayer.Paused = false;
                SetIconPlay();
            }
        }

        private void Play(string FileName)
        {
            PlexDL.WaitWindow.WaitWindow.Show(PlayWorker, "Loading Stream", new object[] { FileName });
        }

        private void SetIconPause()
        {
            if (btnPlayPause.InvokeRequired)
            {
                btnPlayPause.BeginInvoke((MethodInvoker)delegate
                {
                    btnPlayPause.Icon = PlexDL.Properties.Resources.baseline_pause_black_18dp;
                });
            }
            else
            {
                btnPlayPause.Icon = PlexDL.Properties.Resources.baseline_pause_black_18dp;
            }
        }

        private void SetIconPlay()
        {
            if (btnPlayPause.InvokeRequired)
            {
                btnPlayPause.BeginInvoke((MethodInvoker)delegate
                {
                    btnPlayPause.Icon = PlexDL.Properties.Resources.baseline_play_arrow_black_18dp;
                });
            }
            else
            {
                btnPlayPause.Icon = PlexDL.Properties.Resources.baseline_play_arrow_black_18dp;
            }
        }

        private delegate void SafePlayDelegate(string fileName);

        private void StartPlayer(string fileName)
        {
            if (pnlPlayer.InvokeRequired)
            {
                var d = new SafePlayDelegate(StartPlayer);
                pnlPlayer.Invoke(d, new object[] { fileName });
            }
            else
            {
                mPlayer.Play(fileName);
            }
        }
        private void PlayWorker(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            if (!mPlayer.Playing)
            {
                string FileName = (string)e.Arguments[0];
                StartPlayer(FileName);
                SetIconPause();
            }
        }

        private void btnPrevTitle_Click(object sender, EventArgs e)
        {
            Stop();
            PrevTitle();
        }

        private string getBaseUri(bool incToken)
        {
            if (incToken)
            {
                return "http://" + settings.ServerAddress + ":" + settings.ServerPort + "/?X-Plex-Token=";
            }
            else
            {
                return "http://" + settings.ServerAddress + ":" + settings.ServerPort + "/";
            }
        }

        private void GetObjectFromIndexCallback(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            int index = (int)e.Arguments[0];
            e.Result = GetObjectFromIndexWorker(index);
        }

        private PlexMovie GetObjectFromIndex(int index)
        {
            PlexMovie result = (PlexMovie)PlexDL.WaitWindow.WaitWindow.Show(GetObjectFromIndexCallback, "Getting Metadata", new object[] { index });
            return result;
        }

        private PlexMovie GetObjectFromIndexWorker(int index)
        {
            PlexMovie obj = new PlexMovie();

            DownloadInfo dlInfo = getContentDownloadInfo(index);

            obj.StreamInformation = dlInfo;
            obj.StreamIndex = index;
            return obj;
        }

        private DownloadInfo getContentDownloadInfo(int index)
        {
            if ((index + 1) <= TitlesTable.Rows.Count)
            {
                DataRow result = TitlesTable.Rows[index];
                DownloadInfo obj = new DownloadInfo();
                string key = result["key"].ToString();
                string baseUri = getBaseUri(false);
                key = key.TrimStart('/');
                string uri = baseUri + key + "/?X-Plex-Token=";

                XmlDocument reply = GetXMLTransaction(uri, settings.Token);

                obj = getContentDownloadInfo_Xml(reply);
                return obj;
            }
            else
            {
                MessageBox.Show("Index was higher than row count; could not process data.","Data Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return new DownloadInfo();
            }
        }

        private DownloadInfo getContentDownloadInfo_Xml(XmlDocument xml)
        {
            DownloadInfo obj = new DownloadInfo();

            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(xml));

            DataTable part = sections.Tables["Part"];
            DataRow video = sections.Tables["Video"].Rows[0];
            string title = video["title"].ToString();
            if (title.Length > settings.DefaultStringLength)
                title = title.Substring(0, settings.DefaultStringLength);
            string thumb = video["thumb"].ToString();
            string thumbnailFullUri = "";
            if (!(thumb == ""))
            {
                string baseUri = getBaseUri(false).TrimEnd('/');
                thumbnailFullUri = baseUri + thumb + "?X-Plex-Token=" + settings.Token;
            }

            DataRow partRow = part.Rows[0];

            string filePart = partRow["key"].ToString();
            string container = partRow["container"].ToString();
            long byteLength = Convert.ToInt64(partRow["size"]);
            int contentDuration = Convert.ToInt32(partRow["duration"]);
            string fileName = Common.Methods.removeIllegalCharacters(title + "." + container);

            string link = getBaseUri(false).TrimEnd('/') + filePart + "/?X-Plex-Token=" + settings.Token;
            obj.Link = link;
            obj.Container = container;
            obj.ByteLength = byteLength;
            obj.ContentDuration = contentDuration;
            obj.FileName = fileName;
            obj.ContentTitle = title;
            obj.ContentThumbnailUri = thumbnailFullUri;

            return obj;
        }

        private void btnNextTitle_Click(object sender, EventArgs e)
        {
            Stop();
            NextTitle();
        }

        private void NextTitle()
        {
            if (((StreamingContent.StreamIndex + 1) < TitlesTable.Rows.Count))
            {
                PlexMovie next = GetObjectFromIndex(StreamingContent.StreamIndex + 1);
                StreamingContent = next;
                string FormTitle = StreamingContent.StreamInformation.ContentTitle;
                this.Text = FormTitle;
                this.Refresh();
                //MessageBox.Show(StreamingContent.StreamIndex + "\n" + TitlesTable.Rows.Count);
            }
            else if ((StreamingContent.StreamIndex + 1) == TitlesTable.Rows.Count)
            {
                PlexMovie next = GetObjectFromIndex(0);
                StreamingContent = next;
                string FormTitle = StreamingContent.StreamInformation.ContentTitle;
                this.Text = FormTitle;
                this.Refresh();
                //MessageBox.Show(StreamingContent.StreamIndex + "\n" + TitlesTable.Rows.Count);
            }
        }

        private void PrevTitle()
        {
            if (StreamingContent.StreamIndex != 0)
            {
                PlexMovie next = GetObjectFromIndex(StreamingContent.StreamIndex - 1);
                StreamingContent = next;
                string FormTitle = StreamingContent.StreamInformation.ContentTitle;
                this.Text = FormTitle;
                this.Refresh();
                //MessageBox.Show(StreamingContent.StreamIndex + "\n" + TitlesTable.Rows.Count);
            }
            else
            {
                PlexMovie next = GetObjectFromIndex(TitlesTable.Rows.Count - 1);
                StreamingContent = next;
                string FormTitle = StreamingContent.StreamInformation.ContentTitle;
                this.Text = FormTitle;
                this.Refresh();
                //MessageBox.Show(StreamingContent.StreamIndex + "\n" + TitlesTable.Rows.Count);
            }
        }

        private void btnSkipBack_Click(object sender, EventArgs e)
        {
            if (mPlayer.Playing)
            {
                decimal rewindAmount = (settings.SkipBackwardInterval) * -1;

                mPlayer.Position.Skip((int)rewindAmount);
            }
        }

        private void btnSkipForward_Click(object sender, EventArgs e)
        {
            if (mPlayer.Playing)
            {
                decimal stepAmount = settings.SkipForwardInterval;

                mPlayer.Position.Skip((int)stepAmount);
            }
        }

        private void Resume()
        {
            if ((mPlayer.Playing) && (mPlayer.Paused))
            {
                mPlayer.Resume();
                SetIconPause();
            }
        }

        private void Pause()
        {
            if ((mPlayer.Playing) && (!mPlayer.Paused))
            {
                mPlayer.Pause();
                SetIconPlay();
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if ((mPlayer.Playing) && (!mPlayer.Paused))
            {
                Pause();
            }
            else
            {
                if (mPlayer.Paused)
                {
                    Resume();
                }
                else
                {
                    Play(StreamingContent.StreamInformation.Link);
                }
            }
        }
    }
}
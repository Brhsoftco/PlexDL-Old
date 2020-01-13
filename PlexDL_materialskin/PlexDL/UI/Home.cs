using libbrhscgui.Components;
using MaterialSkin.Controls;
using PlexAPI;
using PlexDL.Common;
using PlexDL.Common.Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

//using System.Threading.Tasks;

namespace PlexDL.UI
{
    public partial class frmMain : MaterialForm
    {
        #region GlobalVariables

        #region GlobalComponentVariables

        public readonly UserInteraction objUI = new UserInteraction();
        public Timer t1 = new Timer();
        public frmDownloadManager DownloadManager = new frmDownloadManager();
        public User user = new User();
        public Server svr;

        #endregion GlobalComponentVariables

        #region GlobalStringVariables

        public string uri = "";

        #endregion GlobalStringVariables

        #region GlobalBoolVariables

        public bool connected = false;
        public bool InitialFill = true;
        public bool libraryFilled = false;
        public bool IsFiltered = false;
        public bool IsTVShow = false;
        public bool DownloadQueueCancelled = false;
        public bool DownloadAllEpisodes = false;
        public bool downloadIsRunning = false;
        public bool downloadIsPaused = false;
        public bool msgAlreadyShown = false;
        public bool doNotAttemptAgain = false;

        #endregion GlobalBoolVariables

        #region GlobalIntVariables

        public int selectedIndex = 0;
        public int DownloadIndex = 0;
        public int DownloadTotal = 0;
        public int logIncrementer = 0;
        public int downloadsSoFar = 0;
        public int alreadyMarkedProgressNumber = 0;

        #endregion GlobalIntVariables

        #region GlobalStaticVariables

        public static AltoHttp.DownloadQueue engine;
        public static List<DownloadInfo> queue;
        public static AppOptions settings = new AppOptions();
        public static MyPlex plex = new MyPlex();

        #endregion GlobalStaticVariables

        #region GlobalXmlDocumentVariables

        public XmlDocument contentXmlDoc;
        public XmlDocument libraryXmlDoc;

        #endregion GlobalXmlDocumentVariables

        #region GlobalDataTableVariables

        public DataTable titlesTable = null;
        public DataTable filteredTable = null;
        public DataTable seriesTable = null;
        public DataTable episodesTable = null;
        public DataTable gSectionsTable = null;

        #endregion GlobalDataTableVariables

        #region GlobalListVariables

        public List<Server> plexServers = null;

        #endregion GlobalListVariables

        #endregion GlobalVariables

        #region Form

        #region FormInitialiser

        public frmMain()
        {
            InitializeComponent();

            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgvLibrary.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgvLibrary, true, null);
            }

            //Setup material design skin
            MaterialSkin.MaterialSkinManager materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            /*materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue400,MaterialSkin.Primary.Blue500,MaterialSkin.Primary.Blue500,MaterialSkin.Accent.LightBlue200,MaterialSkin.TextShade.WHITE

                );*/
            lstLog.Padding = new System.Windows.Forms.Padding(10);
        }

        #endregion FormInitialiser

        #region FormAnimationMethods

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

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        #endregion FormAnimationMethods

        #endregion Form

        #region XML/Metadata

        #region PlexMovieBuilders

        private PlexMovie GetObjectFromSelection()
        {
            PlexMovie obj = new PlexMovie();
            if (dgvContent.SelectedRows.Count == 1)
            {
                int index = dgvContent.CurrentCell.RowIndex;
                obj = GetObjectFromIndex(index);
            }
            return obj;
        }

        private PlexTVShow GetTVObjectFromSelection()
        {
            PlexTVShow obj = new PlexTVShow();
            if (dgvContent.SelectedRows.Count == 1)
            {
                int index = dgvEpisodes.CurrentCell.RowIndex;
                obj = GetTVObjectFromIndex(index);
            }
            return obj;
        }
        private PlexTVShow GetTVObjectFromIndex(int index)
        {
            PlexTVShow obj = new PlexTVShow();
            XmlDocument metadata;
            if (dgvContent.SelectedRows.Count == 1)
            {
                addToLog("Content Parse Started");
                addToLog("Grabbing Titles");
                DataRow infRow;

                metadata = GetEpisodeMetadata(index);

                infRow = returnCorrectTable().Rows[index];

                DownloadInfo dlInfo = getContentDownloadInfo_Xml(metadata);

                addToLog("Assembling Object");

                obj.ContentGenre = getContentGenre(metadata);
                obj.StreamInformation = dlInfo;
                obj.ContentDuration = dlInfo.ContentDuration;
                obj.StreamPosterUri = getContentThumbnailUri(metadata);
                obj.Season = getTVShowSeason(metadata);
                obj.EpisodesInSeason = episodesTable.Rows.Count;
                obj.TVShowName = getTVShowTitle(metadata);
                obj.StreamResolution = getContentResolution(metadata);
                obj.StreamIndex = index;
            }
            return obj;
        }
        private PlexMovie GetObjectFromIndex(int index)
        {
            PlexMovie obj = new PlexMovie();
            XmlDocument metadata;
            if (dgvContent.SelectedRows.Count == 1)
            {
                addToLog("Content Parse Started");
                addToLog("Grabbing Titles");
                DataRow infRow;

                if (IsTVShow)
                {
                    metadata = GetEpisodeMetadata(index);
                }
                else
                {
                    metadata = GetContentMetadata(index);
                }

                infRow = returnCorrectTable().Rows[index];

                DownloadInfo dlInfo = getContentDownloadInfo_Xml(metadata);

                addToLog("Assembling Object");

                obj.Actors = getActorsFromMetadata(metadata);
                obj.ContentGenre = getContentGenre(metadata);
                obj.StreamInformation = dlInfo;
                obj.ContentDuration = dlInfo.ContentDuration;
                obj.StreamPosterUri = getContentThumbnailUri(metadata);

                obj.StreamResolution = getContentResolution(metadata);
                if (IsFiltered)
                {
                    obj.TitlesTable = filteredTable;
                }
                else
                {
                    obj.TitlesTable = titlesTable;
                }
                obj.StreamIndex = index;
            }
            return obj;
        }

        #endregion PlexMovieBuilders

        #region KeyGatherers

        private string getLibraryKey(System.Xml.XmlDocument doc)
        {
            string key = "";

            using (XmlReader reader = new XmlNodeReader(doc))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag
                        switch (reader.Name.ToString())
                        {
                            case "Directory":
                                if (reader.GetAttribute("title") == "library")
                                {
                                    string localKey = reader.GetAttribute("key");
                                    key = localKey;
                                }
                                break;
                        }
                    }
                }
                return key;
            }
        }

        private string getSectionKey(System.Xml.XmlDocument doc)
        {
            string key = "";

            addToLog("Parsing XML Reply");
            using (XmlReader reader = new XmlNodeReader(doc))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        addToLog("Checking for directories");
                        //return only when you have START tag
                        switch (reader.Name.ToString())
                        {
                            case "Directory":
                                if (reader.GetAttribute("title") == "Library Sections")
                                {
                                    string localKey = reader.GetAttribute("key");
                                    key = localKey;
                                    addToLog("Found " + key);
                                }
                                break;
                        }
                    }
                }
                return key;
            }
        }

        #endregion KeyGatherers

        #region GetXMLTransaction

        public XmlDocument GetXMLTransaction(string uri)
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

            string secret2 = MatchUriToToken(uri);
            string fullUri = uri + secret2;

            //MessageBox.Show(fullUri);

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
                    doNotAttemptAgain = false;
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

                recordTransaction(fullUri, ((int)objHttpWebResponse.StatusCode).ToString());
            }
            catch (Exception ex)
            {
                recordTransaction(fullUri, "Undetermined");
                MessageBox.Show("Error Occurred in XML Transaction\n\n" + ex.ToString(), "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doNotAttemptAgain = true;
                return new XmlDocument();
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

        #endregion GetXMLTransaction

        #region MetadataGatherers

        public XmlDocument getTVShowMetadata(int index)
        {
            addToLog("Sorting existing data");

            DataRow result;

            result = seriesTable.Rows[index];

            string key = result["key"].ToString();
            string baseUri = getBaseUri(false);
            key = key.TrimStart('/');
            string uri = baseUri + key + "/?X-Plex-Token=";

            addToLog("Contacting server");
            XmlDocument reply = GetXMLTransaction(uri);
            return reply;
        }

        public XmlDocument GetContentMetadata(int index)
        {
            addToLog("Sorting existing data");

            DataRow result;

            if (IsFiltered)
            {
                result = filteredTable.Rows[index];
            }
            else
            {
                result = titlesTable.Rows[index];
            }

            string key = result["key"].ToString();
            string baseUri = getBaseUri(false);
            key = key.TrimStart('/');
            string uri = baseUri + key + "/?X-Plex-Token=";

            addToLog("Contacting server");
            XmlDocument reply = GetXMLTransaction(uri);
            return reply;
        }

        public XmlDocument GetEpisodeMetadata(int index)
        {
            addToLog("Sorting existing data");

            DataRow result;

            result = episodesTable.Rows[index];

            string key = result["key"].ToString();
            string baseUri = getBaseUri(false);
            key = key.TrimStart('/');
            string uri = baseUri + key + "/?X-Plex-Token=";

            addToLog("Contacting server");
            XmlDocument reply = GetXMLTransaction(uri);
            return reply;
        }

        #endregion MetadataGatherers

        #region XMLGatherers

        public XmlDocument GetSeriesXml(int index)
        {
            addToLog("Sorting existing data");

            DataRow result;

            if (IsFiltered)
            {
                result = filteredTable.Rows[index];
            }
            else
            {
                result = titlesTable.Rows[index];
            }

            string key = result["key"].ToString();
            string baseUri = getBaseUri(false);
            key = key.TrimStart('/');
            string uri = baseUri + key + "/?X-Plex-Token=";

            //MessageBox.Show(uri);

            addToLog("Contacting server");
            XmlDocument reply = GetXMLTransaction(uri);
            return reply;
        }

        public XmlDocument GetEpisodeXml(int index)
        {
            addToLog("Sorting existing data");

            DataRow result;
            result = seriesTable.Rows[index];

            string key = result["key"].ToString();
            string baseUri = getBaseUri(false);
            key = key.TrimStart('/');
            string uri = baseUri + key + "/?X-Plex-Token=";

            //MessageBox.Show(uri);

            addToLog("Contacting server");
            XmlDocument reply = GetXMLTransaction(uri);
            return reply;
        }

        #endregion XMLGatherers

        #region MetadataParsers

        private List<PlexActor> getActorsFromMetadata(XmlDocument metadata)
        {
            List<PlexActor> actors = new List<PlexActor>();

            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(metadata));
            DataTable dtActors = sections.Tables["Role"];

            if (!(dtActors == null))
            {
                foreach (DataRow r in dtActors.Rows)
                {
                    PlexActor a = new PlexActor();
                    if (!(r["thumb"].ToString() == string.Empty))
                    {
                        a.ThumbnailUri = r["thumb"].ToString();
                    }
                    else
                    {
                        a.ThumbnailUri = "";
                    }
                    a.ActorRole = r["role"].ToString();
                    a.ActorName = r["tag"].ToString();
                    actors.Add(a);
                }
            }

            return actors;
        }

        private Resolution getContentResolution(XmlDocument metadata)
        {
            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(metadata));
            DataTable video = sections.Tables["Media"];
            DataRow row = video.Rows[0];
            int width = Convert.ToInt32(row["width"]);
            int height = Convert.ToInt32(row["height"]);
            Resolution result = new Resolution()
            {
                Width = width,
                Height = height
            };
            return result;
        }

        private string getContentGenre(XmlDocument metadata)
        {
            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(metadata));
            DataTable video = sections.Tables["Genre"];
            string genre = "Unknown";
            if (!(video == null))
            {
                DataRow row = video.Rows[0];
                genre = row["tag"].ToString();
            }
            return genre;
        }

        private string getTVShowSeason(XmlDocument metadata)
        {
            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(metadata));
            DataTable video = sections.Tables["Video"];
            string season = "Unknown Season";
            if (!(video == null))
            {
                DataRow row = video.Rows[0];
                season = row["parentTitle"].ToString();
            }
            return season;
        }

        private string getTVShowTitle(XmlDocument metadata)
        {
            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(metadata));
            DataTable video = sections.Tables["Video"];
            string title = "Unknown Title";
            if (!(video == null))
            {
                DataRow row = video.Rows[0];
                title = row["grandparentTitle"].ToString();
            }
            return title;
        }

        private string getContentThumbnailUri(XmlDocument metadata)
        {
            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(metadata));
            DataTable video = sections.Tables["Video"];
            DataRow row = video.Rows[0];
            string thumb = row["thumb"].ToString();
            string fullUri = "";
            if (!(thumb == ""))
            {
                string baseUri = getBaseUri(false).TrimEnd('/');
                fullUri = baseUri + thumb + "?X-Plex-Token=" + getToken();
            }
            return fullUri;
        }

        private DataTable returnCorrectTable()
        {
            if (IsTVShow)
            {
                return episodesTable;
            }
            else
            {
                return titlesTable;
            }
        }

        #endregion MetadataParsers

        #endregion XML/Metadata

        #region Helpers

        #region StringIntHelpers

        private string getToken()
        {
            int index = dgvServers.CurrentCell.RowIndex;
            Server s = plexServers[index];
            return s.accessToken;
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

        private string MatchUriToToken(string uri)
        {
            foreach (Server s in plexServers)
            {
                string serverUri = "http://" + s.address + ":" + s.port + "/";
                if (uri.Contains(serverUri))
                {
                    return s.accessToken;
                }
            }
            return "";
        }

        public string GetFileExtensionFromUrl(string url)
        {
            url = url.Split('?')[0];
            url = url.Split('/').Last();
            string final = url.Contains('.') ? url.Substring(url.LastIndexOf('.')) : "";
            addToLog("Extension parse: " + final);
            return final;
        }

        private int GetSelectedIndex()
        {
            return selectedIndex;
        }

        #endregion StringIntHelpers

        #region ProfileHelpers

        public void loadProfile()
        {
            if (ofdLoadProfile.ShowDialog() == DialogResult.OK)
            {
                doLoadProfile(ofdLoadProfile.FileName);
            }
        }

        public void saveProfile()
        {
            if (!(settings.ServerAddress == ""))
            {
                if (sfdSaveProfile.ShowDialog() == DialogResult.OK)
                {
                    doSaveProfile(sfdSaveProfile.FileName);
                }
            }
            else
            {
                MessageBox.Show("You need to specify the server's IP address before saving a profile", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void doSaveProfile(string fileName, bool silent = false)
        {
            try
            {
                var subReq = settings;
                XmlSerializer xsSubmit = new XmlSerializer(typeof(AppOptions));
                XmlWriterSettings xmlSettings = new XmlWriterSettings();
                xmlSettings.Indent = true;
                xmlSettings.IndentChars = ("\t");
                xmlSettings.OmitXmlDeclaration = false;
                using (var sww = new StringWriter())
                {
                    using (XmlWriter writer = XmlWriter.Create(sww, xmlSettings))
                    {
                        xsSubmit.Serialize(sww, settings);

                        File.WriteAllText(fileName, sww.ToString());
                    }
                }

                if (!silent)
                {
                    MessageBox.Show("Successfully saved profile!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                addToLog("Saved profile " + fileName);
            }
            catch (Exception ex)
            {
                if (!silent)
                {
                    MessageBox.Show(ex.ToString(), "Error in saving XML Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }

        public void doLoadProfile(string fileName, bool silent = false)
        {
            try
            {
                AppOptions subReq = null;

                XmlSerializer serializer = new XmlSerializer(typeof(AppOptions));

                StreamReader reader = new StreamReader(fileName);
                subReq = (AppOptions)serializer.Deserialize(reader);
                reader.Close();

                settings = subReq;

                if (!silent)
                {
                    MessageBox.Show("Successfully loaded profile!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                addToLog("Loaded profile " + fileName);
            }
            catch (Exception ex)
            {
                if (!silent)
                {
                    MessageBox.Show(ex.ToString(), "Error in loading XML Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }

        #endregion ProfileHelpers

        #region ConnectionHelpers

        private void Disconnect()
        {
            if (connected)
            {
                if (engine != null)
                {
                    CancelDownload();
                }
                dgvLibrary.DataSource = null;
                dgvContent.DataSource = null;
                dgvServers.DataSource = null;
                dgvSeasons.DataSource = null;
                dgvEpisodes.DataSource = null;
                SetProgressLabel("Disconnected");
                SetConnect();
                connected = false;
            }
        }

        private void Connect()
        {
            try
            {
                using (frmConnect frm = new frmConnect())
                {
                    ConnectionInformation existingInfo = new ConnectionInformation();
                    existingInfo.PlexAccountToken = settings.Token;
                    frm.ConnectionInfo = existingInfo;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ConnectionInformation result = frm.ConnectionInfo;
                        settings.ServerAddress = result.PlexAddress;
                        settings.ServerPort = result.PlexPort;
                        settings.Token = result.PlexAccountToken;
                        user.authenticationToken = settings.Token;
                        object serversResult = PlexDL.WaitWindow.WaitWindow.Show(GetServerListWorker, "Getting Servers");
                        List<Server> servers = (List<Server>)serversResult;
                        if (servers.Count == 0)
                        {
                            DialogResult msg = MessageBox.Show("No servers found for entered account token. Would you like to try a direct connection?", "Authentication Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (msg == DialogResult.Yes)
                            {
                                using (DirectConnect frmDir = new DirectConnect())
                                {
                                    frmDir.ConnectionInfo.PlexAccountToken = user.authenticationToken;
                                    if (frmDir.ShowDialog() == DialogResult.OK)
                                    {
                                        settings.ServerAddress = frmDir.ConnectionInfo.PlexAddress;
                                        settings.ServerPort = frmDir.ConnectionInfo.PlexPort;
                                        Server s = new Server()
                                        {
                                            accessToken = user.authenticationToken,
                                            address = settings.ServerAddress,
                                            port = settings.ServerPort,
                                            name = "DirectConnect"
                                        };
                                        servers.Add(s);
                                        plexServers = servers;
                                        renderServersView(servers);
                                    }
                                }
                            }
                            else if (msg == DialogResult.No)
                            {
                                return;
                            }
                        }
                        else
                        {
                            plexServers = servers;
                            renderServersView(servers);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error:\n\n" + ex.ToString(), "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetContentGridViews();
                SetConnect();
            }
        }

        private void doConnectFromSelectedServer()
        {
            if (!doNotAttemptAgain)
            {
                int index = dgvServers.CurrentCell.RowIndex;
                Server s = plexServers[index];
                string address = s.address;
                int port = s.port;

                settings.ServerAddress = address;
                settings.ServerPort = port;
                settings.Token = getToken();
                string uri = getBaseUri(true);
                XmlDocument reply = (XmlDocument)PlexDL.WaitWindow.WaitWindow.Show(GetXMLTransactionWorker, "Connecting", new object[] { uri });
                connected = true;
                if (settings.ShowConnectionSuccess)
                {
                    MessageBox.Show("Connection successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SetProgressLabel("Connected");
                SetDisconnect();
                if (reply.ChildNodes.Count != 0)
                {
                    populateLibrary(reply);
                }
                doNotAttemptAgain = true;
            }
        }

        #endregion ConnectionHelpers

        #endregion Helpers

        #region Workers

        #region UpdateWorkers

        private void populateLibraryWorker(XmlDocument doc)
        {
            try
            {
                DGVServersEnabled(false);
                addToLog("Library population requested");
                string libraryDir = getLibraryKey(doc).TrimEnd('/');
                string baseUri = getBaseUri(false);
                string uriSectionKey = baseUri + libraryDir + "/?X-Plex-Token=";
                //MessageBox.Show(uriSectionKey + token);
                System.Xml.XmlDocument xmlSectionKey = GetXMLTransaction(uriSectionKey);

                string sectionDir = getSectionKey(xmlSectionKey).TrimEnd('/');
                string uriSections = baseUri + libraryDir + "/" + sectionDir + "/?X-Plex-Token=";
                //MessageBox.Show(uriSections+token);
                System.Xml.XmlDocument xmlSections = GetXMLTransaction(uriSections);

                addToLog("Creating new datasets");
                DataSet sections = new DataSet();
                sections.ReadXml(new XmlNodeReader(xmlSections));

                DataTable sectionsTable;
                sectionsTable = sections.Tables["Directory"];
                gSectionsTable = sectionsTable;

                addToLog("Binding to grid");
                renderLibraryView(sectionsTable);

                libraryFilled = true;

                uri = baseUri + libraryDir + "/" + sectionDir + "/";

                addToLog("Requesting ibrary contents");

                int index = dgvLibrary.CurrentCell.RowIndex;
                DataRow r = sectionsTable.Rows[index];
                string key = r["key"].ToString();
                string contentUri = uri + key + "/all/?X-Plex-Token=";
                XmlDocument contentXml = GetXMLTransaction(contentUri);

                contentXmlDoc = contentXml;

                //update content view, because when we updated this list, we selected the first row automatically.
                if (dgvLibrary.SelectedRows.Count == 1)
                {
                    string type = r["type"].ToString();
                    if (type == "show")
                    {
                        updateContentView(contentXml, true);
                    }
                    else if (type == "movie")
                    {
                        updateContentView(contentXml, false);
                    }
                }
                DGVServersEnabled(true);
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    recordTransaction(response.ResponseUri.ToString(), ((int)response.StatusCode).ToString());
                    if (response != null)
                    {
                        switch ((int)response.StatusCode)
                        {
                            case 401:
                                MessageBox.Show("The web server denied access to the resource. Check your token and try again. (401)");
                                break;

                            case 404:
                                MessageBox.Show("The web server couldn't serve the request because it couldn't find the resource specified. (404)");
                                break;

                            case 400:
                                MessageBox.Show("The web server couldn't serve the request because the request was bad. (400)");
                                break;
                        }
                    }
                    else
                    {
                        // no http status code available
                    }
                }
                else
                {
                    // no http status code available
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void updateContentViewWorker(XmlDocument doc, bool isTVShow)
        {
            DGVLibraryEnabled(false);

            addToLog("Updating library contents");

            // Double buffering can make DGV slow in remote desktop
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgvLibrary.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgvLibrary, true, null);
            }

            IsTVShow = isTVShow;

            dgvLibrary.ScrollBars = ScrollBars.None;

            addToLog("Creating datasets");
            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(doc));

            if (isTVShow)
            {
                titlesTable = sections.Tables["Directory"];
            }
            else
            {
                titlesTable = sections.Tables["Video"];
            }
            addToLog("Cleaning unwanted data");

            addToLog("Binding to grid");
            renderContentView(titlesTable);

            contentXmlDoc = doc;

            DGVLibraryEnabled(true);

            //MessageBox.Show("ContentTable: " + contentTable.Rows.Count.ToString() + "\nTitlesTable: " + titlesTable.Rows.Count.ToString());
        }

        private void updateEpisodeViewWorker(XmlDocument doc)
        {
            DGVSeasonsEnabled(false);
            addToLog("Updating episode contents");

            // Double buffering can make DGV slow in remote desktop
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgvLibrary.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgvLibrary, true, null);
            }

            addToLog("Creating datasets");
            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(doc));

            episodesTable = sections.Tables["Video"];

            addToLog("Cleaning unwanted data");

            addToLog("Binding to grid");
            renderEpisodesView(episodesTable);

            contentXmlDoc = doc;

            DGVSeasonsEnabled(true);

            //MessageBox.Show("ContentTable: " + contentTable.Rows.Count.ToString() + "\nTitlesTable: " + titlesTable.Rows.Count.ToString());
        }

        private void updateSeriesViewWorker(XmlDocument doc)
        {
            DGVContentEnabled(false);
            addToLog("Updating series contents");

            // Double buffering can make DGV slow in remote desktop
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgvLibrary.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgvLibrary, true, null);
            }

            addToLog("Creating datasets");
            DataSet sections = new DataSet();
            sections.ReadXml(new XmlNodeReader(doc));

            seriesTable = sections.Tables["Directory"];

            addToLog("Cleaning unwanted data");

            addToLog("Binding to grid");
            renderSeriesView(seriesTable);

            contentXmlDoc = doc;

            DGVContentEnabled(true);

            //MessageBox.Show("ContentTable: " + contentTable.Rows.Count.ToString() + "\nTitlesTable: " + titlesTable.Rows.Count.ToString());
        }

        #endregion UpdateWorkers

        #region BackgroundWorkers

        private void wkrGetMetadata_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!System.IO.Directory.Exists(settings.DownloadDirectory))
                System.IO.Directory.CreateDirectory(settings.DownloadDirectory);
            if (!System.IO.Directory.Exists(settings.DownloadDirectory + @"\TV"))
                System.IO.Directory.CreateDirectory(settings.DownloadDirectory + @"\TV");
            if (!System.IO.Directory.Exists(settings.DownloadDirectory + @"\Movies"))
                System.IO.Directory.CreateDirectory(settings.DownloadDirectory + @"\Movies");
            if (IsTVShow)
            {
                if (DownloadAllEpisodes)
                {
                    int index = 0;
                    foreach (DataRow r in episodesTable.Rows)
                    {
                        decimal percent = Math.Round(((decimal)index + 1) / episodesTable.Rows.Count) * 100;
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            lblProgress.Text = "Getting Metadata " + (index + 1) + "/" + episodesTable.Rows.Count;
                        });
                        PlexTVShow show = GetTVObjectFromIndex(index);
                        DownloadInfo dlInfo = show.StreamInformation;
                        TVShowDirectoryLayout dir = DownloadLayouts.CreateDownloadLayoutTVShow(show, settings, DownloadLayouts.PlexStandardLayout);
                        dlInfo.DownloadPath = dir.SeasonPath;
                        queue.Add(dlInfo);
                        index += 1;
                    }
                }
                else
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        lblProgress.Text = "Getting Metadata";
                    });
                    PlexTVShow show = GetTVObjectFromSelection();
                    DownloadInfo dlInfo = show.StreamInformation;
                    TVShowDirectoryLayout dir = DownloadLayouts.CreateDownloadLayoutTVShow(show, settings, DownloadLayouts.PlexStandardLayout);
                    dlInfo.DownloadPath = dir.SeasonPath;
                    queue.Add(dlInfo);
                }
            }
            else
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    lblProgress.Text = "Getting Metadata";
                });
                PlexMovie movie = GetObjectFromSelection();
                DownloadInfo dlInfo = movie.StreamInformation;
                dlInfo.DownloadPath = settings.DownloadDirectory + @"\Movies";
                queue.Add(dlInfo);
            }
            this.BeginInvoke((MethodInvoker)delegate
            {
                MessageBox.Show(queue[0].DownloadPath + @"\" + queue[0].FileName);
            });
            this.BeginInvoke((MethodInvoker)delegate
            {
                StartDownload(queue, settings.DownloadDirectory);
            });
        }

        #endregion BackgroundWorkers

        #region UpdateCallbackWorkers

        private void WorkerUpdateContentView(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            XmlDocument doc = (XmlDocument)e.Arguments[0];
            updateContentViewWorker(doc, (bool)e.Arguments[1]);
        }

        private void WorkerRenderContentView(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            DataTable t = (DataTable)e.Arguments[0];
            renderContentView(t);
        }

        private void WorkerUpdateLibraryView(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            XmlDocument doc = (XmlDocument)e.Arguments[0];
            populateLibraryWorker(doc);
        }

        private void WorkerUpdateSeriesView(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            XmlDocument doc = (XmlDocument)e.Arguments[0];
            updateSeriesViewWorker(doc);
        }

        private void WorkerUpdateEpisodesView(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            XmlDocument doc = (XmlDocument)e.Arguments[0];
            updateEpisodeViewWorker(doc);
        }

        private void WorkerUpdateServersView(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            List<Server> servers = (List<Server>)e.Arguments[0];
            renderServersViewWorker(servers);
        }

        #endregion UpdateCallbackWorkers

        #region ContentRenderers

        private void renderContentView(DataTable content)
        {
            DataColumn Title = new DataColumn("Title", typeof(string));
            DataColumn Studio = new DataColumn("Studio", typeof(string));
            DataColumn Year = new DataColumn("Year", typeof(string));
            DataColumn Rating = new DataColumn("Rating", typeof(string));

            DataTable dgvBind = new DataTable("Content");
            dgvBind.Columns.Add(Title);
            dgvBind.Columns.Add(Studio);
            dgvBind.Columns.Add(Year);
            dgvBind.Columns.Add(Rating);

            int i = 0;
            if (!(content == null))
            {
                foreach (DataRow r1 in content.Rows)
                {
                    i += 1;

                    string rating = "?";
                    string studio = "?";
                    string year = "?";
                    string title = "?";
                    if (content.Columns.Contains("contentRating"))
                        if (!(r1["contentRating"] == null))
                            rating = r1["contentRating"].ToString();
                    if (content.Columns.Contains("studio"))
                        if (!(r1["studio"] == null))
                            studio = r1["studio"].ToString();
                    if (content.Columns.Contains("year"))
                        if (!(r1["year"] == null))
                            year = r1["year"].ToString();
                    if (content.Columns.Contains("title"))
                        if (!(r1["title"] == null))
                            title = r1["title"].ToString();

                    dgvBind.Rows.Add(title, studio, year, rating);
                }

                if (dgvContent.InvokeRequired)
                {
                    dgvContent.BeginInvoke((MethodInvoker)delegate
                    {
                        dgvContent.DataSource = dgvBind;
                        dgvContent.Refresh();
                    });
                }
                else
                {
                    dgvContent.DataSource = dgvBind;
                    dgvContent.Refresh();
                }
            }
        }

        private void renderSeriesView(DataTable content)
        {
            DataColumn Title = new DataColumn("Season", typeof(string));
            DataColumn TVShow = new DataColumn("TV Show", typeof(string));

            DataTable dgvBind = new DataTable("Seasons");
            dgvBind.Columns.Add(Title);
            dgvBind.Columns.Add(TVShow);

            int i = 0;
            foreach (DataRow r1 in content.Rows)
            {
                i += 1;

                string tvshow = "";
                string title = "";
                if (content.Columns.Contains("title"))
                    if (!(r1["title"] == null))
                        title = r1["title"].ToString();
                if (content.Columns.Contains("parentTitle"))
                    if (!(r1["parentTitle"] == null))
                        tvshow = r1["parentTitle"].ToString();

                dgvBind.Rows.Add(title, tvshow);
            }
            if (dgvSeasons.InvokeRequired)
            {
                dgvSeasons.BeginInvoke((MethodInvoker)delegate
                {
                    dgvSeasons.DataSource = dgvBind;
                    dgvSeasons.Refresh();
                });
            }
            else
            {
                dgvSeasons.DataSource = dgvBind;
                dgvSeasons.Refresh();
            }
        }

        private void renderEpisodesView(DataTable content)
        {
            DataColumn Title = new DataColumn("Title", typeof(string));
            DataColumn Year = new DataColumn("Year", typeof(string));
            DataColumn Rating = new DataColumn("Rating", typeof(string));

            DataTable dgvBind = new DataTable("Episodes");
            dgvBind.Columns.Add(Title);
            dgvBind.Columns.Add(Year);
            dgvBind.Columns.Add(Rating);

            int i = 0;
            foreach (DataRow r1 in content.Rows)
            {
                i += 1;

                string rating = "";
                string title = "";
                string year = "";
                if (content.Columns.Contains("title"))
                    if (!(r1["title"] == null))
                        title = r1["title"].ToString();
                if (content.Columns.Contains("contentRating"))
                    if (!(r1["contentRating"] == null))
                        rating = r1["contentRating"].ToString();
                if (content.Columns.Contains("year"))
                    if (!(r1["year"] == null))
                        year = r1["year"].ToString();

                dgvBind.Rows.Add(title, year, rating);
            }
            if (dgvEpisodes.InvokeRequired)
            {
                dgvEpisodes.BeginInvoke((MethodInvoker)delegate
                {
                    dgvEpisodes.DataSource = dgvBind;
                    dgvEpisodes.Refresh();
                });
            }
            else
            {
                dgvEpisodes.DataSource = dgvBind;
                dgvEpisodes.Refresh();
            }
        }

        private void renderServersView(List<Server> servers)
        {
            PlexDL.WaitWindow.WaitWindow.Show(this.WorkerUpdateServersView, "Updating Servers", new object[] { servers });
        }

        private void renderServersViewWorker(List<Server> servers)
        {
            DataColumn Name = new DataColumn("Name", typeof(string));
            DataColumn Address = new DataColumn("Address", typeof(string));
            DataColumn Port = new DataColumn("Port", typeof(string));

            DataTable dgvBind = new DataTable("Servers");
            dgvBind.Columns.Add(Name);
            dgvBind.Columns.Add(Address);
            dgvBind.Columns.Add(Port);

            int i = 0;
            foreach (Server r1 in servers)
            {
                i += 1;

                dgvBind.Rows.Add(r1.name, r1.address, r1.port.ToString());
            }
            if (dgvServers.InvokeRequired)
            {
                dgvServers.BeginInvoke((MethodInvoker)delegate
                {
                    dgvServers.DataSource = dgvBind;
                    dgvServers.Refresh();
                    doConnectFromSelectedServer();
                });
            }
            else
            {
                dgvServers.DataSource = dgvBind;
                dgvServers.Refresh();
                doConnectFromSelectedServer();
            }
        }

        private void renderLibraryView(DataTable content)
        {
            DataColumn Title = new DataColumn("Title", typeof(string));
            DataColumn Type = new DataColumn("Type", typeof(string));

            DataTable dgvBind = new DataTable("Library");
            dgvBind.Columns.Add(Title);
            dgvBind.Columns.Add(Type);

            int i = 0;
            foreach (DataRow r1 in content.Rows)
            {
                i += 1;

                string type = "";
                string title = "";
                if (!(r1["title"] == null))
                    title = r1["title"].ToString();
                if (!(r1["type"] == null))
                    type = r1["type"].ToString();

                dgvBind.Rows.Add(title, type);
            }
            if (dgvLibrary.InvokeRequired)
            {
                dgvLibrary.BeginInvoke((MethodInvoker)delegate
                {
                    dgvLibrary.DataSource = dgvBind;
                    dgvLibrary.Refresh();
                });
            }
            else
            {
                dgvLibrary.DataSource = dgvBind;
                dgvLibrary.Refresh();
            }
        }

        #endregion ContentRenderers

        #region UpdateWaitWorkers

        private void updateContentView(XmlDocument content, bool IsTVShow)
        {
            PlexDL.WaitWindow.WaitWindow.Show(this.WorkerUpdateContentView, "Updating Content", new object[] { content, IsTVShow });
        }

        private void updateSeriesView(XmlDocument content)
        {
            PlexDL.WaitWindow.WaitWindow.Show(this.WorkerUpdateSeriesView, "Updating Series", new object[] { content });
        }

        private void updateEpisodeView(XmlDocument content)
        {
            PlexDL.WaitWindow.WaitWindow.Show(this.WorkerUpdateEpisodesView, "Updating Episodes", new object[] { content });
        }

        private void populateLibrary(XmlDocument content)
        {
            PlexDL.WaitWindow.WaitWindow.Show(this.WorkerUpdateLibraryView, "Updating Library", new object[] { content });
        }

        #endregion UpdateWaitWorkers

        #region PlexAPIWorkers

        private void GetServerListWorker(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            e.Result = plex.GetServers(user);
        }

        private void GetXMLTransactionWorker(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            string uri = (string)e.Arguments[0];
            e.Result = GetXMLTransaction(uri);
        }

        private void GetObjectFromSelectionWorker(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            e.Result = GetObjectFromSelection();
        }

        private void GetTVObjectFromSelectionWorker(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            e.Result = GetTVObjectFromSelection();
        }

        #endregion PlexAPIWorkers

        #region SearchWorkers

        private void GetSearchEnum(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            bool directMatch = (bool)e.Arguments[1];
            string searchKey = (string)e.Arguments[0];
            if (directMatch)
            {
                OrderedEnumerableRowCollection<DataRow> rowCollec = titlesTable.AsEnumerable()
                                    .Where(row => row.Field<String>("title") == searchKey)
                                    .OrderByDescending(row => row.Field<String>("title"));
                e.Result = rowCollec;
            }
            else
            {
                OrderedEnumerableRowCollection<DataRow> rowCollec = titlesTable.AsEnumerable()
                                .Where(row => row.Field<String>("title").ToLower().Contains(searchKey.ToLower()))
                                .OrderByDescending(row => row.Field<String>("title"));
                e.Result = rowCollec;
            }
        }

        private void GetSearchTable(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            OrderedEnumerableRowCollection<DataRow> rowCollec = (OrderedEnumerableRowCollection<DataRow>)e.Arguments[0];
            e.Result = rowCollec.CopyToDataTable();
        }

        #endregion SearchWorkers

        #endregion Workers

        #region Logging

        private static void recordTransaction(string uri, string statusCode)
        {
            if (settings.EnableXMLTransactionLogging)
            {
                string[] headers = { "DateTime", "Uri", "StatusCode" };
                string[] LogEntry = { DateTime.Now.ToString(), uri, statusCode };
                logDelWriter("TransactionLog.logdel", headers, LogEntry);
            }
        }

        private void addToLog(string logEntry)
        {
            logIncrementer += 1;
            string[] headers = { "ID", "DateTime", "Entry" };
            string[] logEntryToAdd = { logIncrementer.ToString(), DateTime.Now.ToString(), logEntry };
            string logLine = ">>" + logEntry;
            lstLog.Items.Add(logLine);
            if (settings.EnableGenericLogDel)
            {
                logDelWriter("PlexDL.logdel", headers, logEntryToAdd);
            }
        }

        private void DGVDataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {
            DataGridView parent = (DataGridView)sender;
            //don't show the event to the user; but log it.
            addToLog("Experienced data error in " + parent.Name);
            e.Cancel = true;
        }

        private static void logDelWriter(string fileName, string[] headers, string[] logEntry)
        {
            try
            {

                if (!System.IO.Directory.Exists("Logs"))
                    System.IO.Directory.CreateDirectory("Logs");

                string logdelLine = "";
                string fqFile = @"Logs\" + fileName;


                foreach (string l in logEntry)
                {
                    logdelLine += l + "!";
                }
                logdelLine = logdelLine.TrimEnd('!');

                string headersString = "###";
                foreach (string h in headers)
                {
                    headersString += h + "!";
                }
                headersString = headersString.TrimEnd('!');

                if (File.Exists(fqFile))
                {
                    string existing = File.ReadAllText(fqFile);
                    if (existing != "")
                    {
                        string contentToWrite = existing + "\n" + logdelLine;
                        File.WriteAllText(fqFile, contentToWrite);
                    }
                    else
                    {
                        string contentToWrite = headersString + "\n" + logdelLine;
                        File.WriteAllText(fqFile, contentToWrite);
                    }
                }
                else
                {
                    string contentToWrite = headersString + "\n" + logdelLine;
                    File.WriteAllText(fqFile, contentToWrite);
                }
            }
            catch
            {
                //ignore the error
            }
        }

        #endregion Logging

        #region Download

        #region DownloadInfoGatherers

        private DownloadInfo getContentDownloadInfo_Index(int index)
        {
            XmlDocument reply;

            if (IsTVShow)
            {
                reply = GetEpisodeMetadata(index);
            }
            else
            {
                reply = GetContentMetadata(index);
            }

            return getContentDownloadInfo_Xml(reply);
        }

        private DownloadInfo getContentDownloadInfo_Xml(XmlDocument xml)
        {
            DownloadInfo obj = new DownloadInfo();

            addToLog("Creating new datasets");
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
                thumbnailFullUri = baseUri + thumb + "?X-Plex-Token=" + getToken();
            }

            DataRow partRow = part.Rows[0];

            string filePart = partRow["key"].ToString();
            string container = partRow["container"].ToString();
            long byteLength = Convert.ToInt64(partRow["size"]);
            int contentDuration = Convert.ToInt32(partRow["duration"]);
            string fileName = Common.Methods.removeIllegalCharacters(title + "." + container);

            string link = getBaseUri(false).TrimEnd('/') + filePart + "/?X-Plex-Token=" + getToken();
            obj.Link = link;
            obj.Container = container;
            obj.ByteLength = byteLength;
            obj.ContentDuration = contentDuration;
            obj.FileName = fileName;
            obj.ContentTitle = title;
            obj.ContentThumbnailUri = thumbnailFullUri;

            return obj;
        }

        #endregion DownloadInfoGatherers

        #region DownloadMethods

        private void CancelDownload()
        {
            if (wkrGetMetadata.IsBusy)
            {
                wkrGetMetadata.Abort();
            }
            if (engine.CurrentProgress > 0)
            {
                engine.Cancel();
            }
            SetProgressLabel("Download Cancelled");
            SetDownloadStart();
            SetResume();
            pbMain.Value = 100;
            addToLog("Download Cancelled");
            downloadIsRunning = false;
            downloadIsPaused = false;
            DownloadQueueCancelled = true;
            downloadsSoFar = 0;
            DownloadTotal = 0;
            DownloadIndex = 0;
            MessageBox.Show("Download cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int CheckWebFile(string uri)
        {
            addToLog("Checking web file validity");
            HttpWebResponse response = null;
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                return (int)response.StatusCode;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var errResponse = ex.Response as HttpWebResponse;
                    if (errResponse != null)
                    {
                        return (int)errResponse.StatusCode;
                    }
                    else
                    {
                        return 400;
                    }
                }
            }
            finally
            {
                // Don't forget to close your response.
                if (response != null)
                {
                    response.Close();
                }
            }

            return 200;
        }

        private void StartDownloadEngine()
        {
            engine.QueueProgressChanged += Engine_DownloadProgressChanged;
            engine.QueueCompleted += Engine_DownloadCompleted;

            engine.StartAsync();
            //MessageBox.Show("Started!");
            addToLog("Download is Progressing");
            downloadIsRunning = true;
            downloadIsPaused = false;
            SetPause();
        }

        private void SetDownloadDirectory()
        {
            if (fbdSave.ShowDialog() == DialogResult.OK)
            {
                settings.DownloadDirectory = fbdSave.SelectedPath;
                MessageBox.Show("Download directory updated to " + settings.DownloadDirectory, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addToLog("Download directory updated to " + settings.DownloadDirectory);
            }
        }

        private void SetDownloadCompleted()
        {
            pbMain.Value = pbMain.Maximum;
            SetResume();
            btnPause.Enabled = false;
            SetDownloadStart();
            SetProgressLabel("Download Completed");
            addToLog("Download completed");
            downloadIsRunning = false;
        }

        private void StartDownload(List<DownloadInfo> queue, string location)
        {
            addToLog("Download Process Started");
            pbMain.Value = 0;

            addToLog("Starting HTTP Engine");
            engine = new AltoHttp.DownloadQueue();
            if (queue.Count > 1)
            {
                foreach (DownloadInfo dl in queue)
                {
                    string fqPath = dl.DownloadPath + @"\" + dl.FileName;
                    if (File.Exists(fqPath))
                    {
                        addToLog(dl.FileName + " already exists; will not download.");
                    }
                    else
                    {
                        engine.Add(dl.Link, fqPath);
                    }
                }
            }
            else
            {
                DownloadInfo dl = queue[0];
                string fqPath = dl.DownloadPath + @"\" + dl.FileName;
                if (File.Exists(fqPath))
                {
                    addToLog(dl.FileName + " already exists; get user confirmation.");
                    DialogResult msg = MessageBox.Show(dl.FileName + " already exists. Skip this title?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        SetDownloadCompleted();
                        return;
                    }
                }
                else
                {
                    engine.Add(dl.Link, fqPath);
                }
            }
            StartDownloadEngine();
        }

        #endregion DownloadMethods

        #region DownloadEngineMethods

        private void Engine_DownloadCompleted(object sender, EventArgs e)
        {
            SetDownloadCompleted();
        }

        private void Engine_DownloadProgressChanged(object sender, EventArgs e)
        {
            double CurrentProgress = Math.Round((double)engine.CurrentProgress);
            string speed = Common.Methods.FormatBytes(engine.CurrentDownloadSpeed) + "/s";
            string order = "(" + (engine.CurrentIndex + 1).ToString() + "/" + engine.QueueLength.ToString() + ")";

            SetProgressLabel(CurrentProgress.ToString() + "% " + order + " @ " + speed);

            pbMain.Value = (int)CurrentProgress;
            if (!(engine.CurrentProgress == alreadyMarkedProgressNumber))
            {
                if (engine.CurrentProgress == 15)
                {
                    addToLog("Download 15% Completed");
                    alreadyMarkedProgressNumber = 15;
                }
                else if (engine.CurrentProgress == 25)
                {
                    addToLog("Download 25% Completed");
                    alreadyMarkedProgressNumber = 25;
                }
                else if (engine.CurrentProgress == 50)
                {
                    addToLog("Download 50% Completed");
                    alreadyMarkedProgressNumber = 50;
                }
                else if (engine.CurrentProgress == 75)
                {
                    addToLog("Download 75% Completed");
                    alreadyMarkedProgressNumber = 75;
                }
                else if (engine.CurrentProgress == 90)
                {
                    addToLog("Download 90% Completed");
                    alreadyMarkedProgressNumber = 90;
                }
            }

            //MessageBox.Show("Started!");
        }

        #endregion DownloadEngineMethods

        #endregion Download

        #region Search

        private void ClearSearch()
        {
            renderContentView(titlesTable);
            filteredTable = null;
            IsFiltered = false;
            SetStartSearch();
        }

        private void runTitleSearch()
        {
            try
            {
                addToLog("Title search requested");
                if (dgvContent.Rows.Count > 0)
                {
                    InputResult ipt = objUI.showInputForm("Please enter search term", "Search Content", true, "Direct Match");
                    if (ipt.txt == "!cancel=user")
                    {
                        return;
                    }
                    else if (ipt.txt == "")
                    {
                        MessageBox.Show("Nothing was entered; search cancelled.");
                        return;
                    }
                    else
                    {
                        DataTable tblFiltered;
                        OrderedEnumerableRowCollection<DataRow> rowCollec = (OrderedEnumerableRowCollection<DataRow>)PlexDL.WaitWindow.WaitWindow.Show(GetSearchEnum, "Filtering Records", new object[] { ipt.txt, ipt.chkd });
                        if (rowCollec.Count() > 0)
                        {
                            tblFiltered = (DataTable)PlexDL.WaitWindow.WaitWindow.Show(GetSearchTable, "Binding", new object[] { rowCollec });
                        }
                        else
                        {
                            MessageBox.Show("No Result Found for '" + ipt.txt + "'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        IsFiltered = true;
                        filteredTable = tblFiltered;
                        SetCancelSearch();
                        PlexDL.WaitWindow.WaitWindow.Show(WorkerRenderContentView, "Rendering Content", new object[] { tblFiltered });
                    }
                }
                else
                {
                    addToLog("No data to search");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion Search

        #region UIMethods

        private void DGVContentEnabled(bool enabled)
        {
            if (dgvContent.InvokeRequired)
            {
                dgvContent.BeginInvoke((MethodInvoker)delegate
                {
                    dgvContent.Enabled = enabled;
                });
            }
            else
            {
                dgvContent.Enabled = enabled;
            }
        }

        private void DGVLibraryEnabled(bool enabled)
        {
            if (dgvLibrary.InvokeRequired)
            {
                dgvLibrary.BeginInvoke((MethodInvoker)delegate
                {
                    dgvLibrary.Enabled = enabled;
                });
            }
            else
            {
                dgvLibrary.Enabled = enabled;
            }
        }

        private void DGVSeasonsEnabled(bool enabled)
        {
            if (dgvSeasons.InvokeRequired)
            {
                dgvSeasons.BeginInvoke((MethodInvoker)delegate
                {
                    dgvSeasons.Enabled = enabled;
                });
            }
            else
            {
                dgvSeasons.Enabled = enabled;
            }
        }

        private void DGVEpisodesEnabled(bool enabled)
        {
            if (dgvEpisodes.InvokeRequired)
            {
                dgvEpisodes.BeginInvoke((MethodInvoker)delegate
                {
                    dgvEpisodes.Enabled = enabled;
                });
            }
            else
            {
                dgvEpisodes.Enabled = enabled;
            }
        }

        private void DGVServersEnabled(bool enabled)
        {
            if (dgvServers.InvokeRequired)
            {
                dgvServers.BeginInvoke((MethodInvoker)delegate
                {
                    dgvServers.Enabled = enabled;
                });
            }
            else
            {
                dgvServers.Enabled = enabled;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                runTitleSearch();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.O))
            {
                loadProfile();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                saveProfile();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SetProgressLabel(string status)
        {
            lblProgress.Text = status;
        }

        private void SetDownloadCancel()
        {
            btnDownload.Icon = PlexDL.Properties.Resources.baseline_cancel_black_18dp;
        }

        private void SetDownloadStart()
        {
            btnDownload.Icon = PlexDL.Properties.Resources.baseline_cloud_download_black_18dp;
        }

        private void SetPause()
        {
            btnPause.Icon = PlexDL.Properties.Resources.baseline_pause_black_18dp;
        }

        private void SetResume()
        {
            btnPause.Icon = PlexDL.Properties.Resources.baseline_play_arrow_black_18dp;
        }

        private void SetStartSearch()
        {
            btnSearch.Icon = PlexDL.Properties.Resources.baseline_search_black_18dp;
        }

        private void SetCancelSearch()
        {
            btnSearch.Icon = PlexDL.Properties.Resources.baseline_cancel_black_18dp;
        }

        private void SetConnect()
        {
            btnConnect.Icon = PlexDL.Properties.Resources.baseline_power_black_18dp;
        }

        private void SetDisconnect()
        {
            btnConnect.Icon = PlexDL.Properties.Resources.baseline_power_off_black_18dp;
        }

        #endregion UIMethods

        #region Events

        #region PaintOverrides

        private void dgvSeasons_Paint(object sender, PaintEventArgs e)
        {
            if ((dgvSeasons.Rows.Count == 0) && (connected))
            {
                TextRenderer.DrawText(e.Graphics, "No TV Seasons Found",
                    dgvSeasons.Font, dgvSeasons.ClientRectangle,
                    dgvSeasons.ForeColor, dgvSeasons.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void dgvEpisodes_Paint(object sender, PaintEventArgs e)
        {
            if ((dgvEpisodes.Rows.Count == 0) && (connected))
            {
                TextRenderer.DrawText(e.Graphics, "No TV Episodes Found",
                    dgvEpisodes.Font, dgvEpisodes.ClientRectangle,
                    dgvEpisodes.ForeColor, dgvEpisodes.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void dgvServers_Paint(object sender, PaintEventArgs e)
        {
            if (dgvServers.Rows.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, "No Servers Found",
                    dgvServers.Font, dgvServers.ClientRectangle,
                    dgvServers.ForeColor, dgvServers.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void dgvLibrary_Paint(object sender, PaintEventArgs e)
        {
            if ((dgvLibrary.Rows.Count == 0) && (connected))
            {
                TextRenderer.DrawText(e.Graphics, "No Library Sections Found",
                    dgvLibrary.Font, dgvLibrary.ClientRectangle,
                    dgvLibrary.ForeColor, dgvLibrary.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void dgvContent_Paint(object sender, PaintEventArgs e)
        {
            if (dgvContent.Rows.Count == 0)
            {
                TextRenderer.DrawText(e.Graphics, "Not Connected",
                    dgvContent.Font, dgvContent.ClientRectangle,
                    dgvContent.ForeColor, dgvContent.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        #endregion PaintOverrides

        #region FormEvents

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (downloadIsRunning)
            {
                if (!(msgAlreadyShown))
                {
                    DialogResult msg = MessageBox.Show("Are you sure you want to exit PlexDL? A download is still running.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        msgAlreadyShown = true;
                        addToLog("PlexDL Exited");
                        e.Cancel = false;
                    }
                }
            }
            else
            {
                addToLog("PlexDL Exited");

                if (settings.AnimationSpeed > 0)
                {
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
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //TEMPORARY (FOR TESTING A NEW FEATURE)
            //frmChromecast frm = new frmChromecast();
            //frm.ShowDialog();
            if (settings.AnimationSpeed > 0)
            {
                Opacity = 0;      //first the opacity is 0

                t1.Interval = settings.AnimationSpeed;  //we'll increase the opacity every 10ms
                t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity
                t1.Start();
            }
            try
            {
                string curUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                settings.DownloadDirectory = curUser + "\\Videos\\PlexDL";

                if (!(System.IO.Directory.Exists(settings.DownloadDirectory)))
                {
                    System.IO.Directory.CreateDirectory(settings.DownloadDirectory);
                }

                addToLog("PlexDL Started");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Startup Error:\n\n" + ex.ToString(), "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion FormEvents

        #region DGVRowChanges

        private void dgvLibrary_OnRowChange(object sender, EventArgs e)
        {
            if ((dgvLibrary.SelectedRows.Count == 1) && (libraryFilled))
            {
                addToLog("Selection Changed");
                int index = dgvLibrary.CurrentCell.RowIndex;
                DataRow r = gSectionsTable.Rows[index];

                string key = r["key"].ToString();

                try
                {
                    addToLog("Requesting ibrary contents");
                    string contentUri = uri + key + "/all/?X-Plex-Token=";
                    XmlDocument contentXml = GetXMLTransaction(contentUri);

                    contentXmlDoc = contentXml;
                    string type = r["type"].ToString();
                    if (type == "show")
                    {
                        updateContentView(contentXml, true);
                    }
                    else if (type == "movie")
                    {
                        updateContentView(contentXml, false);
                    }
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        var response = ex.Response as HttpWebResponse;
                        recordTransaction(response.ResponseUri.ToString(), ((int)response.StatusCode).ToString());
                        if (response != null)
                        {
                            switch ((int)response.StatusCode)
                            {
                                case 401:
                                    MessageBox.Show("The web server denied access to the resource. Check your token and try again. (401)");
                                    break;

                                case 404:
                                    MessageBox.Show("The web server couldn't serve the request because it couldn't find the resource specified. (404)");
                                    break;

                                case 400:
                                    MessageBox.Show("The web server couldn't serve the request because the request was bad. (400)");
                                    break;
                            }
                        }
                        else
                        {
                            // no http status code available
                        }
                    }
                    else
                    {
                        // no http status code available
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dgvSeasons_OnRowChange(object sender, EventArgs e)
        {
            if (dgvSeasons.SelectedRows.Count == 1)
            {
                int index = dgvSeasons.CurrentCell.RowIndex;
                XmlDocument episodes = GetEpisodeXml(index);
                updateEpisodeView(episodes);
            }
        }

        private void dgvContent_OnRowChange(object sender, EventArgs e)
        {
            if (dgvContent.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvContent.SelectedRows[0];
                selectedIndex = row.Cells[0].RowIndex;

                if (IsTVShow)
                {
                    XmlDocument series = GetSeriesXml(GetSelectedIndex());
                    updateSeriesView(series);
                }
            }
        }

        private void dgvServers_OnRowChange(object sender, EventArgs e)
        {
            if (dgvServers.SelectedRows.Count == 1)
            {
                int index = dgvServers.CurrentCell.RowIndex;
                Server s = plexServers[index];
                string address = s.address;
                if (!(address == settings.ServerAddress))
                {
                    doNotAttemptAgain = false;
                    //MessageBox.Show("attempted connection");
                    doConnectFromSelectedServer();
                }
            }
        }

        #endregion DGVRowChanges

        #region ButtonClicks

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                //deprecated (planned reintroduction)
                string uri = getBaseUri(true);
                XmlDocument reply = (XmlDocument)PlexDL.WaitWindow.WaitWindow.Show(GetXMLTransactionWorker, "Connecting", new object[] { uri });
                MessageBox.Show("Connection successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    recordTransaction(response.ResponseUri.ToString(), ((int)response.StatusCode).ToString());
                    if (response != null)
                    {
                        switch ((int)response.StatusCode)
                        {
                            case 401:
                                MessageBox.Show("The web server denied access to the resource. Check your token and try again. (401)");
                                break;

                            case 404:
                                MessageBox.Show("The web server couldn't serve the request because it couldn't find the resource specified. (404)");
                                break;

                            case 400:
                                MessageBox.Show("The web server couldn't serve the request because the request was bad. (400)");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unknown status code; the server failed to serve the request. (?)");
                    }
                }
                else
                {
                    MessageBox.Show("An unknown error occurred:\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool CheckForInternetConnection()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connected)
                {
                    if (CheckForInternetConnection())
                    {
                        Connect();
                    }
                    else
                    {
                        MessageBox.Show("No internet connection", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Disconnect();
                    MessageBox.Show("Disconnected from server", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    recordTransaction(response.ResponseUri.ToString(), ((int)response.StatusCode).ToString());
                    if (response != null)
                    {
                        switch ((int)response.StatusCode)
                        {
                            case 401:
                                MessageBox.Show("The web server denied access to the resource. Check your token and try again. (401)");
                                break;

                            case 404:
                                MessageBox.Show("The web server couldn't serve the request because it couldn't find the resource specified. (404)");
                                break;

                            case 400:
                                MessageBox.Show("The web server couldn't serve the request because the request was bad. (400)");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unknown status code; the server failed to serve the request. (?)");
                    }
                }
                else
                {
                    MessageBox.Show("An unknown error occurred:\n\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (dgvContent.SelectedRows.Count == 1)
            {
                if (!downloadIsRunning)
                {
                    SetProgressLabel("Waiting");
                    queue = new List<DownloadInfo>();
                    if (IsTVShow)
                    {
                        if (dgvEpisodes.SelectedRows.Count == 1)
                        {
                            DialogResult msg = MessageBox.Show("Download all episodes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (msg == DialogResult.Yes)
                            {
                                DownloadAllEpisodes = true;
                                DownloadTotal = episodesTable.Rows.Count;
                            }
                            else if (msg == DialogResult.No)
                            {
                                DownloadAllEpisodes = false;
                                DownloadTotal = 1;
                            }
                        }
                    }
                    else
                    {
                        DownloadAllEpisodes = false;
                        DownloadTotal = 1;
                    }

                    downloadIsRunning = true;
                    wkrGetMetadata.RunWorkerAsync();
                    addToLog("Verifying Server Response");
                    SetDownloadCancel();
                }
                else
                {
                    CancelDownload();
                }
            }
        }

        private void ResetContentGridViews()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    dgvContent.DataSource = null;
                    dgvSeasons.DataSource = null;
                    dgvEpisodes.DataSource = null;
                });
            }
            else
            {
                dgvContent.DataSource = null;
                dgvSeasons.DataSource = null;
                dgvEpisodes.DataSource = null;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (downloadIsRunning)
            {
                if (!downloadIsPaused)
                {
                    engine.Pause();
                    SetResume();
                    lblProgress.Text += " (Paused)";
                    downloadIsPaused = true;
                }
                else
                {
                    engine.ResumeAsync();
                    SetPause();
                    downloadIsPaused = false;
                }
            }
        }

        private void btnHTTPPlay_Click(object sender, EventArgs e)
        {
            if (dgvContent.SelectedRows.Count == 1)
            {
                PlexObject result;
                if (!IsTVShow)
                {
                    result = (PlexMovie)PlexDL.WaitWindow.WaitWindow.Show(GetObjectFromSelectionWorker, "Getting Metadata");
                }
                else
                {
                    if (dgvEpisodes.SelectedRows.Count == 1)
                    {
                        result = (PlexTVShow)PlexDL.WaitWindow.WaitWindow.Show(GetTVObjectFromSelectionWorker, "Getting Metadata");
                    }
                    else
                    {
                        MessageBox.Show("No episode is selected", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (!downloadIsRunning)
                {
                    frmPlayer frm = new frmPlayer();
                    frm.StreamingContent = result;
                    frm.TitlesTable = returnCorrectTable();
                    addToLog("Started streaming " + result.StreamInformation.ContentTitle);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You cannot stream " + result.StreamInformation.ContentTitle + " because a download is already running. Cancel the download before attempting to stream within PlexDL.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            saveProfile();
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            loadProfile();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (IsFiltered)
            {
                ClearSearch();
            }
            else
            {
                runTitleSearch();
            }
        }

        private void btnMetadata_Click(object sender, EventArgs e)
        {
            if (dgvContent.SelectedRows.Count == 1)
            {
                PlexMovie result = (PlexMovie)PlexDL.WaitWindow.WaitWindow.Show(GetObjectFromSelectionWorker, "Getting Metadata");
                using (frmTitleInformation frm = new frmTitleInformation())
                {
                    frm.StreamingContent = result;
                    frm.ShowDialog();
                }
            }
        }

        #endregion ButtonClicks

        #endregion Events

        private void lblViewFullLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (LogViewer frm = new LogViewer())
                frm.ShowDialog();
        }

        private void btnSetDlDir_Click(object sender, EventArgs e)
        {
            SetDownloadDirectory();
        }
    }
}
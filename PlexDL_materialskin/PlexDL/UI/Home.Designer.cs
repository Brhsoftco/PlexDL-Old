namespace PlexDL.UI
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.wkrUpdateContentView = new System.ComponentModel.BackgroundWorker();
            this.sfdSaveProfile = new System.Windows.Forms.SaveFileDialog();
            this.fbdSave = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdLoadProfile = new System.Windows.Forms.OpenFileDialog();
            this.wkrDownloadAsync = new System.ComponentModel.BackgroundWorker();
            this.pbMain = new MaterialSkin.Controls.MaterialProgressBar();
            this.lblProgress = new MaterialSkin.Controls.MaterialLabel();
            this.lblLog = new MaterialSkin.Controls.MaterialLabel();
            this.lblProfile = new MaterialSkin.Controls.MaterialLabel();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.mtlDividerMain = new MaterialSkin.Controls.MaterialDivider();
            this.lblLibraryContent = new MaterialSkin.Controls.MaterialLabel();
            this.lblLibrarySections = new MaterialSkin.Controls.MaterialLabel();
            this.tipMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLoadProfile = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPause = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnHTTPPlay = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnConnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDownload = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSetDlDir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMetadata = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblLibraryContentSections = new MaterialSkin.Controls.MaterialLabel();
            this.wkrGetMetadata = new libbrhscgui.Components.AbortableBackgroundWorker();
            this.lblViewFullLog = new System.Windows.Forms.LinkLabel();
            this.cxtEpisodes = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.itmDownloadThisEpisode = new System.Windows.Forms.ToolStripMenuItem();
            this.itmDownloadAllEpisodes = new System.Windows.Forms.ToolStripMenuItem();
            this.cxtEpisodeOptions = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.itmEpisodeMetadata = new System.Windows.Forms.ToolStripMenuItem();
            this.itmEpisodeDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.thisEpisodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisSeasonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxtLibrarySections = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.itmManuallyLoadSection = new System.Windows.Forms.ToolStripMenuItem();
            this.cxtContentOptions = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.itmContentMetadata = new System.Windows.Forms.ToolStripMenuItem();
            this.itmContentDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdMetadata = new System.Windows.Forms.OpenFileDialog();
            this.cxtProfile = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.loadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEpisodes = new PlexDL.Components.FlatDataGridView();
            this.dgvSeasons = new PlexDL.Components.FlatDataGridView();
            this.dgvContent = new PlexDL.Components.FlatDataGridView();
            this.dgvLibrary = new PlexDL.Components.FlatDataGridView();
            this.dgvServers = new PlexDL.Components.FlatDataGridView();
            this.cxtEpisodes.SuspendLayout();
            this.cxtEpisodeOptions.SuspendLayout();
            this.cxtLibrarySections.SuspendLayout();
            this.cxtContentOptions.SuspendLayout();
            this.cxtProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeasons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServers)).BeginInit();
            this.SuspendLayout();
            // 
            // sfdSaveProfile
            // 
            this.sfdSaveProfile.DefaultExt = "prof";
            this.sfdSaveProfile.Filter = "XML Profile|*.prof";
            this.sfdSaveProfile.Title = "Save XML Profile";
            // 
            // fbdSave
            // 
            this.fbdSave.Description = "Select a path to save downloaded items";
            // 
            // ofdLoadProfile
            // 
            this.ofdLoadProfile.Filter = "XML Profile|*.prof";
            this.ofdLoadProfile.Title = "Load XML Profile";
            // 
            // pbMain
            // 
            this.pbMain.Depth = 0;
            this.pbMain.Location = new System.Drawing.Point(26, 129);
            this.pbMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(252, 5);
            this.pbMain.TabIndex = 5;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProgress.Depth = 0;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProgress.Location = new System.Drawing.Point(22, 137);
            this.lblProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(30, 18);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "Idle";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLog.Depth = 0;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLog.Location = new System.Drawing.Point(22, 242);
            this.lblLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(33, 18);
            this.lblLog.TabIndex = 11;
            this.lblLog.Text = "Log";
            this.lblLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProfile.Depth = 0;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProfile.Location = new System.Drawing.Point(22, 171);
            this.lblProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(39, 18);
            this.lblProfile.TabIndex = 7;
            this.lblProfile.Text = "Data";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstLog
            // 
            this.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.Location = new System.Drawing.Point(26, 266);
            this.lstLog.Name = "lstLog";
            this.lstLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstLog.Size = new System.Drawing.Size(252, 221);
            this.lstLog.TabIndex = 13;
            this.tipMain.SetToolTip(this.lstLog, "PlexDL Log");
            // 
            // mtlDividerMain
            // 
            this.mtlDividerMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtlDividerMain.Depth = 1;
            this.mtlDividerMain.Location = new System.Drawing.Point(12, 72);
            this.mtlDividerMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlDividerMain.Name = "mtlDividerMain";
            this.mtlDividerMain.Size = new System.Drawing.Size(281, 430);
            this.mtlDividerMain.TabIndex = 22;
            // 
            // lblLibraryContent
            // 
            this.lblLibraryContent.AutoSize = true;
            this.lblLibraryContent.BackColor = System.Drawing.Color.White;
            this.lblLibraryContent.Depth = 0;
            this.lblLibraryContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLibraryContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLibraryContent.Location = new System.Drawing.Point(731, 72);
            this.lblLibraryContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLibraryContent.Name = "lblLibraryContent";
            this.lblLibraryContent.Size = new System.Drawing.Size(108, 18);
            this.lblLibraryContent.TabIndex = 17;
            this.lblLibraryContent.Text = "Library Content";
            this.lblLibraryContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLibrarySections
            // 
            this.lblLibrarySections.AutoSize = true;
            this.lblLibrarySections.BackColor = System.Drawing.Color.White;
            this.lblLibrarySections.Depth = 0;
            this.lblLibrarySections.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLibrarySections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLibrarySections.Location = new System.Drawing.Point(394, 72);
            this.lblLibrarySections.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLibrarySections.Name = "lblLibrarySections";
            this.lblLibrarySections.Size = new System.Drawing.Size(129, 18);
            this.lblLibrarySections.TabIndex = 14;
            this.lblLibrarySections.Text = "Server Information";
            this.lblLibrarySections.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = global::PlexDL.Properties.Resources.baseline_search_black_18dp;
            this.btnSearch.Location = new System.Drawing.Point(182, 84);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(44, 36);
            this.btnSearch.TabIndex = 3;
            this.tipMain.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.AutoSize = true;
            this.btnLoadProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadProfile.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadProfile.Depth = 0;
            this.btnLoadProfile.Icon = global::PlexDL.Properties.Resources.baseline_folder_open_black_18dp;
            this.btnLoadProfile.Location = new System.Drawing.Point(26, 196);
            this.btnLoadProfile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Primary = false;
            this.btnLoadProfile.Size = new System.Drawing.Size(44, 36);
            this.btnLoadProfile.TabIndex = 8;
            this.tipMain.SetToolTip(this.btnLoadProfile, "Save/Load Profile");
            this.btnLoadProfile.UseVisualStyleBackColor = false;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnPause
            // 
            this.btnPause.AutoSize = true;
            this.btnPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.Depth = 0;
            this.btnPause.Icon = ((System.Drawing.Image)(resources.GetObject("btnPause.Icon")));
            this.btnPause.Location = new System.Drawing.Point(78, 84);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPause.Name = "btnPause";
            this.btnPause.Primary = false;
            this.btnPause.Size = new System.Drawing.Size(44, 36);
            this.btnPause.TabIndex = 1;
            this.tipMain.SetToolTip(this.btnPause, "Pause/Resume Download");
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnHTTPPlay
            // 
            this.btnHTTPPlay.AutoSize = true;
            this.btnHTTPPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHTTPPlay.Depth = 0;
            this.btnHTTPPlay.Icon = ((System.Drawing.Image)(resources.GetObject("btnHTTPPlay.Icon")));
            this.btnHTTPPlay.Location = new System.Drawing.Point(130, 84);
            this.btnHTTPPlay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHTTPPlay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHTTPPlay.Name = "btnHTTPPlay";
            this.btnHTTPPlay.Primary = false;
            this.btnHTTPPlay.Size = new System.Drawing.Size(44, 36);
            this.btnHTTPPlay.TabIndex = 2;
            this.tipMain.SetToolTip(this.btnHTTPPlay, "Stream Selected Title");
            this.btnHTTPPlay.UseVisualStyleBackColor = true;
            this.btnHTTPPlay.Click += new System.EventHandler(this.btnHTTPPlay_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.Icon = global::PlexDL.Properties.Resources.baseline_power_black_18dp;
            this.btnConnect.Location = new System.Drawing.Point(234, 84);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = false;
            this.btnConnect.Size = new System.Drawing.Size(44, 36);
            this.btnConnect.TabIndex = 4;
            this.tipMain.SetToolTip(this.btnConnect, "Connect");
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Depth = 0;
            this.btnDownload.Icon = ((System.Drawing.Image)(resources.GetObject("btnDownload.Icon")));
            this.btnDownload.Location = new System.Drawing.Point(26, 84);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Primary = true;
            this.btnDownload.Size = new System.Drawing.Size(44, 36);
            this.btnDownload.TabIndex = 0;
            this.tipMain.SetToolTip(this.btnDownload, "Download Selected Title");
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSetDlDir
            // 
            this.btnSetDlDir.AutoSize = true;
            this.btnSetDlDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSetDlDir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetDlDir.Depth = 0;
            this.btnSetDlDir.Icon = global::PlexDL.Properties.Resources.baseline_video_library_black_18dp;
            this.btnSetDlDir.Location = new System.Drawing.Point(78, 196);
            this.btnSetDlDir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSetDlDir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetDlDir.Name = "btnSetDlDir";
            this.btnSetDlDir.Primary = false;
            this.btnSetDlDir.Size = new System.Drawing.Size(44, 36);
            this.btnSetDlDir.TabIndex = 9;
            this.tipMain.SetToolTip(this.btnSetDlDir, "Set Download Directory");
            this.btnSetDlDir.UseVisualStyleBackColor = false;
            this.btnSetDlDir.Click += new System.EventHandler(this.btnSetDlDir_Click);
            // 
            // btnMetadata
            // 
            this.btnMetadata.AutoSize = true;
            this.btnMetadata.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMetadata.BackColor = System.Drawing.SystemColors.Control;
            this.btnMetadata.Depth = 0;
            this.btnMetadata.Icon = global::PlexDL.Properties.Resources.baseline_dvr_black_18dp;
            this.btnMetadata.Location = new System.Drawing.Point(130, 196);
            this.btnMetadata.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMetadata.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMetadata.Name = "btnMetadata";
            this.btnMetadata.Primary = false;
            this.btnMetadata.Size = new System.Drawing.Size(44, 36);
            this.btnMetadata.TabIndex = 10;
            this.tipMain.SetToolTip(this.btnMetadata, "Set Download Directory");
            this.btnMetadata.UseVisualStyleBackColor = false;
            this.btnMetadata.Click += new System.EventHandler(this.btnMetadata_Click);
            // 
            // lblLibraryContentSections
            // 
            this.lblLibraryContentSections.AutoSize = true;
            this.lblLibraryContentSections.BackColor = System.Drawing.Color.White;
            this.lblLibraryContentSections.Depth = 0;
            this.lblLibraryContentSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLibraryContentSections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLibraryContentSections.Location = new System.Drawing.Point(1025, 72);
            this.lblLibraryContentSections.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLibraryContentSections.Name = "lblLibraryContentSections";
            this.lblLibraryContentSections.Size = new System.Drawing.Size(170, 18);
            this.lblLibraryContentSections.TabIndex = 19;
            this.lblLibraryContentSections.Text = "Library Content Sections";
            this.lblLibraryContentSections.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wkrGetMetadata
            // 
            this.wkrGetMetadata.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wkrGetMetadata_DoWork);
            // 
            // lblViewFullLog
            // 
            this.lblViewFullLog.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblViewFullLog.AutoSize = true;
            this.lblViewFullLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblViewFullLog.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblViewFullLog.Location = new System.Drawing.Point(208, 246);
            this.lblViewFullLog.Name = "lblViewFullLog";
            this.lblViewFullLog.Size = new System.Drawing.Size(70, 13);
            this.lblViewFullLog.TabIndex = 12;
            this.lblViewFullLog.TabStop = true;
            this.lblViewFullLog.Text = "View Full Log";
            this.lblViewFullLog.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblViewFullLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblViewFullLog_LinkClicked);
            // 
            // cxtEpisodes
            // 
            this.cxtEpisodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cxtEpisodes.Depth = 0;
            this.cxtEpisodes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmDownloadThisEpisode,
            this.itmDownloadAllEpisodes});
            this.cxtEpisodes.MouseState = MaterialSkin.MouseState.HOVER;
            this.cxtEpisodes.Name = "cxtEpisodes";
            this.cxtEpisodes.Size = new System.Drawing.Size(197, 48);
            // 
            // itmDownloadThisEpisode
            // 
            this.itmDownloadThisEpisode.Name = "itmDownloadThisEpisode";
            this.itmDownloadThisEpisode.Size = new System.Drawing.Size(196, 22);
            this.itmDownloadThisEpisode.Text = "Download This Episode";
            this.itmDownloadThisEpisode.Click += new System.EventHandler(this.itmDownloadThisEpisode_Click);
            // 
            // itmDownloadAllEpisodes
            // 
            this.itmDownloadAllEpisodes.Name = "itmDownloadAllEpisodes";
            this.itmDownloadAllEpisodes.Size = new System.Drawing.Size(196, 22);
            this.itmDownloadAllEpisodes.Text = "Download This Season";
            this.itmDownloadAllEpisodes.Click += new System.EventHandler(this.itmDownloadAllEpisodes_Click);
            // 
            // cxtEpisodeOptions
            // 
            this.cxtEpisodeOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cxtEpisodeOptions.Depth = 0;
            this.cxtEpisodeOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmEpisodeMetadata,
            this.itmEpisodeDownload});
            this.cxtEpisodeOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cxtEpisodeOptions.Name = "cxtEpisodeOptions";
            this.cxtEpisodeOptions.Size = new System.Drawing.Size(129, 48);
            this.cxtEpisodeOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cxtEpisodeOptions_Opening);
            // 
            // itmEpisodeMetadata
            // 
            this.itmEpisodeMetadata.Name = "itmEpisodeMetadata";
            this.itmEpisodeMetadata.Size = new System.Drawing.Size(128, 22);
            this.itmEpisodeMetadata.Text = "Metadata";
            this.itmEpisodeMetadata.Click += new System.EventHandler(this.metadataToolStripMenuItem_Click);
            // 
            // itmEpisodeDownload
            // 
            this.itmEpisodeDownload.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisEpisodeToolStripMenuItem,
            this.thisSeasonToolStripMenuItem});
            this.itmEpisodeDownload.Name = "itmEpisodeDownload";
            this.itmEpisodeDownload.Size = new System.Drawing.Size(128, 22);
            this.itmEpisodeDownload.Text = "Download";
            // 
            // thisEpisodeToolStripMenuItem
            // 
            this.thisEpisodeToolStripMenuItem.Name = "thisEpisodeToolStripMenuItem";
            this.thisEpisodeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.thisEpisodeToolStripMenuItem.Text = "This Episode";
            this.thisEpisodeToolStripMenuItem.Click += new System.EventHandler(this.thisEpisodeToolStripMenuItem_Click);
            // 
            // thisSeasonToolStripMenuItem
            // 
            this.thisSeasonToolStripMenuItem.Name = "thisSeasonToolStripMenuItem";
            this.thisSeasonToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.thisSeasonToolStripMenuItem.Text = "This Season";
            this.thisSeasonToolStripMenuItem.Click += new System.EventHandler(this.thisSeasonToolStripMenuItem_Click);
            // 
            // cxtLibrarySections
            // 
            this.cxtLibrarySections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cxtLibrarySections.Depth = 0;
            this.cxtLibrarySections.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmManuallyLoadSection});
            this.cxtLibrarySections.MouseState = MaterialSkin.MouseState.HOVER;
            this.cxtLibrarySections.Name = "cxtLibrarySections";
            this.cxtLibrarySections.Size = new System.Drawing.Size(195, 26);
            this.cxtLibrarySections.Opening += new System.ComponentModel.CancelEventHandler(this.cxtLibrarySections_Opening);
            // 
            // itmManuallyLoadSection
            // 
            this.itmManuallyLoadSection.Name = "itmManuallyLoadSection";
            this.itmManuallyLoadSection.Size = new System.Drawing.Size(194, 22);
            this.itmManuallyLoadSection.Text = "Manually Load Section";
            this.itmManuallyLoadSection.Click += new System.EventHandler(this.itmManuallyLoadSection_Click);
            // 
            // cxtContentOptions
            // 
            this.cxtContentOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cxtContentOptions.Depth = 0;
            this.cxtContentOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmContentMetadata,
            this.itmContentDownload});
            this.cxtContentOptions.MouseState = MaterialSkin.MouseState.HOVER;
            this.cxtContentOptions.Name = "cxtEpisodeOptions";
            this.cxtContentOptions.Size = new System.Drawing.Size(129, 48);
            this.cxtContentOptions.Opening += new System.ComponentModel.CancelEventHandler(this.cxtContentOptions_Opening);
            // 
            // itmContentMetadata
            // 
            this.itmContentMetadata.Name = "itmContentMetadata";
            this.itmContentMetadata.Size = new System.Drawing.Size(128, 22);
            this.itmContentMetadata.Text = "Metadata";
            this.itmContentMetadata.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // itmContentDownload
            // 
            this.itmContentDownload.Name = "itmContentDownload";
            this.itmContentDownload.Size = new System.Drawing.Size(128, 22);
            this.itmContentDownload.Text = "Download";
            this.itmContentDownload.Click += new System.EventHandler(this.itmContentDownload_Click);
            // 
            // ofdMetadata
            // 
            this.ofdMetadata.Filter = "PlexMovie XML|*.pmxml";
            this.ofdMetadata.Title = "Load Metadata File";
            // 
            // cxtProfile
            // 
            this.cxtProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cxtProfile.Depth = 0;
            this.cxtProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadProfileToolStripMenuItem,
            this.saveProfileToolStripMenuItem});
            this.cxtProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.cxtProfile.Name = "cxtProfile";
            this.cxtProfile.Size = new System.Drawing.Size(138, 48);
            // 
            // loadProfileToolStripMenuItem
            // 
            this.loadProfileToolStripMenuItem.Name = "loadProfileToolStripMenuItem";
            this.loadProfileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.loadProfileToolStripMenuItem.Text = "Load Profile";
            this.loadProfileToolStripMenuItem.Click += new System.EventHandler(this.loadProfileToolStripMenuItem_Click);
            // 
            // saveProfileToolStripMenuItem
            // 
            this.saveProfileToolStripMenuItem.Name = "saveProfileToolStripMenuItem";
            this.saveProfileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveProfileToolStripMenuItem.Text = "Save Profile";
            this.saveProfileToolStripMenuItem.Click += new System.EventHandler(this.saveProfileToolStripMenuItem_Click);
            // 
            // dgvEpisodes
            // 
            this.dgvEpisodes.AllowUserToAddRows = false;
            this.dgvEpisodes.AllowUserToDeleteRows = false;
            this.dgvEpisodes.AllowUserToOrderColumns = true;
            this.dgvEpisodes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEpisodes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEpisodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEpisodes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEpisodes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEpisodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEpisodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpisodes.ContextMenuStrip = this.cxtEpisodeOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEpisodes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEpisodes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEpisodes.EnableHeadersVisualStyles = false;
            this.dgvEpisodes.Location = new System.Drawing.Point(952, 301);
            this.dgvEpisodes.MultiSelect = false;
            this.dgvEpisodes.Name = "dgvEpisodes";
            this.dgvEpisodes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEpisodes.RowHeadersVisible = false;
            this.dgvEpisodes.RowsEmptyText = "No TV Episodes Found";
            this.dgvEpisodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEpisodes.Size = new System.Drawing.Size(320, 201);
            this.dgvEpisodes.TabIndex = 21;
            this.dgvEpisodes.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvEpisodes_Paint);
            // 
            // dgvSeasons
            // 
            this.dgvSeasons.AllowUserToAddRows = false;
            this.dgvSeasons.AllowUserToDeleteRows = false;
            this.dgvSeasons.AllowUserToOrderColumns = true;
            this.dgvSeasons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeasons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSeasons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeasons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSeasons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeasons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSeasons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeasons.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSeasons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSeasons.EnableHeadersVisualStyles = false;
            this.dgvSeasons.Location = new System.Drawing.Point(952, 94);
            this.dgvSeasons.MultiSelect = false;
            this.dgvSeasons.Name = "dgvSeasons";
            this.dgvSeasons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSeasons.RowHeadersVisible = false;
            this.dgvSeasons.RowsEmptyText = "No TV Seasons Found";
            this.dgvSeasons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeasons.Size = new System.Drawing.Size(320, 201);
            this.dgvSeasons.TabIndex = 20;
            this.dgvSeasons.SelectionChanged += new System.EventHandler(this.dgvSeasons_OnRowChange);
            this.dgvSeasons.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSeasons_Paint);
            // 
            // dgvContent
            // 
            this.dgvContent.AllowUserToAddRows = false;
            this.dgvContent.AllowUserToDeleteRows = false;
            this.dgvContent.AllowUserToOrderColumns = true;
            this.dgvContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.ContextMenuStrip = this.cxtContentOptions;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContent.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvContent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContent.EnableHeadersVisualStyles = false;
            this.dgvContent.Location = new System.Drawing.Point(626, 94);
            this.dgvContent.MultiSelect = false;
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContent.RowHeadersVisible = false;
            this.dgvContent.RowsEmptyText = "No Library Content Found";
            this.dgvContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContent.Size = new System.Drawing.Size(320, 408);
            this.dgvContent.TabIndex = 18;
            this.dgvContent.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContent_ColumnHeaderMouseClick);
            this.dgvContent.SelectionChanged += new System.EventHandler(this.dgvContent_OnRowChange);
            // 
            // dgvLibrary
            // 
            this.dgvLibrary.AllowUserToAddRows = false;
            this.dgvLibrary.AllowUserToDeleteRows = false;
            this.dgvLibrary.AllowUserToOrderColumns = true;
            this.dgvLibrary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibrary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLibrary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrary.ContextMenuStrip = this.cxtLibrarySections;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibrary.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLibrary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLibrary.EnableHeadersVisualStyles = false;
            this.dgvLibrary.Location = new System.Drawing.Point(300, 301);
            this.dgvLibrary.MultiSelect = false;
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLibrary.RowHeadersVisible = false;
            this.dgvLibrary.RowsEmptyText = "No Library Sections Found";
            this.dgvLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibrary.Size = new System.Drawing.Size(320, 201);
            this.dgvLibrary.TabIndex = 16;
            this.dgvLibrary.SelectionChanged += new System.EventHandler(this.dgvLibrary_OnRowChange);
            this.dgvLibrary.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvLibrary_Paint);
            // 
            // dgvServers
            // 
            this.dgvServers.AllowUserToAddRows = false;
            this.dgvServers.AllowUserToDeleteRows = false;
            this.dgvServers.AllowUserToOrderColumns = true;
            this.dgvServers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvServers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServers.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvServers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvServers.EnableHeadersVisualStyles = false;
            this.dgvServers.Location = new System.Drawing.Point(300, 94);
            this.dgvServers.MultiSelect = false;
            this.dgvServers.Name = "dgvServers";
            this.dgvServers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServers.RowHeadersVisible = false;
            this.dgvServers.RowsEmptyText = "No Servers Found";
            this.dgvServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServers.Size = new System.Drawing.Size(320, 201);
            this.dgvServers.TabIndex = 15;
            this.dgvServers.SelectionChanged += new System.EventHandler(this.dgvServers_OnRowChange);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 514);
            this.Controls.Add(this.btnMetadata);
            this.Controls.Add(this.btnSetDlDir);
            this.Controls.Add(this.dgvEpisodes);
            this.Controls.Add(this.dgvSeasons);
            this.Controls.Add(this.dgvContent);
            this.Controls.Add(this.dgvLibrary);
            this.Controls.Add(this.dgvServers);
            this.Controls.Add(this.lblViewFullLog);
            this.Controls.Add(this.lblLibraryContentSections);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnLoadProfile);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnHTTPPlay);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.mtlDividerMain);
            this.Controls.Add(this.lblLibraryContent);
            this.Controls.Add(this.lblLibrarySections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlexDL by BRH Media";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cxtEpisodes.ResumeLayout(false);
            this.cxtEpisodeOptions.ResumeLayout(false);
            this.cxtLibrarySections.ResumeLayout(false);
            this.cxtContentOptions.ResumeLayout(false);
            this.cxtProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeasons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.ComponentModel.BackgroundWorker wkrUpdateContentView;
        private System.Windows.Forms.SaveFileDialog sfdSaveProfile;
        public System.Windows.Forms.FolderBrowserDialog fbdSave;
        private System.Windows.Forms.OpenFileDialog ofdLoadProfile;
        private System.ComponentModel.BackgroundWorker wkrDownloadAsync;
        public MaterialSkin.Controls.MaterialFlatButton btnDownload;
        public MaterialSkin.Controls.MaterialProgressBar pbMain;
        public MaterialSkin.Controls.MaterialLabel lblProgress;
        private MaterialSkin.Controls.MaterialFlatButton btnConnect;
        private MaterialSkin.Controls.MaterialFlatButton btnHTTPPlay;
        public MaterialSkin.Controls.MaterialLabel lblLog;
        public MaterialSkin.Controls.MaterialLabel lblProfile;
        private MaterialSkin.Controls.MaterialFlatButton btnLoadProfile;
        private System.Windows.Forms.ListBox lstLog;
        private MaterialSkin.Controls.MaterialDivider mtlDividerMain;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        public MaterialSkin.Controls.MaterialLabel lblLibraryContent;
        public MaterialSkin.Controls.MaterialLabel lblLibrarySections;
        private System.Windows.Forms.ToolTip tipMain;
        public MaterialSkin.Controls.MaterialLabel lblLibraryContentSections;
        private MaterialSkin.Controls.MaterialFlatButton btnPause;
        private libbrhscgui.Components.AbortableBackgroundWorker wkrGetMetadata;
        private System.Windows.Forms.LinkLabel lblViewFullLog;
        private Components.FlatDataGridView dgvServers;
        private Components.FlatDataGridView dgvLibrary;
        private Components.FlatDataGridView dgvContent;
        private Components.FlatDataGridView dgvSeasons;
        private Components.FlatDataGridView dgvEpisodes;
        private MaterialSkin.Controls.MaterialFlatButton btnSetDlDir;
        private MaterialSkin.Controls.MaterialContextMenuStrip cxtEpisodes;
        private System.Windows.Forms.ToolStripMenuItem itmDownloadThisEpisode;
        private System.Windows.Forms.ToolStripMenuItem itmDownloadAllEpisodes;
        private MaterialSkin.Controls.MaterialContextMenuStrip cxtLibrarySections;
        private System.Windows.Forms.ToolStripMenuItem itmManuallyLoadSection;
        private MaterialSkin.Controls.MaterialContextMenuStrip cxtEpisodeOptions;
        private System.Windows.Forms.ToolStripMenuItem itmEpisodeMetadata;
        private System.Windows.Forms.ToolStripMenuItem itmEpisodeDownload;
        private System.Windows.Forms.ToolStripMenuItem thisEpisodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thisSeasonToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip cxtContentOptions;
        private System.Windows.Forms.ToolStripMenuItem itmContentMetadata;
        private System.Windows.Forms.ToolStripMenuItem itmContentDownload;
        private MaterialSkin.Controls.MaterialFlatButton btnMetadata;
        private System.Windows.Forms.OpenFileDialog ofdMetadata;
        private MaterialSkin.Controls.MaterialContextMenuStrip cxtProfile;
        private System.Windows.Forms.ToolStripMenuItem loadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProfileToolStripMenuItem;
    }
}


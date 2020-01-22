namespace PlexDL.UI
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.btnExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.tmrCopied = new System.Windows.Forms.Timer(this.components);
            this.mtlPlayerControls = new MaterialSkin.Controls.MaterialDivider();
            this.lblTotalDuration = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimeSoFar = new MaterialSkin.Controls.MaterialLabel();
            this.tmrRefreshUI = new System.Windows.Forms.Timer(this.components);
            this.trkDuration = new System.Windows.Forms.TrackBar();
            this.btnNextTitle = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnStop = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSkipForward = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSkipBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPlayPause = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPrevTitle = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.trkDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.Black;
            this.pnlPlayer.Location = new System.Drawing.Point(0, 64);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(1280, 720);
            this.pnlPlayer.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(1164, 792);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = false;
            this.btnExit.Size = new System.Drawing.Size(103, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit Player";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrCopied
            // 
            this.tmrCopied.Interval = 1500;
            this.tmrCopied.Tick += new System.EventHandler(this.tmrCopied_Tick);
            // 
            // mtlPlayerControls
            // 
            this.mtlPlayerControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtlPlayerControls.Depth = 0;
            this.mtlPlayerControls.Location = new System.Drawing.Point(0, 784);
            this.mtlPlayerControls.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlPlayerControls.Name = "mtlPlayerControls";
            this.mtlPlayerControls.Size = new System.Drawing.Size(1280, 48);
            this.mtlPlayerControls.TabIndex = 4;
            // 
            // lblTotalDuration
            // 
            this.lblTotalDuration.AutoSize = true;
            this.lblTotalDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalDuration.Depth = 0;
            this.lblTotalDuration.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTotalDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalDuration.Location = new System.Drawing.Point(1093, 800);
            this.lblTotalDuration.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalDuration.Name = "lblTotalDuration";
            this.lblTotalDuration.Size = new System.Drawing.Size(65, 19);
            this.lblTotalDuration.TabIndex = 8;
            this.lblTotalDuration.Text = "00:00:00";
            this.lblTotalDuration.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // lblTimeSoFar
            // 
            this.lblTimeSoFar.AutoSize = true;
            this.lblTimeSoFar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeSoFar.Depth = 0;
            this.lblTimeSoFar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTimeSoFar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeSoFar.Location = new System.Drawing.Point(323, 800);
            this.lblTimeSoFar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimeSoFar.Name = "lblTimeSoFar";
            this.lblTimeSoFar.Size = new System.Drawing.Size(65, 19);
            this.lblTimeSoFar.TabIndex = 6;
            this.lblTimeSoFar.Text = "00:00:00";
            // 
            // trkDuration
            // 
            this.trkDuration.AutoSize = false;
            this.trkDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.trkDuration.Location = new System.Drawing.Point(393, 800);
            this.trkDuration.Name = "trkDuration";
            this.trkDuration.Size = new System.Drawing.Size(694, 19);
            this.trkDuration.TabIndex = 7;
            this.trkDuration.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btnNextTitle
            // 
            this.btnNextTitle.AutoSize = true;
            this.btnNextTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextTitle.Depth = 0;
            this.btnNextTitle.Icon = global::PlexDL.Properties.Resources.baseline_skip_next_black_18dp;
            this.btnNextTitle.Location = new System.Drawing.Point(266, 790);
            this.btnNextTitle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextTitle.Name = "btnNextTitle";
            this.btnNextTitle.Primary = false;
            this.btnNextTitle.Size = new System.Drawing.Size(44, 36);
            this.btnNextTitle.TabIndex = 5;
            this.btnNextTitle.UseVisualStyleBackColor = true;
            this.btnNextTitle.Click += new System.EventHandler(this.btnNextTitle_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Depth = 0;
            this.btnStop.Icon = global::PlexDL.Properties.Resources.baseline_stop_black_18dp;
            this.btnStop.Location = new System.Drawing.Point(58, 790);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.Primary = false;
            this.btnStop.Size = new System.Drawing.Size(44, 36);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSkipForward
            // 
            this.btnSkipForward.AutoSize = true;
            this.btnSkipForward.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSkipForward.Depth = 0;
            this.btnSkipForward.Icon = global::PlexDL.Properties.Resources.baseline_fast_forward_black_18dp;
            this.btnSkipForward.Location = new System.Drawing.Point(214, 790);
            this.btnSkipForward.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSkipForward.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSkipForward.Name = "btnSkipForward";
            this.btnSkipForward.Primary = false;
            this.btnSkipForward.Size = new System.Drawing.Size(44, 36);
            this.btnSkipForward.TabIndex = 4;
            this.btnSkipForward.UseVisualStyleBackColor = true;
            this.btnSkipForward.Click += new System.EventHandler(this.btnSkipForward_Click);
            // 
            // btnSkipBack
            // 
            this.btnSkipBack.AutoSize = true;
            this.btnSkipBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSkipBack.Depth = 0;
            this.btnSkipBack.Icon = global::PlexDL.Properties.Resources.baseline_fast_rewind_black_18dp;
            this.btnSkipBack.Location = new System.Drawing.Point(162, 790);
            this.btnSkipBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSkipBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSkipBack.Name = "btnSkipBack";
            this.btnSkipBack.Primary = false;
            this.btnSkipBack.Size = new System.Drawing.Size(44, 36);
            this.btnSkipBack.TabIndex = 3;
            this.btnSkipBack.UseVisualStyleBackColor = true;
            this.btnSkipBack.Click += new System.EventHandler(this.btnSkipBack_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.AutoSize = true;
            this.btnPlayPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlayPause.Depth = 0;
            this.btnPlayPause.Icon = global::PlexDL.Properties.Resources.baseline_play_arrow_black_48dp;
            this.btnPlayPause.Location = new System.Drawing.Point(6, 790);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPlayPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Primary = false;
            this.btnPlayPause.Size = new System.Drawing.Size(44, 36);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnPrevTitle
            // 
            this.btnPrevTitle.AutoSize = true;
            this.btnPrevTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevTitle.Depth = 0;
            this.btnPrevTitle.Icon = global::PlexDL.Properties.Resources.baseline_skip_previous_black_18dp;
            this.btnPrevTitle.Location = new System.Drawing.Point(110, 790);
            this.btnPrevTitle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevTitle.Name = "btnPrevTitle";
            this.btnPrevTitle.Primary = false;
            this.btnPrevTitle.Size = new System.Drawing.Size(44, 36);
            this.btnPrevTitle.TabIndex = 2;
            this.btnPrevTitle.UseVisualStyleBackColor = true;
            this.btnPrevTitle.Click += new System.EventHandler(this.btnPrevTitle_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 832);
            this.Controls.Add(this.btnPrevTitle);
            this.Controls.Add(this.btnNextTitle);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSkipForward);
            this.Controls.Add(this.btnSkipBack);
            this.Controls.Add(this.trkDuration);
            this.Controls.Add(this.lblTimeSoFar);
            this.Controls.Add(this.lblTotalDuration);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.mtlPlayerControls);
            this.Controls.Add(this.pnlPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Player";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unknown Title";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer;
        private MaterialSkin.Controls.MaterialFlatButton btnExit;
        private System.Windows.Forms.Timer tmrCopied;
        private MaterialSkin.Controls.MaterialFlatButton btnPlayPause;
        private MaterialSkin.Controls.MaterialDivider mtlPlayerControls;
        private MaterialSkin.Controls.MaterialLabel lblTotalDuration;
        private MaterialSkin.Controls.MaterialLabel lblTimeSoFar;
        private System.Windows.Forms.Timer tmrRefreshUI;
        private System.Windows.Forms.TrackBar trkDuration;
        private MaterialSkin.Controls.MaterialFlatButton btnSkipBack;
        private MaterialSkin.Controls.MaterialFlatButton btnSkipForward;
        private MaterialSkin.Controls.MaterialFlatButton btnStop;
        private MaterialSkin.Controls.MaterialFlatButton btnNextTitle;
        private MaterialSkin.Controls.MaterialFlatButton btnPrevTitle;
    }
}
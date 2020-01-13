using PlexDL;
namespace PlexDL.UI
{
    partial class frmDownloadManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownloadManager));
            this.mtlControlPanel = new MaterialSkin.Controls.MaterialDivider();
            this.btnDownload = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPause = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSkip = new MaterialSkin.Controls.MaterialFlatButton();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.flpDownloadQueue = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // mtlControlPanel
            // 
            this.mtlControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtlControlPanel.Depth = 0;
            this.mtlControlPanel.Location = new System.Drawing.Point(0, 64);
            this.mtlControlPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlControlPanel.Name = "mtlControlPanel";
            this.mtlControlPanel.Size = new System.Drawing.Size(800, 56);
            this.mtlControlPanel.TabIndex = 0;
            this.mtlControlPanel.Text = "materialDivider1";
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSize = true;
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownload.Depth = 0;
            this.btnDownload.Icon = null;
            this.btnDownload.Location = new System.Drawing.Point(13, 74);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Primary = true;
            this.btnDownload.Size = new System.Drawing.Size(142, 36);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Start Download";
            this.ttMain.SetToolTip(this.btnDownload, "Start/Cancel Current Download");
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.AutoSize = true;
            this.btnPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.Depth = 0;
            this.btnPause.Icon = ((System.Drawing.Image)(resources.GetObject("btnPause.Icon")));
            this.btnPause.Location = new System.Drawing.Point(163, 74);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPause.Name = "btnPause";
            this.btnPause.Primary = false;
            this.btnPause.Size = new System.Drawing.Size(44, 36);
            this.btnPause.TabIndex = 14;
            this.ttMain.SetToolTip(this.btnPause, "Pause/Resume Current Download");
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // btnSkip
            // 
            this.btnSkip.AutoSize = true;
            this.btnSkip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSkip.Depth = 0;
            this.btnSkip.Icon = global::PlexDL.Properties.Resources.baseline_skip_next_black_18dp;
            this.btnSkip.Location = new System.Drawing.Point(215, 74);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSkip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Primary = true;
            this.btnSkip.Size = new System.Drawing.Size(44, 36);
            this.btnSkip.TabIndex = 15;
            this.ttMain.SetToolTip(this.btnSkip, "Skip Current Download");
            this.btnSkip.UseVisualStyleBackColor = true;
            // 
            // flpDownloadQueue
            // 
            this.flpDownloadQueue.BackColor = System.Drawing.Color.White;
            this.flpDownloadQueue.Location = new System.Drawing.Point(0, 120);
            this.flpDownloadQueue.Name = "flpDownloadQueue";
            this.flpDownloadQueue.Padding = new System.Windows.Forms.Padding(15, 15, 10, 15);
            this.flpDownloadQueue.Size = new System.Drawing.Size(800, 330);
            this.flpDownloadQueue.TabIndex = 16;
            // 
            // frmDownloadManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpDownloadQueue);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.mtlControlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDownloadManager";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Manager";
            this.Load += new System.EventHandler(this.frmDownloadManager_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDownloadManager_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider mtlControlPanel;
        public MaterialSkin.Controls.MaterialFlatButton btnDownload;
        private MaterialSkin.Controls.MaterialFlatButton btnPause;
        public MaterialSkin.Controls.MaterialFlatButton btnSkip;
        private System.Windows.Forms.ToolTip ttMain;
        private System.Windows.Forms.FlowLayoutPanel flpDownloadQueue;
    }
}
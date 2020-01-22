namespace PlexDL.UI
{
    partial class LogViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewer));
            this.lstLogFiles = new System.Windows.Forms.ListBox();
            this.btnRefresh = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGoToLine = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBackup = new MaterialSkin.Controls.MaterialFlatButton();
            this.sfdBackup = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLogFiles
            // 
            this.lstLogFiles.FormattingEnabled = true;
            this.lstLogFiles.Location = new System.Drawing.Point(12, 74);
            this.lstLogFiles.Name = "lstLogFiles";
            this.lstLogFiles.Size = new System.Drawing.Size(142, 303);
            this.lstLogFiles.TabIndex = 0;
            this.lstLogFiles.SelectedIndexChanged += new System.EventHandler(this.lstLogFiles_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(13, 386);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Primary = false;
            this.btnRefresh.Size = new System.Drawing.Size(141, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh File List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMain.Location = new System.Drawing.Point(161, 74);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(501, 303);
            this.dgvMain.TabIndex = 11;
            this.dgvMain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(161, 386);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(73, 36);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGoToLine
            // 
            this.btnGoToLine.AutoSize = true;
            this.btnGoToLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoToLine.Depth = 0;
            this.btnGoToLine.Icon = null;
            this.btnGoToLine.Location = new System.Drawing.Point(242, 386);
            this.btnGoToLine.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoToLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoToLine.Name = "btnGoToLine";
            this.btnGoToLine.Primary = false;
            this.btnGoToLine.Size = new System.Drawing.Size(93, 36);
            this.btnGoToLine.TabIndex = 13;
            this.btnGoToLine.Text = "Go to Line";
            this.btnGoToLine.UseVisualStyleBackColor = true;
            this.btnGoToLine.Click += new System.EventHandler(this.btnGoToLine_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.AutoSize = true;
            this.btnBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBackup.Depth = 0;
            this.btnBackup.Icon = null;
            this.btnBackup.Location = new System.Drawing.Point(343, 386);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Primary = false;
            this.btnBackup.Size = new System.Drawing.Size(112, 36);
            this.btnBackup.TabIndex = 14;
            this.btnBackup.Text = "Backup Logs";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // sfdBackup
            // 
            this.sfdBackup.DefaultExt = "zip";
            this.sfdBackup.Filter = "Zip Archives|*.zip";
            this.sfdBackup.Title = "Backup Logs";
            // 
            // t1
            // 
            this.t1.Interval = 10;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(611, 386);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = false;
            this.btnExit.Size = new System.Drawing.Size(50, 36);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 435);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnGoToLine);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstLogFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogViewer";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogViewer_FormClosing);
            this.Load += new System.EventHandler(this.LogViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLogFiles;
        private MaterialSkin.Controls.MaterialFlatButton btnRefresh;
        public System.Windows.Forms.DataGridView dgvMain;
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private MaterialSkin.Controls.MaterialFlatButton btnGoToLine;
        private MaterialSkin.Controls.MaterialFlatButton btnBackup;
        private System.Windows.Forms.SaveFileDialog sfdBackup;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer t1;
        private MaterialSkin.Controls.MaterialFlatButton btnExit;
    }
}
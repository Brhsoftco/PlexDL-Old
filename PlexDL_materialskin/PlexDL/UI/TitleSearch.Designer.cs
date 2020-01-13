namespace PlexDL.UI
{
    partial class frmSearch
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
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.gbSearchMain = new System.Windows.Forms.GroupBox();
            this.btnStartSearch = new System.Windows.Forms.Button();
            this.gbSearchColumn = new System.Windows.Forms.GroupBox();
            this.cbxSearchColumn = new System.Windows.Forms.ComboBox();
            this.gbSearchMain.SuspendLayout();
            this.gbSearchColumn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(6, 19);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(212, 20);
            this.txtSearchTerm.TabIndex = 2;
            // 
            // gbSearchMain
            // 
            this.gbSearchMain.Controls.Add(this.btnStartSearch);
            this.gbSearchMain.Controls.Add(this.txtSearchTerm);
            this.gbSearchMain.Location = new System.Drawing.Point(5, 4);
            this.gbSearchMain.Name = "gbSearchMain";
            this.gbSearchMain.Size = new System.Drawing.Size(310, 51);
            this.gbSearchMain.TabIndex = 3;
            this.gbSearchMain.TabStop = false;
            this.gbSearchMain.Text = "Enter Search Term";
            // 
            // btnStartSearch
            // 
            this.btnStartSearch.Location = new System.Drawing.Point(224, 17);
            this.btnStartSearch.Name = "btnStartSearch";
            this.btnStartSearch.Size = new System.Drawing.Size(75, 23);
            this.btnStartSearch.TabIndex = 3;
            this.btnStartSearch.Text = "Go";
            this.btnStartSearch.UseVisualStyleBackColor = true;
            this.btnStartSearch.Click += new System.EventHandler(this.btnStartSearch_Click);
            // 
            // gbSearchColumn
            // 
            this.gbSearchColumn.Controls.Add(this.cbxSearchColumn);
            this.gbSearchColumn.Location = new System.Drawing.Point(5, 61);
            this.gbSearchColumn.Name = "gbSearchColumn";
            this.gbSearchColumn.Size = new System.Drawing.Size(310, 50);
            this.gbSearchColumn.TabIndex = 4;
            this.gbSearchColumn.TabStop = false;
            this.gbSearchColumn.Text = "Search Column";
            // 
            // cbxSearchColumn
            // 
            this.cbxSearchColumn.FormattingEnabled = true;
            this.cbxSearchColumn.Location = new System.Drawing.Point(7, 19);
            this.cbxSearchColumn.Name = "cbxSearchColumn";
            this.cbxSearchColumn.Size = new System.Drawing.Size(292, 21);
            this.cbxSearchColumn.TabIndex = 0;
            // 
            // frmSearch
            // 
            this.AcceptButton = this.btnStartSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(322, 116);
            this.Controls.Add(this.gbSearchColumn);
            this.Controls.Add(this.gbSearchMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for Content";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.gbSearchMain.ResumeLayout(false);
            this.gbSearchMain.PerformLayout();
            this.gbSearchColumn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.GroupBox gbSearchMain;
        private System.Windows.Forms.Button btnStartSearch;
        private System.Windows.Forms.GroupBox gbSearchColumn;
        private System.Windows.Forms.ComboBox cbxSearchColumn;
    }
}
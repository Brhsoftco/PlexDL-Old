namespace PlexDL.UI
{
    partial class SearchForm
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
            this.cbxSearchColumn = new System.Windows.Forms.ComboBox();
            this.txtSearchTerm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkDirectMatch = new MaterialSkin.Controls.MaterialCheckBox();
            this.mtlMain = new MaterialSkin.Controls.MaterialDivider();
            this.btnStartSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSearchField = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // cbxSearchColumn
            // 
            this.cbxSearchColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSearchColumn.FormattingEnabled = true;
            this.cbxSearchColumn.Location = new System.Drawing.Point(24, 179);
            this.cbxSearchColumn.Name = "cbxSearchColumn";
            this.cbxSearchColumn.Size = new System.Drawing.Size(331, 21);
            this.cbxSearchColumn.TabIndex = 2;
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.BackColor = System.Drawing.Color.White;
            this.txtSearchTerm.Depth = 0;
            this.txtSearchTerm.Hint = "Search Term";
            this.txtSearchTerm.Location = new System.Drawing.Point(24, 95);
            this.txtSearchTerm.MaxLength = 32767;
            this.txtSearchTerm.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.PasswordChar = '\0';
            this.txtSearchTerm.SelectedText = "";
            this.txtSearchTerm.SelectionLength = 0;
            this.txtSearchTerm.SelectionStart = 0;
            this.txtSearchTerm.Size = new System.Drawing.Size(331, 23);
            this.txtSearchTerm.TabIndex = 0;
            this.txtSearchTerm.TabStop = false;
            this.txtSearchTerm.UseSystemPasswordChar = false;
            // 
            // chkDirectMatch
            // 
            this.chkDirectMatch.AutoSize = true;
            this.chkDirectMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkDirectMatch.Depth = 0;
            this.chkDirectMatch.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkDirectMatch.Location = new System.Drawing.Point(24, 121);
            this.chkDirectMatch.Margin = new System.Windows.Forms.Padding(0);
            this.chkDirectMatch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDirectMatch.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDirectMatch.Name = "chkDirectMatch";
            this.chkDirectMatch.Ripple = true;
            this.chkDirectMatch.Size = new System.Drawing.Size(109, 30);
            this.chkDirectMatch.TabIndex = 1;
            this.chkDirectMatch.Text = "Direct Match";
            this.chkDirectMatch.UseVisualStyleBackColor = false;
            // 
            // mtlMain
            // 
            this.mtlMain.BackColor = System.Drawing.SystemColors.Control;
            this.mtlMain.Depth = 0;
            this.mtlMain.Location = new System.Drawing.Point(12, 75);
            this.mtlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlMain.Name = "mtlMain";
            this.mtlMain.Size = new System.Drawing.Size(355, 187);
            this.mtlMain.TabIndex = 0;
            this.mtlMain.Text = "materialDivider1";
            // 
            // btnStartSearch
            // 
            this.btnStartSearch.AutoSize = true;
            this.btnStartSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartSearch.Depth = 0;
            this.btnStartSearch.Icon = null;
            this.btnStartSearch.Location = new System.Drawing.Point(282, 215);
            this.btnStartSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartSearch.Name = "btnStartSearch";
            this.btnStartSearch.Primary = true;
            this.btnStartSearch.Size = new System.Drawing.Size(73, 36);
            this.btnStartSearch.TabIndex = 4;
            this.btnStartSearch.Text = "Search";
            this.btnStartSearch.UseVisualStyleBackColor = true;
            this.btnStartSearch.Click += new System.EventHandler(this.btnStartSearch_Click);
            // 
            // lblSearchField
            // 
            this.lblSearchField.AutoSize = true;
            this.lblSearchField.Depth = 0;
            this.lblSearchField.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSearchField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSearchField.Location = new System.Drawing.Point(20, 157);
            this.lblSearchField.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSearchField.Name = "lblSearchField";
            this.lblSearchField.Size = new System.Drawing.Size(91, 19);
            this.lblSearchField.TabIndex = 3;
            this.lblSearchField.Text = "Search Field";
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.AutoSize = true;
            this.btnCancelSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelSearch.Depth = 0;
            this.btnCancelSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSearch.Icon = null;
            this.btnCancelSearch.Location = new System.Drawing.Point(203, 215);
            this.btnCancelSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Primary = true;
            this.btnCancelSearch.Size = new System.Drawing.Size(73, 36);
            this.btnCancelSearch.TabIndex = 3;
            this.btnCancelSearch.Text = "Cancel";
            this.btnCancelSearch.UseVisualStyleBackColor = true;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // SearchForm
            // 
            this.AcceptButton = this.btnStartSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnCancelSearch;
            this.ClientSize = new System.Drawing.Size(379, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelSearch);
            this.Controls.Add(this.lblSearchField);
            this.Controls.Add(this.btnStartSearch);
            this.Controls.Add(this.chkDirectMatch);
            this.Controls.Add(this.cbxSearchColumn);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.mtlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search for Content";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxSearchColumn;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearchTerm;
        private MaterialSkin.Controls.MaterialCheckBox chkDirectMatch;
        private MaterialSkin.Controls.MaterialDivider mtlMain;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartSearch;
        private MaterialSkin.Controls.MaterialLabel lblSearchField;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelSearch;
    }
}
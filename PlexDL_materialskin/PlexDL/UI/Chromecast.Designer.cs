namespace PlexDL.UI
{
    partial class Chromecast
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
            this.btnSearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblPort = new MaterialSkin.Controls.MaterialLabel();
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblPortValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblNameValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddressValue = new MaterialSkin.Controls.MaterialLabel();
            this.lstChromecasts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Depth = 0;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(13, 183);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = false;
            this.btnSearch.Size = new System.Drawing.Size(280, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search for Available Chromecasts";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(9, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Device Information";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(9, 120);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 19);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "IP Address:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.BackColor = System.Drawing.Color.White;
            this.lblPort.Depth = 0;
            this.lblPort.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPort.Location = new System.Drawing.Point(9, 139);
            this.lblPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(41, 19);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Depth = 0;
            this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(9, 158);
            this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 19);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblPortValue
            // 
            this.lblPortValue.AutoSize = true;
            this.lblPortValue.BackColor = System.Drawing.Color.White;
            this.lblPortValue.Depth = 0;
            this.lblPortValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPortValue.Location = new System.Drawing.Point(120, 139);
            this.lblPortValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPortValue.Name = "lblPortValue";
            this.lblPortValue.Size = new System.Drawing.Size(71, 19);
            this.lblPortValue.TabIndex = 6;
            this.lblPortValue.Text = "Unknown";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.BackColor = System.Drawing.Color.White;
            this.lblNameValue.Depth = 0;
            this.lblNameValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNameValue.Location = new System.Drawing.Point(120, 158);
            this.lblNameValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(71, 19);
            this.lblNameValue.TabIndex = 7;
            this.lblNameValue.Text = "Unknown";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.BackColor = System.Drawing.Color.White;
            this.lblAddressValue.Depth = 0;
            this.lblAddressValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddressValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddressValue.Location = new System.Drawing.Point(120, 120);
            this.lblAddressValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(71, 19);
            this.lblAddressValue.TabIndex = 8;
            this.lblAddressValue.Text = "Unknown";
            // 
            // lstChromecasts
            // 
            this.lstChromecasts.FormattingEnabled = true;
            this.lstChromecasts.Location = new System.Drawing.Point(13, 228);
            this.lstChromecasts.Name = "lstChromecasts";
            this.lstChromecasts.Size = new System.Drawing.Size(280, 95);
            this.lstChromecasts.TabIndex = 9;
            this.lstChromecasts.SelectedIndexChanged += new System.EventHandler(this.lstChromecasts_SelectedIndexChanged);
            // 
            // Chromecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstChromecasts);
            this.Controls.Add(this.lblAddressValue);
            this.Controls.Add(this.lblNameValue);
            this.Controls.Add(this.lblPortValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnSearch);
            this.Name = "Chromecast";
            this.Text = "Cast <Title>";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblPort;
        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblPortValue;
        private MaterialSkin.Controls.MaterialLabel lblNameValue;
        private MaterialSkin.Controls.MaterialLabel lblAddressValue;
        private System.Windows.Forms.ListBox lstChromecasts;
    }
}
namespace PlexDL.UI
{
    partial class Connect 
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
            this.mtlMain = new MaterialSkin.Controls.MaterialDivider();
            this.lblAccountToken = new MaterialSkin.Controls.MaterialLabel();
            this.txtAccountToken = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnConnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // mtlMain
            // 
            this.mtlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtlMain.Depth = 0;
            this.mtlMain.Location = new System.Drawing.Point(8, 72);
            this.mtlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlMain.Name = "mtlMain";
            this.mtlMain.Size = new System.Drawing.Size(218, 113);
            this.mtlMain.TabIndex = 0;
            this.mtlMain.Text = "materialDivider1";
            this.mtlMain.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // lblAccountToken
            // 
            this.lblAccountToken.AutoSize = true;
            this.lblAccountToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccountToken.Depth = 0;
            this.lblAccountToken.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAccountToken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccountToken.Location = new System.Drawing.Point(18, 77);
            this.lblAccountToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAccountToken.Name = "lblAccountToken";
            this.lblAccountToken.Size = new System.Drawing.Size(111, 19);
            this.lblAccountToken.TabIndex = 1;
            this.lblAccountToken.Text = "Account Token";
            this.lblAccountToken.Click += new System.EventHandler(this.lblAccountToken_Click);
            // 
            // txtAccountToken
            // 
            this.txtAccountToken.Depth = 0;
            this.txtAccountToken.Hint = "";
            this.txtAccountToken.Location = new System.Drawing.Point(15, 100);
            this.txtAccountToken.MaxLength = 20;
            this.txtAccountToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAccountToken.Name = "txtAccountToken";
            this.txtAccountToken.PasswordChar = '\0';
            this.txtAccountToken.SelectedText = "";
            this.txtAccountToken.SelectionLength = 0;
            this.txtAccountToken.SelectionStart = 0;
            this.txtAccountToken.Size = new System.Drawing.Size(204, 23);
            this.txtAccountToken.TabIndex = 2;
            this.txtAccountToken.TabStop = false;
            this.txtAccountToken.UseSystemPasswordChar = false;
            this.txtAccountToken.Click += new System.EventHandler(this.txtAccountToken_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(73, 133);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = false;
            this.btnConnect.Size = new System.Drawing.Size(84, 36);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Connect
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 193);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtAccountToken);
            this.Controls.Add(this.lblAccountToken);
            this.Controls.Add(this.mtlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to Plex Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnect_FormClosing);
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDivider mtlMain;
        private MaterialSkin.Controls.MaterialLabel lblAccountToken;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccountToken;
        private MaterialSkin.Controls.MaterialFlatButton btnConnect;
    }
}
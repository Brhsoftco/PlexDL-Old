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
            this.lblAccountToken = new MaterialSkin.Controls.MaterialLabel();
            this.txtAccountToken = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkRelays = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnConnect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mtlMain = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // lblAccountToken
            // 
            this.lblAccountToken.AutoSize = true;
            this.lblAccountToken.BackColor = System.Drawing.SystemColors.Control;
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
            // chkRelays
            // 
            this.chkRelays.AutoSize = true;
            this.chkRelays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkRelays.Depth = 0;
            this.chkRelays.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkRelays.Location = new System.Drawing.Point(15, 126);
            this.chkRelays.Margin = new System.Windows.Forms.Padding(0);
            this.chkRelays.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkRelays.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkRelays.Name = "chkRelays";
            this.chkRelays.Ripple = true;
            this.chkRelays.Size = new System.Drawing.Size(101, 30);
            this.chkRelays.TabIndex = 4;
            this.chkRelays.Text = "Relays Only";
            this.chkRelays.UseVisualStyleBackColor = false;
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(69, 162);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = true;
            this.btnConnect.Size = new System.Drawing.Size(84, 36);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // mtlMain
            // 
            this.mtlMain.BackColor = System.Drawing.SystemColors.Control;
            this.mtlMain.Depth = 0;
            this.mtlMain.Location = new System.Drawing.Point(8, 72);
            this.mtlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtlMain.Name = "mtlMain";
            this.mtlMain.Size = new System.Drawing.Size(218, 133);
            this.mtlMain.TabIndex = 0;
            this.mtlMain.Text = "materialDivider1";
            this.mtlMain.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 213);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chkRelays);
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
        private MaterialSkin.Controls.MaterialLabel lblAccountToken;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAccountToken;
        private MaterialSkin.Controls.MaterialCheckBox chkRelays;
        private MaterialSkin.Controls.MaterialRaisedButton btnConnect;
        private MaterialSkin.Controls.MaterialDivider mtlMain;
    }
}
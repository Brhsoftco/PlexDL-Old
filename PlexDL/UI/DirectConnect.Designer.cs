namespace PlexDL.UI
{
    partial class DirectConnect
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
            this.btnConnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtServerIP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtServerPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(73, 144);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = false;
            this.btnConnect.Size = new System.Drawing.Size(84, 36);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Depth = 0;
            this.txtServerIP.Hint = "Server Address (IPv4)";
            this.txtServerIP.Location = new System.Drawing.Point(18, 82);
            this.txtServerIP.MaxLength = 15;
            this.txtServerIP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.PasswordChar = '\0';
            this.txtServerIP.SelectedText = "";
            this.txtServerIP.SelectionLength = 0;
            this.txtServerIP.SelectionStart = 0;
            this.txtServerIP.Size = new System.Drawing.Size(197, 23);
            this.txtServerIP.TabIndex = 10;
            this.txtServerIP.TabStop = false;
            this.txtServerIP.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(8, 72);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(217, 123);
            this.materialDivider1.TabIndex = 8;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Depth = 0;
            this.txtServerPort.Hint = "Server Port";
            this.txtServerPort.Location = new System.Drawing.Point(18, 111);
            this.txtServerPort.MaxLength = 5;
            this.txtServerPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.PasswordChar = '\0';
            this.txtServerPort.SelectedText = "";
            this.txtServerPort.SelectionLength = 0;
            this.txtServerPort.SelectionStart = 0;
            this.txtServerPort.Size = new System.Drawing.Size(197, 23);
            this.txtServerPort.TabIndex = 12;
            this.txtServerPort.TabStop = false;
            this.txtServerPort.Text = "32400";
            this.txtServerPort.UseSystemPasswordChar = false;
            // 
            // DirectConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 205);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.materialDivider1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectConnect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Direct Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnConnect;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServerIP;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServerPort;
    }
}
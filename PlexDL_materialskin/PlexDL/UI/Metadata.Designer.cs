namespace PlexDL.UI
{
    partial class frmTitleInformation
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
            this.flpActors = new System.Windows.Forms.FlowLayoutPanel();
            this.lblActors = new MaterialSkin.Controls.MaterialLabel();
            this.lblMetadata = new System.Windows.Forms.Label();
            this.lblSize = new MaterialSkin.Controls.MaterialLabel();
            this.lblSizeValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblRuntime = new MaterialSkin.Controls.MaterialLabel();
            this.lblRuntimeValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblGenre = new MaterialSkin.Controls.MaterialLabel();
            this.lblGenreValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblResolutionValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblResolution = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // flpActors
            // 
            this.flpActors.AutoScroll = true;
            this.flpActors.BackColor = System.Drawing.Color.White;
            this.flpActors.Location = new System.Drawing.Point(232, 100);
            this.flpActors.Name = "flpActors";
            this.flpActors.Size = new System.Drawing.Size(652, 341);
            this.flpActors.TabIndex = 1;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.BackColor = System.Drawing.Color.White;
            this.lblActors.Depth = 0;
            this.lblActors.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblActors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblActors.Location = new System.Drawing.Point(528, 78);
            this.lblActors.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(61, 19);
            this.lblActors.TabIndex = 2;
            this.lblActors.Text = "Starring";
            // 
            // lblMetadata
            // 
            this.lblMetadata.AutoSize = true;
            this.lblMetadata.BackColor = System.Drawing.Color.White;
            this.lblMetadata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetadata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMetadata.Location = new System.Drawing.Point(12, 328);
            this.lblMetadata.Name = "lblMetadata";
            this.lblMetadata.Size = new System.Drawing.Size(77, 18);
            this.lblMetadata.TabIndex = 3;
            this.lblMetadata.Text = "Metadata";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.BackColor = System.Drawing.Color.White;
            this.lblSize.Depth = 0;
            this.lblSize.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSize.Location = new System.Drawing.Point(12, 347);
            this.lblSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(41, 19);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size:";
            // 
            // lblSizeValue
            // 
            this.lblSizeValue.AutoSize = true;
            this.lblSizeValue.BackColor = System.Drawing.Color.White;
            this.lblSizeValue.Depth = 0;
            this.lblSizeValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSizeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSizeValue.Location = new System.Drawing.Point(104, 347);
            this.lblSizeValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSizeValue.Name = "lblSizeValue";
            this.lblSizeValue.Size = new System.Drawing.Size(71, 19);
            this.lblSizeValue.TabIndex = 5;
            this.lblSizeValue.Text = "Unknown";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.BackColor = System.Drawing.Color.White;
            this.lblRuntime.Depth = 0;
            this.lblRuntime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRuntime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRuntime.Location = new System.Drawing.Point(12, 366);
            this.lblRuntime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(68, 19);
            this.lblRuntime.TabIndex = 6;
            this.lblRuntime.Text = "Runtime:";
            // 
            // lblRuntimeValue
            // 
            this.lblRuntimeValue.AutoSize = true;
            this.lblRuntimeValue.BackColor = System.Drawing.Color.White;
            this.lblRuntimeValue.Depth = 0;
            this.lblRuntimeValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRuntimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRuntimeValue.Location = new System.Drawing.Point(104, 366);
            this.lblRuntimeValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRuntimeValue.Name = "lblRuntimeValue";
            this.lblRuntimeValue.Size = new System.Drawing.Size(71, 19);
            this.lblRuntimeValue.TabIndex = 7;
            this.lblRuntimeValue.Text = "Unknown";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.White;
            this.lblGenre.Depth = 0;
            this.lblGenre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGenre.Location = new System.Drawing.Point(12, 404);
            this.lblGenre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(52, 19);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre:";
            // 
            // lblGenreValue
            // 
            this.lblGenreValue.AutoSize = true;
            this.lblGenreValue.BackColor = System.Drawing.Color.White;
            this.lblGenreValue.Depth = 0;
            this.lblGenreValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGenreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGenreValue.Location = new System.Drawing.Point(104, 404);
            this.lblGenreValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGenreValue.Name = "lblGenreValue";
            this.lblGenreValue.Size = new System.Drawing.Size(71, 19);
            this.lblGenreValue.TabIndex = 9;
            this.lblGenreValue.Text = "Unknown";
            // 
            // lblResolutionValue
            // 
            this.lblResolutionValue.AutoSize = true;
            this.lblResolutionValue.BackColor = System.Drawing.Color.White;
            this.lblResolutionValue.Depth = 0;
            this.lblResolutionValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblResolutionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblResolutionValue.Location = new System.Drawing.Point(104, 385);
            this.lblResolutionValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResolutionValue.Name = "lblResolutionValue";
            this.lblResolutionValue.Size = new System.Drawing.Size(71, 19);
            this.lblResolutionValue.TabIndex = 11;
            this.lblResolutionValue.Text = "Unknown";
            // 
            // lblResolution
            // 
            this.lblResolution.AutoSize = true;
            this.lblResolution.BackColor = System.Drawing.Color.White;
            this.lblResolution.Depth = 0;
            this.lblResolution.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblResolution.Location = new System.Drawing.Point(12, 385);
            this.lblResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(85, 19);
            this.lblResolution.TabIndex = 10;
            this.lblResolution.Text = "Resolution:";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(743, 450);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = false;
            this.btnExit.Size = new System.Drawing.Size(139, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Close Metadata";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picPoster
            // 
            this.picPoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picPoster.BackgroundImage = global::PlexDL.Properties.Resources.image_not_available_png_8;
            this.picPoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPoster.Location = new System.Drawing.Point(12, 75);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(167, 250);
            this.picPoster.TabIndex = 12;
            this.picPoster.TabStop = false;
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "pmxml";
            this.sfdExport.Filter = "PlexMovie XML|*.pmxml";
            this.sfdExport.Title = "Export PlexMovie";
            // 
            // frmTitleInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 501);
            this.Controls.Add(this.picPoster);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResolutionValue);
            this.Controls.Add(this.lblResolution);
            this.Controls.Add(this.lblGenreValue);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblRuntimeValue);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.lblSizeValue);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblMetadata);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.flpActors);
            this.Name = "frmTitleInformation";
            this.Sizable = false;
            this.Text = "<Title>";
            this.Load += new System.EventHandler(this.frmTitleInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpActors;
        private MaterialSkin.Controls.MaterialLabel lblActors;
        private System.Windows.Forms.Label lblMetadata;
        private MaterialSkin.Controls.MaterialLabel lblSize;
        private MaterialSkin.Controls.MaterialLabel lblSizeValue;
        private MaterialSkin.Controls.MaterialLabel lblRuntime;
        private MaterialSkin.Controls.MaterialLabel lblRuntimeValue;
        private MaterialSkin.Controls.MaterialLabel lblGenre;
        private MaterialSkin.Controls.MaterialLabel lblGenreValue;
        private MaterialSkin.Controls.MaterialLabel lblResolutionValue;
        private MaterialSkin.Controls.MaterialLabel lblResolution;
        private System.Windows.Forms.PictureBox picPoster;
        private MaterialSkin.Controls.MaterialFlatButton btnExit;
        private System.Windows.Forms.SaveFileDialog sfdExport;
    }
}
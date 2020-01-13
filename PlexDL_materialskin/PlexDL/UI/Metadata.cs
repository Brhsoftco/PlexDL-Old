using MaterialSkin.Controls;
using PlexDL.Common.Structures;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PlexDL.UI
{
    public partial class frmTitleInformation : MaterialForm
    {
        public PlexMovie StreamingContent { get; set; } = new PlexMovie();

        public frmTitleInformation()
        {
            InitializeComponent();
        }

        private void LoadWorker(object sender, PlexDL.WaitWindow.WaitWindowEventArgs e)
        {
            if (!(StreamingContent.ContentGenre == ""))
            {
                if (lblGenreValue.InvokeRequired)
                {
                    lblGenreValue.BeginInvoke((MethodInvoker)delegate
                    {
                        lblGenreValue.Text = StreamingContent.ContentGenre;
                    });
                }
                else
                {
                    lblGenreValue.Text = StreamingContent.ContentGenre;
                }
            }
            if (!(StreamingContent.ContentDuration == 0))
            {
                if (lblRuntimeValue.InvokeRequired)
                {
                    lblRuntimeValue.BeginInvoke((MethodInvoker)delegate
                    {
                        lblRuntimeValue.Text = Common.Methods.CalculateTime(StreamingContent.ContentDuration);
                    });
                }
                else
                {
                    lblRuntimeValue.Text = Common.Methods.CalculateTime(StreamingContent.ContentDuration);
                }
            }
            if (!(StreamingContent.StreamInformation.ByteLength == 0))
            {
                if (lblSizeValue.InvokeRequired)
                {
                    lblSizeValue.BeginInvoke((MethodInvoker)delegate
                    {
                        lblSizeValue.Text = Common.Methods.FormatBytes(StreamingContent.StreamInformation.ByteLength);
                    });
                }
                else
                {
                    lblSizeValue.Text = Common.Methods.FormatBytes(StreamingContent.StreamInformation.ByteLength);
                }
            }
            if (!(StreamingContent.StreamResolution.Height == 0))
            {
                if (lblResolutionValue.InvokeRequired)
                {
                    lblResolutionValue.BeginInvoke((MethodInvoker)delegate
                    {
                        lblResolutionValue.Text = StreamingContent.StreamResolution.ResolutionString();
                    });
                }
                else
                {
                    lblResolutionValue.Text = StreamingContent.StreamResolution.ResolutionString();
                }
            }
            if (!(StreamingContent.StreamPosterUri == ""))
            {
                if (picPoster.InvokeRequired)
                {
                    picPoster.BeginInvoke((MethodInvoker)delegate
                    {
                        picPoster.BackgroundImage = Common.Methods.getImageFromUrl(StreamingContent.StreamPosterUri);
                    });
                }
                else
                {
                    picPoster.BackgroundImage = Common.Methods.getImageFromUrl(StreamingContent.StreamPosterUri);
                }
            }

            foreach (PlexActor a in StreamingContent.Actors)
            {
                Panel p = new Panel()
                {
                    Size = new Size(358, 125),
                    Location = new Point(3, 3),
                    BackColor = Color.White
                };
                Label lblActorName = new Label()
                {
                    Text = a.ActorName,
                    AutoSize = true,
                    Location = new Point(88, 3),
                    Font = new Font(FontFamily.GenericSansSerif, 13),
                    Visible = true
                };

                MaterialLabel lblActorRole = new MaterialLabel()
                {
                    Text = a.ActorRole,
                    AutoSize = true,
                    Location = new Point(112, 29),
                    Visible = true
                };
                PictureBox actorPortrait = new PictureBox()
                {
                    Size = new Size(79, 119),
                    Location = new Point(3, 3),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = Common.Methods.getImageFromUrl(a.ThumbnailUri),
                    Visible = true
                };
                p.Controls.Add(lblActorRole);
                p.Controls.Add(lblActorName);
                p.Controls.Add(actorPortrait);

                if (flpActors.InvokeRequired)
                {
                    flpActors.BeginInvoke((MethodInvoker)delegate
                    {
                        flpActors.Controls.Add(p);
                    });
                }
                else
                {
                    flpActors.Controls.Add(p);
                }

                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        this.Text = StreamingContent.StreamInformation.ContentTitle;
                        this.Refresh();
                    });
                }
                else
                {
                    this.Text = StreamingContent.StreamInformation.ContentTitle;
                    this.Refresh();
                }
            }
        }

        private void frmTitleInformation_Load(object sender, EventArgs e)
        {
            PlexDL.WaitWindow.WaitWindow.Show(LoadWorker, "Parsing Metadata");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ExportMetadata(string fileName)
        {
            PlexMovie subReq = StreamingContent;
            XmlSerializer xsSubmit = new XmlSerializer(typeof(PlexMovie));
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            StringWriter sww = new StringWriter();
            xmlSettings.Indent = true;
            xmlSettings.IndentChars = ("\t");
            xmlSettings.OmitXmlDeclaration = false;

            xsSubmit.Serialize(sww, subReq);

            File.WriteAllText(fileName, sww.ToString());
            MessageBox.Show("Successfully exported metadata!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (sfdExport.ShowDialog() == DialogResult.OK)
            {
                ExportMetadata(sfdExport.FileName);
            }
        }
    }
}
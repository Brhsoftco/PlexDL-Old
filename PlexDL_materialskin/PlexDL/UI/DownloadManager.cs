using MaterialSkin.Controls;
using PlexDL.Common.Structures;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PlexDL.UI
{
    public partial class frmDownloadManager : MaterialForm
    {
        public static List<DownloadInfo> Queue { get; set; } = new List<DownloadInfo>();

        public frmDownloadManager()
        {
            InitializeComponent();
        }

        public void AddToQueuePanel(DownloadInfo item)
        {
            Panel p = new Panel()
            {
                Size = new Size(764, 125),
                Location = new Point(3, 3),
                BackColor = Color.White
            };
            Label lblTitle = new Label()
            {
                Text = item.ContentTitle,
                AutoSize = true,
                Location = new Point(88, 4),
                Font = new Font(FontFamily.GenericSansSerif, 13),
                Visible = true
            };
            MaterialLabel lblSize = new MaterialLabel()
            {
                Text = Common.Methods.FormatBytes(item.ByteLength),
                AutoSize = true,
                Location = new Point(112, 29),
                Visible = true
            };
            MaterialLabel lblProgress = new MaterialLabel()
            {
                Text = "0B/" + Common.Methods.FormatBytes(item.ByteLength),
                AutoSize = true,
                Location = new Point(88, 88),
                Visible = true
            };
            MaterialLabel lblQueuePosition = new MaterialLabel()
            {
                Text = Queue.Count.ToString(),
                AutoSize = true,
                Visible = true
            };
            lblQueuePosition.Location = new Point(754 - lblQueuePosition.Width, 4);

            MaterialProgressBar pbDownloadProgress = new MaterialProgressBar()
            {
                AutoSize = false,
                Visible = true,
                Size = new Size(662, 5),
                Location = new Point(92, 110)
            };

            PictureBox titleThumb = new PictureBox()
            {
                Size = new Size(79, 119),
                Location = new Point(3, 3),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackgroundImage = Common.Methods.getImageFromUrl(item.ContentThumbnailUri),
                Visible = true
            };
            MaterialFlatButton btnRemoveDownload = new MaterialFlatButton()
            {
                Location = new Point(710, 29),
                Visible = true,
                Icon = PlexDL.Properties.Resources.baseline_cancel_black_18dp,
                AutoSize = true,
            };
            btnRemoveDownload.Click += new System.EventHandler(this.btnRemoveDownload_Click);

            p.Controls.Add(lblTitle);
            p.Controls.Add(lblSize);
            p.Controls.Add(lblQueuePosition);
            p.Controls.Add(lblProgress);
            p.Controls.Add(titleThumb);
            p.Controls.Add(pbDownloadProgress);
            p.Controls.Add(btnRemoveDownload);

            flpDownloadQueue.Controls.Add(p);
        }

        public void frmDownloadManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void btnRemoveDownload_Click(object sender, System.EventArgs e)
        {
            MaterialFlatButton removeDownload = (MaterialFlatButton)sender;
            Panel senderParent = (Panel)removeDownload.Parent;
            int senderIndex = flpDownloadQueue.Controls.IndexOf(removeDownload);
            //*code for stopping download goes here*
            RemoveFromQueuePanel(senderIndex);
        }

        public void RemoveFromQueuePanel(int index)
        {
            if (index <= (Queue.Count - 1))
            {
                flpDownloadQueue.Controls.RemoveAt(index);
            }
        }

        private void frmDownloadManager_Load(object sender, System.EventArgs e)
        {
        }
    }
}
using PlexDL.Common.Structures;
using PlexDL.UI;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PlexDL.Common
{
    public static class Methods
    {
        public static PlexObject MetadataFromFile(string fileName)
        {
            try
            {
                PlexObject subReq = null;

                XmlSerializer serializer = new XmlSerializer(typeof(PlexObject));

                StreamReader reader = new StreamReader(fileName);
                subReq = (PlexObject)serializer.Deserialize(reader);
                reader.Close();

                return subReq;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred\n\n" + ex.ToString(), "Metadata Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Home.recordException(ex.Message, "XMLMetadataLoadError");
                return new PlexObject();
            }
        }

        public static string CalculateTime(double Time)
        {
            string mm, ss, CalculatedTime;
            int h, m, s, T;

            Time = System.Math.Round(Time) / 1000;
            T = System.Convert.ToInt32(Time);

            h = (T / 3600);
            T = T % 3600;
            m = (T / 60);
            s = T % 60;

            if (m < 10)
                mm = string.Format("0{0}", m);
            else
                mm = m.ToString();
            if (s < 10)
                ss = string.Format("0{0}", s);
            else
                ss = s.ToString();

            CalculatedTime = string.Format("{0}:{1}:{2}", h, mm, ss);

            return CalculatedTime;
        }

        public static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return System.String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

        public static System.Drawing.Bitmap getImageFromUrl(string url)
        {
            if (url == "")
            {
                return PlexDL.Properties.Resources.image_not_available_png_8;
            }
            else
            {
                var request = System.Net.WebRequest.Create(url);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    return (System.Drawing.Bitmap)System.Drawing.Bitmap.FromStream(stream);
                }
            }
        }

        public static string removeIllegalCharacters(string illegal)
        {
            string regexSearch = new string(System.IO.Path.GetInvalidFileNameChars()) + new string(System.IO.Path.GetInvalidPathChars());
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(string.Format("[{0}]", System.Text.RegularExpressions.Regex.Escape(regexSearch)));
            return r.Replace(illegal, "");
        }
    }
}
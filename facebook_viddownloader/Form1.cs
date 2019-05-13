using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Threading;

namespace facebook_viddownloader
{
    public partial class Form1 : Form
    {
        private HtmlWeb web = new HtmlWeb();
        enum VidQuality { STD, HD };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlDocument doc;
            string keystart = "";
            string keyend = "";

            try
            {
                doc = web.Load(txtVideoURL.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            switch ((VidQuality)combVidQuality.SelectedIndex)
            {
                case VidQuality.STD:
                    keystart = ",sd_src:\"";
                    keyend = "\",hd_tag:\"";
                    break;

                case VidQuality.HD:
                    keystart = ",hd_src:\"";
                    keyend = "\",sd_src:\"";
                    break;
            }
            
            
            var start = doc.ParsedText.IndexOf(keystart);
            var end = doc.ParsedText.IndexOf(keyend);
            string vidDownloadLink = doc.ParsedText.Substring(start + keystart.Length, (end - keyend.Length + 1) - start);

            if (vidDownloadLink.Length > 0)
            {
                WebClient myWebClient = new WebClient();
                Uri uri = new Uri(vidDownloadLink);

                myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                // Specify a progress notification handler.
                myWebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

                myWebClient.DownloadFileAsync(uri, txtSaveVideoPath.Text);

                /*Thread readFileThread = new Thread(() => DownloadVideo(vidDownloadLink));
                readFileThread.Start();*/
            }
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            label2.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            label2.Text = "Completed";
        }

       /* bool DownloadVideo(string videoURL)
        {
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFileAsync(videoURL, txtSaveVideoPath.Text);
            return true;
        }*/
    }
}

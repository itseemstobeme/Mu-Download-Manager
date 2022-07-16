using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;
using AltoHttp.Exceptions;
using System.Net;
using System.Net.Sockets;

namespace MU__Download_Manager_
{
    public partial class DownloadWindow : Form
    {
        public DownloadWindow()
        {
            InitializeComponent();
        }
        public DownloadWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void DownloadWindow_Load(object sender, EventArgs e)
        {
            currentDownload = new downloadClass();
        }

        downloadClass currentDownload;  //Object for storing download data for adding into DB
        HttpDownloader httpDownloader;  //Object for downloading file
        MainWindow mainWindow;
        //START DOWNLOAD
        private void StartDownload_Click(object sender, EventArgs e)
        {
            if (Url.Text.Length > 0)
            {
                bool checkURL = IsValidUrl(Url.Text);
                if (!checkURL)
                {
                    MessageBox.Show("Error : Unable to find URL");
                    return;
                }


                if (FilePath.Text.Length > 0)
                {
                    httpDownloader = new HttpDownloader(Url.Text, $"{FilePath.Text}\\{Path.GetFileName(Url.Text)}");
                    FilePath.Text = FilePath.Text;
                    currentDownload.FileLocation = FilePath.Text;
                }
                else
                {
                    httpDownloader = new HttpDownloader(Url.Text, $"{ Application.StartupPath }\\{Path.GetFileName(Url.Text)}");
                    FilePath.Text = $"{ Application.StartupPath }";
                    currentDownload.FileLocation = Application.StartupPath;
                }


                httpDownloader.DownloadInfoReceived += HttpDownloader_DownloadInfoReceived;
                httpDownloader.StatusChanged += HttpDownloader_StatusChanged;
                httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
                httpDownloader.ErrorOccured += HttpDownloader_ErrorOccured;


                var webRequest = HttpWebRequest.Create(Url.Text);
                webRequest.Method = "Head";
                using (var webResponse = webRequest.GetResponse())
                {
                    var fileSize = webResponse.Headers.Get("Content-Length");
                    var fileSizeInMB = Math.Round(Convert.ToDouble(fileSize) / 1024.0 / 1024.0, 2);
                    currentDownload.FileSize = fileSizeInMB;
                }
                currentDownload.FileName = Path.GetFileName(Url.Text);
                currentDownload.FileStatus = "Downloading";


                ListViewItem lv = new ListViewItem(currentDownload.FileName);
                lv.SubItems.Add(currentDownload.FileSize.ToString() + " MB");
                lv.SubItems.Add(currentDownload.FileStatus);
                lv.SubItems.Add(currentDownload.FileLocation);

                if (!mainWindow.CheckDB(currentDownload))   //checking if duplicate download is being added or not
                {
                    mainWindow.listView1.Items.Add(lv);
                    mainWindow.UpdateDB(currentDownload);
                    httpDownloader.Start();

                    Url.Enabled = false;
                    FilePath.Enabled = false;
                    FileChooser.Enabled = false;

                    StartDownload.Enabled = false;
                    PauseDownload.Enabled = true;
                    StopDownload.Enabled = true;
                }
                else
                    MessageBox.Show("Error : Downloaded already exists, please choose a different location");
            }
        }

        //For checking whether the URL is valid or not
        public bool IsValidUrl(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                request.Timeout = 5000;
                request.Method = "HEAD";

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    response.Close();
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }


        //When download gets completed
        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                mainWindow.UpdateDownloadCompleted(currentDownload);
                MessageBox.Show("Download Completed");
                this.Hide();
            });
        }

        //When downloading is happening => making changes in speed, progress bar and downloaded data
        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
            SpeedValue.Text = string.Format("{0} MB/s", (e.SpeedInBytes / 1024d / 1024d).ToString("0.00"));
            SizeBySize.Text = string.Format("{0} / {1}",
                e.TotalBytesReceived.ToHumanReadableSize(),
                httpDownloader.Info.Length > 0 ? httpDownloader.Info.Length.ToHumanReadableSize() : "Unknown");
        }


        //Initial Download Info Received
        private void HttpDownloader_DownloadInfoReceived(object sender, EventArgs e)
        {
            PauseDownload.Enabled = httpDownloader.Info.AcceptRange;

            var saveDirectory = Path.GetDirectoryName(httpDownloader.FullFileName);
            var serverFileName = httpDownloader.Info.ServerFileName;
            var newFilePath = Path.Combine(saveDirectory, serverFileName);

            httpDownloader.FullFileName = newFilePath;
            
        }

        //Throws error encountered during downloading
        private void HttpDownloader_ErrorOccured(object sender, ErrorEventArgs e)
        {
            var ex = e.GetException();
            if (ex is FileValidationFailedException)
            {
                httpDownloader.Pause();
            }
        }

        //PAUSE AND RESUME DOWNLOAD
        private void PauseDownload_Click(object sender, EventArgs e)
        {
            if (PauseDownload.Text == "Pause")
                httpDownloader.Pause();
            else
                httpDownloader.Resume();
        }
        //Status Change for Pause/Resume download button
        private void HttpDownloader_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            if (e.Status == Status.Downloading)
            {
                PauseDownload.Text = "Pause";
            }
            else if (e.Status == Status.Paused)
            {
                PauseDownload.Text = "Resume";
            }
        }

        //For choosing path where the file will be downloaded
        private void FileChooser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Choose where the file has to be downloaded";
            fbd.ShowNewFolderButton = true;
            OpenFileDialog ofd = new OpenFileDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = fbd.SelectedPath;
            }

        }

        //Stop Downloading
        private void StopDownload_Click(object sender, EventArgs e)
        {
            httpDownloader.Pause();
            this.Close();
        }

    }
}

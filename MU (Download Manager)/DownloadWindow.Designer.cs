
namespace MU__Download_Manager_
{
    partial class DownloadWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Url = new System.Windows.Forms.TextBox();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.StartDownload = new System.Windows.Forms.Button();
            this.PauseDownload = new System.Windows.Forms.Button();
            this.StopDownload = new System.Windows.Forms.Button();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SpeedValue = new System.Windows.Forms.Label();
            this.SizeBySize = new System.Windows.Forms.Label();
            this.FileChooser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Path :";
            // 
            // Url
            // 
            this.Url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Url.Location = new System.Drawing.Point(172, 26);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(809, 31);
            this.Url.TabIndex = 2;
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FilePath.Location = new System.Drawing.Point(173, 85);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(809, 31);
            this.FilePath.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar1.Location = new System.Drawing.Point(172, 199);
            this.progressBar1.MarqueeAnimationSpeed = 1000000000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(809, 29);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(42, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Progress";
            // 
            // StartDownload
            // 
            this.StartDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.StartDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartDownload.Location = new System.Drawing.Point(172, 272);
            this.StartDownload.Name = "StartDownload";
            this.StartDownload.Size = new System.Drawing.Size(175, 34);
            this.StartDownload.TabIndex = 7;
            this.StartDownload.Text = "Start Download";
            this.StartDownload.UseVisualStyleBackColor = true;
            this.StartDownload.Click += new System.EventHandler(this.StartDownload_Click);
            // 
            // PauseDownload
            // 
            this.PauseDownload.Enabled = false;
            this.PauseDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.PauseDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PauseDownload.Location = new System.Drawing.Point(473, 272);
            this.PauseDownload.Name = "PauseDownload";
            this.PauseDownload.Size = new System.Drawing.Size(175, 34);
            this.PauseDownload.TabIndex = 8;
            this.PauseDownload.Text = "Pause";
            this.PauseDownload.UseVisualStyleBackColor = true;
            this.PauseDownload.Click += new System.EventHandler(this.PauseDownload_Click);
            // 
            // StopDownload
            // 
            this.StopDownload.Enabled = false;
            this.StopDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.StopDownload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StopDownload.Location = new System.Drawing.Point(806, 272);
            this.StopDownload.Name = "StopDownload";
            this.StopDownload.Size = new System.Drawing.Size(175, 34);
            this.StopDownload.TabIndex = 9;
            this.StopDownload.Text = "Stop Download";
            this.StopDownload.UseVisualStyleBackColor = true;
            this.StopDownload.Click += new System.EventHandler(this.StopDownload_Click);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Sitka Small", 10F);
            this.SpeedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpeedLabel.Location = new System.Drawing.Point(55, 142);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(87, 29);
            this.SpeedLabel.TabIndex = 10;
            this.SpeedLabel.Text = "Speed :";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Sitka Small", 10F);
            this.ProgressLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProgressLabel.Location = new System.Drawing.Point(468, 145);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(153, 29);
            this.ProgressLabel.TabIndex = 11;
            this.ProgressLabel.Text = "Downloaded :";
            // 
            // SpeedValue
            // 
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.SpeedValue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SpeedValue.Location = new System.Drawing.Point(168, 145);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(0, 26);
            this.SpeedValue.TabIndex = 12;
            // 
            // SizeBySize
            // 
            this.SizeBySize.AutoSize = true;
            this.SizeBySize.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.SizeBySize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SizeBySize.Location = new System.Drawing.Point(627, 148);
            this.SizeBySize.Name = "SizeBySize";
            this.SizeBySize.Size = new System.Drawing.Size(0, 26);
            this.SizeBySize.TabIndex = 20;
            // 
            // FileChooser
            // 
            this.FileChooser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileChooser.AutoSize = true;
            this.FileChooser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FileChooser.Location = new System.Drawing.Point(997, 85);
            this.FileChooser.Name = "FileChooser";
            this.FileChooser.Size = new System.Drawing.Size(32, 31);
            this.FileChooser.TabIndex = 4;
            this.FileChooser.Text = "...";
            this.FileChooser.UseVisualStyleBackColor = true;
            this.FileChooser.Click += new System.EventHandler(this.FileChooser_Click);
            // 
            // DownloadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1052, 321);
            this.Controls.Add(this.SizeBySize);
            this.Controls.Add(this.SpeedValue);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.StopDownload);
            this.Controls.Add(this.PauseDownload);
            this.Controls.Add(this.StartDownload);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FileChooser);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mu";
            this.Load += new System.EventHandler(this.DownloadWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartDownload;
        private System.Windows.Forms.Button PauseDownload;
        private System.Windows.Forms.Button StopDownload;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label SpeedValue;
        private System.Windows.Forms.Label SizeBySize;
        private System.Windows.Forms.Button FileChooser;
    }
}
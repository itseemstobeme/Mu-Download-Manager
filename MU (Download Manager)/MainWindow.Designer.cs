
namespace MU__Download_Manager_
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.listView1 = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddUrl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Size,
            this.Status,
            this.Location});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 165);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1178, 417);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.DoubleClick += new System.EventHandler(this.ListView_DoubleClick);
            // 
            // FileName
            // 
            this.FileName.Text = "File Name";
            this.FileName.Width = 195;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 146;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 186;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 651;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(42, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUrl,
            this.toolStripSeparator1,
            this.DeleteFile,
            this.toolStripSeparator2,
            this.Settings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(150, 150);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1178, 150);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddUrl
            // 
            this.AddUrl.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.AddUrl.Image = ((System.Drawing.Image)(resources.GetObject("AddUrl.Image")));
            this.AddUrl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddUrl.Name = "AddUrl";
            this.AddUrl.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.AddUrl.Size = new System.Drawing.Size(126, 145);
            this.AddUrl.Text = "Add Url";
            this.AddUrl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddUrl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddUrl.Click += new System.EventHandler(this.AddUrl_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 150);
            // 
            // DeleteFile
            // 
            this.DeleteFile.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.DeleteFile.Image = ((System.Drawing.Image)(resources.GetObject("DeleteFile.Image")));
            this.DeleteFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.Padding = new System.Windows.Forms.Padding(53, 0, 0, 0);
            this.DeleteFile.Size = new System.Drawing.Size(126, 145);
            this.DeleteFile.Text = "Delete";
            this.DeleteFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DeleteFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 150);
            // 
            // Settings
            // 
            this.Settings.Font = new System.Drawing.Font("Sitka Small", 9F);
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Settings.Size = new System.Drawing.Size(137, 145);
            this.Settings.Text = "Open File";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Settings.Click += new System.EventHandler(this.ListView_DoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1178, 594);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mu";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DeleteFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Settings;
        public System.Windows.Forms.ListView listView1;
    }
}


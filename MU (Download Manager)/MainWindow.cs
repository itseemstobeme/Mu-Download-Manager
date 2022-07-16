using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace MU__Download_Manager_
{
    public partial class MainWindow : Form
    {
        private ListViewColumnSorter columnSorter;
        public MainWindow()
        {
            InitializeComponent();
            columnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = columnSorter;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string cmdString = "SELECT * FROM DOWNLOADS";
            MySqlCommand cmd = new MySqlCommand(cmdString, mySqlConnection);

            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                ListViewItem listViewItem = new ListViewItem(mySqlDataReader.GetString(0));
                listViewItem.SubItems.Add(mySqlDataReader.GetString(1) + " MB");
                listViewItem.SubItems.Add(mySqlDataReader.GetString(2));

                string fileLocation = mySqlDataReader.GetString(3).Replace('/', '\\'); //Replacing forwardslash with backslash in the listView1
                listViewItem.SubItems.Add(fileLocation);
                listView1.Items.Add(listViewItem);
            }
            mySqlDataReader.Close();
            cmd.Dispose();
            mySqlConnection.Close();
        }


        //When we click 'Add Url' button
        private void AddUrl_Click(object sender, EventArgs e)
        {
            DownloadWindow downloadWindow = new DownloadWindow(this);
            downloadWindow.Show();
        }

        //For sorting the columns when clicked
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == columnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (columnSorter.Order == SortOrder.Ascending)
                {
                    columnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    columnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                columnSorter.SortColumn = e.Column;
                columnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        //Updating List View and DB=> will be called after download gets completed
        public void UpdateDownloadCompleted(downloadClass File)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; --i)
            {
                int size = listView1.Items[i].SubItems[1].Text.Length;
                if (listView1.Items[i].SubItems[0].Text == File.FileName &&
                    listView1.Items[i].SubItems[1].Text.Substring(0, size - 3) == File.FileSize.ToString() &&
                    listView1.Items[i].SubItems[2].Text == File.FileStatus &&
                    listView1.Items[i].SubItems[3].Text == File.FileLocation)
                {
                    //Updating list view
                    listView1.Items[i].SubItems[2].Text = "Completed";

                    //Updating DB
                    string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
                    mySqlConnection.Open();

                    string fileLocation = File.FileLocation.Replace('\\', '/'); //Replacing backslash with forwardslash so that it can be searched in DB

                    string cmdString = "UPDATE DOWNLOADS SET STATUS = 'Completed' WHERE "
                        + " FILENAME = '" + File.FileName +
                        "' AND FILESIZE = " + File.FileSize +
                        " AND LOCATION = '" + fileLocation + "'";
                    MySqlCommand cmd = new MySqlCommand(cmdString, mySqlConnection);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    mySqlConnection.Close();
                }
            }
        }

        //Updating DB after starting download 
        public void UpdateDB(downloadClass File)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string cmdString = "INSERT INTO DOWNLOADS VALUES(@FileName,@FileSize,@FileStatus,@FileLocation)";
            MySqlCommand cmd = new MySqlCommand(cmdString, mySqlConnection);

            cmd.Parameters.AddWithValue("@FileName", File.FileName);
            cmd.Parameters.AddWithValue("@FileSize", File.FileSize);
            cmd.Parameters.AddWithValue("@FileStatus", File.FileStatus);

            string fileLocation = File.FileLocation.Replace('\\', '/'); //Replacing backslash with forwardslash so that it can be searched in DB
            cmd.Parameters.AddWithValue("@FileLocation", fileLocation);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            mySqlConnection.Close();
        }

        //Checking DB before starting download for duplicated, returns a boolean value
        public bool CheckDB(downloadClass File)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string fileLocation = File.FileLocation.Replace('\\', '/');
            string cmdString = "SELECT * FROM DOWNLOADS WHERE FILENAME = '" + File.FileName +
                "' AND STATUS = 'Completed' AND LOCATION = '" + fileLocation + "'";
            MySqlCommand cmd = new MySqlCommand(cmdString, mySqlConnection);

            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                cmd.Dispose();
                mySqlConnection.Close();
                return true;            //returns true if it's non-existent in the DB
            }
            cmd.Dispose();
            mySqlConnection.Close();
            return false;               //retrurns false if its non-existent in the DB
        }

        //When 'Delete' button is clicked, updating listView1
        private void DeleteFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected downloads from the list?", "Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = listView1.SelectedItems.Count - 1; i >= 0; --i)
                {
                    ListViewItem listViewItemToBeDeleted = listView1.SelectedItems[i];
                    listView1.Items[listViewItemToBeDeleted.Index].Remove();
                    DeleteDB(listViewItemToBeDeleted);
                }
            }
        }

        //When 'Delete' button is clicked, updating DB
        private void DeleteDB(ListViewItem listViewItem)
        {
            downloadClass download = new downloadClass();
            download.FileName = listViewItem.SubItems[0].Text;

            int size = listViewItem.SubItems[1].Text.Length;
            download.FileSize = Convert.ToDouble(listViewItem.SubItems[1].Text.Substring(0, size - 3));
            download.FileStatus = listViewItem.SubItems[2].Text;
            download.FileLocation = listViewItem.SubItems[3].Text;

            //Updating DB => deleting record
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            string fileLocation = download.FileLocation.Replace('\\', '/'); //Replacing backslash with forwardslash so that it can be searched in DB

            string cmdString = "DELETE FROM DOWNLOADS WHERE FILENAME = '" + download.FileName +
                "' AND FILESIZE = " + download.FileSize +
                " AND STATUS = '" + download.FileStatus + 
                "' AND LOCATION = '" + fileLocation + "'";
            MySqlCommand cmd = new MySqlCommand(cmdString , mySqlConnection);

            cmd.ExecuteReader();
            cmd.Dispose();
            mySqlConnection.Close();
        }

        //When 'Open Files' is clicked or a file is double clicked in listView 
        private void ListView_DoubleClick(object sender,EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; --i)
            {
                ListViewItem listViewItemToBeOpened = listView1.SelectedItems[i];
                string filePath = listViewItemToBeOpened.SubItems[3].Text + '/' + listViewItemToBeOpened.SubItems[0].Text;

                System.Diagnostics.Process.Start(filePath);

            }
        }
    }
}

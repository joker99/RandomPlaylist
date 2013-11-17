using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RandomPlaylist.Properties;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace RandomPlaylist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (Settings.Default.SourceDirectories == null)
            {
                Settings.Default.SourceDirectories = new List<string>();
            }
            InitializeComponent();
            Size = Settings.Default.FormSize;
            listSourceDirectories.DataSource = Settings.Default.SourceDirectories;
        }

        private void btnAddSourceDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                AddSourceDirectory(folderBrowserDialog.SelectedPath);
            }
        }

        private void removeSourceDirectory_Click(object sender, EventArgs e)
        {
            if (listSourceDirectories.SelectedItem != null)
            {
                RemoveSourceDirectory(listSourceDirectories.SelectedItem.ToString());
            }
        }

        private void RemoveSourceDirectory(string directory)
        {
            Settings.Default.SourceDirectories.Remove(directory);
            listSourceDirectories.DataSource = null;
            listSourceDirectories.DataSource = Settings.Default.SourceDirectories;
        }

        private void AddSourceDirectory(string directory)
        {
            Settings.Default.SourceDirectories.Add(directory);
            listSourceDirectories.DataSource = null;
            listSourceDirectories.DataSource = Settings.Default.SourceDirectories;
        }

        private void btnSetTargetDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                txtTargetDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            panelProgress.Visible = true;
            SetStatus("Building list of mp3 files");
            //build mp3 list
            var files = (from directory in Settings.Default.SourceDirectories
                    from file in Directory.EnumerateFiles(directory, "*.mp3", SearchOption.AllDirectories)
                    select file).ToList();

            SetStatus("Calculating free space on target disk");
            // calculate target space
            var targetRoot = Path.GetPathRoot(Settings.Default.TargetDirectory);
            var freeSpace = (from drive in DriveInfo.GetDrives()
                            where drive.Name.Equals(targetRoot,StringComparison.InvariantCultureIgnoreCase)
                            select drive.AvailableFreeSpace).First();
            SetStatus("Building list of files: 0");

            List<string> filesToCopy = new List<string>();
            Random r = new Random();
            while (freeSpace > 10 * 1024*1024)
            {
                var index = r.Next(files.Count);
                filesToCopy.Add(files[index]);
                FileInfo f = new FileInfo(files[index]);
                freeSpace -= f.Length;
                files.RemoveAt(index);
                SetStatus("Building list of files:" + filesToCopy.Count);
            }
            int i = 1;
            foreach (var file in filesToCopy)
            {
                SetStatus(string.Format("Copying file {0} of {1}\r\n{2}", i++, filesToCopy.Count,file));
                File.Copy(file, Path.Combine(Settings.Default.TargetDirectory, i +"_" + Path.GetFileName(file)));
            }
            panelProgress.Visible = false;
            this.Enabled = true;
        }

        private void SetStatus(string status)
        {
            lblProgress.Text = status;
            Application.DoEvents();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.FormSize = Size;
            Settings.Default.Save();
        }
    }
}

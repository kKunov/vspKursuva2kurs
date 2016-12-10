using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace kursovaVSP
{
    public partial class Form1 : Form
    {
        private bool isFirstTimeInbeckwardsWay = true; // 

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This function calls the Folder browser dialog. And gets the path to the folder from the user
        /// </summary>
        private string GetPathFromTheDialog(string startFolder)
        {
            var fbd = new FolderBrowserDialog(); // Za dialoga za izbirane na papki
            fbd.SelectedPath = startFolder;
            fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath) && Directory.Exists(fbd.SelectedPath))
                return fbd.SelectedPath;

            return "";
        }
        
        private void btnSource_Click(object sender, EventArgs e)
        {
            string startFolder = "";

            if (tbSource.Text != "")
                startFolder = tbSource.Text;
            else if (tbDest.Text != "")
                startFolder = tbDest.Text;

            tbSource.Text = GetPathFromTheDialog(startFolder);
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            string startFolder = "";

            if (tbDest.Text != "")
                startFolder = tbDest.Text;
            else if (tbSource.Text != "")
                startFolder = tbSource.Text;

            tbDest.Text = GetPathFromTheDialog(startFolder);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDest.Text = "";
            tbSource.Text = "";
            lbExceptions.Items.Clear(); ;
            cbInBothWays.Checked = false;
        }

        /// <summary>
        /// This function calls the File Browser Dialog and waits the user to chose file or files to add to exceptions list
        /// </summary>
        private void btnException_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.Multiselect = true;
            ofd.ShowDialog();

            for (int i = 0; i < ofd.SafeFileNames.Length; i++)
                 lbExceptions.Items.Add(ofd.FileNames[i]);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lbExceptions.SelectedItems.Count - 1; i >= 0; i--)
                lbExceptions.Items.Remove(lbExceptions.SelectedItems[i]);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UpdateFolder(tbSource.Text, tbDest.Text);
        }
        
        public void UpdateFolder(string sourceFolder, string destFolder)
        {
            var sourceFolders = GetTheFolders(sourceFolder);
            var destFolders = GetTheFolders(destFolder);

            var sourceFiles = GetFilesPaths(sourceFolders);
            var destFiles = GetFilesPaths(destFolders);

            progBarStr.Maximum = 100;
            progBarStr.Step = 1;
            progBarStr.Value = 0;

            backgroundWorker1.RunWorkerAsync(new workerArguments(sourceFolder, destFolder, sourceFiles, destFiles));
        }

        /// <summary>
        /// This function gets all subdirectories of the argument directory "startingFolder"
        /// </summary>
        public static List<string> GetTheFolders(string startingFolder, bool isFirst = true)
        {
            var subFolders = new List<string>();

            if (isFirst)
                subFolders.Add(startingFolder);

            subFolders.AddRange(Directory.GetDirectories(startingFolder).ToList());

            for (int i = 0; i < subFolders.Count; i++)
            {
                subFolders.AddRange(GetTheFolders(subFolders[i], false));
            }

            return subFolders;
        }
        /// <summary>
        /// For every directory in the "folders" it gets all files and returning them in the end
        /// </summary>
        public static List<string> GetFilesPaths(List<string> folders)
        {
            var files = new List<string>();

            for (int i = 0; i < folders.Count; i++)
                files.AddRange(Directory.GetFiles(folders[i]).ToList());

            return files;
        }

        /// <summary>
        /// This function copy all the files that did not exists from the source folder to the dest folder
        /// </summary
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            var paramss = (workerArguments) e.Argument;

            for (int i = 0; i < paramss.sourceFiles.Count; i++)
            {
                if (!paramss.destFiles.Contains(paramss.sourceFiles[i]) && !lbExceptions.Items.Contains(paramss.sourceFiles[i]))
                { // if the dest folder did not contain that file and if that file is not in the exceptions copy it
                    string destFileFolder = Path.GetDirectoryName(paramss.sourceFiles[i]).Replace(paramss.sourceFolder, paramss.destFolder);

                    if (!Directory.Exists(destFileFolder))
                        Directory.CreateDirectory(destFileFolder);

                    if (!File.Exists(paramss.sourceFiles[i].Replace(paramss.sourceFolder, paramss.destFolder)))
                        File.Copy(paramss.sourceFiles[i], paramss.sourceFiles[i].Replace(paramss.sourceFolder, paramss.destFolder));
                }
                
                backgroundWorker.ReportProgress( (int) ( ( (double)i / (double) paramss.sourceFiles.Count ) * 100.0) );
            }

            backgroundWorker.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progBarStr.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// This event listener waits for the worker to end and then checks if the "in both ways", if its checked
        /// it start the UpdateFolder with swiched arguments
        /// </summary>
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (cbInBothWays.Checked && isFirstTimeInbeckwardsWay)
            {
                gbProgFirst.Text = "Progress backwards way:";
                UpdateFolder(tbDest.Text, tbSource.Text);
                gbProgFirst.Text = "Progress strigth way:";
                isFirstTimeInbeckwardsWay = false;
            }
            else
                isFirstTimeInbeckwardsWay = true;
        }
    }
}

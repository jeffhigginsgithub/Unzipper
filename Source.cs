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
using SharpCompress.Common;
using SharpCompress.Readers;
using SharpCompress.Archives;
using SharpCompress.Compressors;
using SharpCompress.Crypto;
using SharpCompress.Factories;
using SharpCompress.IO;
using SharpCompress.Writers;

namespace Unzipper
{
    public partial class MainForm : Form
    {
        private string selectedArchiveFile;
        private string selectedOutputFolder;
        private string archivePassword;
        private bool subfolderCreated;
        private string unzippedFile;
        private string unzippedFolder;
        private string unzipErrorMessage;
        private int unzippedFileCount;
        private int zippedFileCount;

        BackgroundWorker unzipBW;

        public MainForm()
        {
            InitializeComponent();

            //Create a new async background worker with handlers for the unzipping process
            unzipBW = new BackgroundWorker();
            
            unzipBW.DoWork += new DoWorkEventHandler(unzipBW_DoWork);
            unzipBW.ProgressChanged += new ProgressChangedEventHandler(unzipBW_ProgressChanged);
            unzipBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(unzipBW_RunWorkerCompleted);
            unzipBW.WorkerReportsProgress = true;
            unzipBW.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void archiveSelectButton_Click(object sender, EventArgs e)
        {
            //Open the zip file choice dialog, filtering to .zip .7z .rar
            OpenFileDialog fileSelectDialog = new OpenFileDialog();
            fileSelectDialog.Filter = "Archives|*.zip;*.7z;*.rar|All files (*.*)|*.*";
            DialogResult fileSelectResult = fileSelectDialog.ShowDialog();
            //If a file is selected
            if (fileSelectResult == DialogResult.OK)
            {
                selectedArchiveFile = fileSelectDialog.FileName;
                selectedFileNameLabel.Text = Path.GetFileName(selectedArchiveFile);
                selectedFileNameLabel.Visible = true;
                passwordRadioButton1.Enabled = true;
                passwordRadioButton2.Enabled = true;
                destinationRadioButton1.Enabled = true;
                destinationRadioButton2.Enabled = true;
                destinationFolderLabel.Text = Path.GetFileNameWithoutExtension(selectedArchiveFile);
                unzipButton.Enabled = true;
            }
            //If no file is selected
            else
            {
                selectedArchiveFile = null;
                selectedFileNameLabel.Text = null;
                selectedFileNameLabel.Visible = false;
                passwordRadioButton1.Enabled = false;
                passwordRadioButton2.Enabled = false;
                destinationRadioButton1.Enabled = false;
                destinationRadioButton1.Enabled = false;
                destinationFolderLabel.Text = null;
                selectedFolderLabel.Text = null;
                unzipButton.Enabled = false;
            }
        }

        //Bring up the destination folder selection dialog when the radio button is checked
        private void destinationRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (destinationRadioButton2.Checked)
            {
                folderSelectDialog = new FolderBrowserDialog();
                folderSelectDialog.SelectedPath = Path.GetDirectoryName(selectedArchiveFile);
                System.Threading.Thread.Sleep(100);
                //This key combo should scroll the dialog box to the selected folder
                SendKeys.Send("{TAB}{TAB}{RIGHT}");
                DialogResult folderSelectResult = folderSelectDialog.ShowDialog();
                //If a folder was selected
                if (folderSelectResult == DialogResult.OK)
                {
                    selectedFolderLabel.Text = folderSelectDialog.SelectedPath;
                    unzipButton.Enabled = true;
                }
                //If the folder selection dialog was cancelled
                else
                {
                    unzipButton.Enabled = false;
                }
            }
        }

        void unzipBW_DoWork(object sender, DoWorkEventArgs e)
        {
            if (destinationRadioButton1.Checked == true)
            {
                selectedOutputFolder = Path.GetDirectoryName(selectedArchiveFile) + @"\" + Path.GetFileNameWithoutExtension(selectedArchiveFile);
                //Create automatic subfolder if it doesn't exist and record that has been done
                if (!Directory.Exists(selectedOutputFolder))
                {
                    subfolderCreated = true;
                    Directory.CreateDirectory(selectedOutputFolder);
                }
                else
                {
                    subfolderCreated = false;
                }
            }
            //If the user browses and selects a folder themselves
            else
            {
                selectedOutputFolder = selectedFolderLabel.Text;
                subfolderCreated = false;
            }

            //Record the password for the archive
            if (passwordRadioButton1.Checked)
            {
                archivePassword = null;
            }
            else
            {
                archivePassword = passwordTextbox.Text;
            }

            unzipErrorMessage = null;
            zippedFileCount = 0;

            using (Stream stream = File.OpenRead(selectedArchiveFile))
                try
                {
                    //Open the archive to count the number of files inside
                    using (var reader = ArchiveFactory.Open(stream, new ReaderOptions() { Password = archivePassword }))
                    {
                        try
                        {
                            foreach (var entry in reader.Entries)
                            { 
                                if (!entry.IsDirectory)
                                {
                                    zippedFileCount++;
                                }
                            }

                            unzippedFileCount = 0;
                            //Open the progress report handler to record the archive name and filecount
                            unzipBW.ReportProgress(unzippedFileCount);
                            System.Threading.Thread.Sleep(100);
                        }

                        //If no password specified for password-protected .rar
                        catch (Exception ex) when (ex.Message == "Encrypted Rar archive has no password specified.")
                        {
                            if (subfolderCreated == true)
                            {
                                Directory.Delete(selectedOutputFolder, true);
                            }
                            unzipErrorMessage = "Invalid password";
                            return;
                        }

                        //For each file in the archive...
                        foreach (var entry in reader.Entries)
                        {
                            try
                            {
                                //Bomb out if the cancel button is pressed
                                if (unzipBW.CancellationPending)
                                {
                                    unzipErrorMessage = "Cancelled";
                                    unzipBW.ReportProgress(unzippedFileCount);
                                    System.Threading.Thread.Sleep(100);
                                    return;
                                }

                                //Different extraction options depending on whether overwrite files option has been selected
                                if (overwriteFilesCheckbox.Checked == true)
                                {
                                    entry.WriteToDirectory(selectedOutputFolder, new ExtractionOptions()
                                    {
                                        ExtractFullPath = true,
                                        Overwrite = true
                                    });
                                }
                                else
                                {
                                    entry.WriteToDirectory(selectedOutputFolder, new ExtractionOptions()
                                    {
                                        ExtractFullPath = true,
                                        Overwrite = false
                                    });
                                }

                                //Increment the file count if it's not a folder (to track unzip progress)
                                if (!entry.IsDirectory)
                                {
                                    unzippedFolder = null;
                                    unzippedFile = entry.ToString();
                                    unzippedFileCount++;
                                }
                                else
                                {
                                    unzippedFolder = entry.ToString();
                                }
                                //Report to progress handler to update form
                                unzipBW.ReportProgress(unzippedFileCount);
                                //Slow it down a touch to ensure duplicate lines aren't recorded in the log
                                System.Threading.Thread.Sleep(100);
                            }

                            //Password errors for the log
                            catch (Exception ex) when (ex.Message == "No password supplied for encrypted zip." | ex.Message == "Encrypted 7Zip archive has no password specified." | ex.Message == "bad password" | ex.Message == "Invalid Parameter" | ex.Message == "Data Error")
                            {
                                if (subfolderCreated == true)
                                {
                                    Directory.Delete(selectedOutputFolder, true);
                                }
                                else
                                {
                                    if (overwriteFilesCheckbox.Checked == false)
                                    {
                                        File.Delete(selectedOutputFolder + @"\" + entry);
                                    }
                                }
                                unzipErrorMessage = "Invalid password";
                                return;
                            }

                            //File already exists warning for the log
                            catch (Exception ex) when (ex.Message.Contains("already exists."))
                            {
                                if (!entry.IsDirectory)
                                {
                                    unzippedFileCount++;
                                    unzippedFile = entry.ToString();
                                    unzipErrorMessage = "File already exists";
                                    unzipBW.ReportProgress(unzippedFileCount);
                                    System.Threading.Thread.Sleep(100);
                                }    
                            }
                        }
                    }

                    //Start a new explorer.exe process if 'open folder when finished' is checked
                    if (openFolderCheckbox.Checked)
                    {
                        System.Diagnostics.Process.Start("explorer.exe", selectedOutputFolder);
                    }
                }

                //Different exceptions for 7z files
                catch (Exception ex) when (ex.Message == "Encrypted 7Zip archive has no password specified." | ex.Message == "Decoded stream does not match expected CRC.")
                {
                     if (subfolderCreated == true)
                    {
                        Directory.Delete(selectedOutputFolder, true);
                    }
                    unzipErrorMessage = "Invalid password";
                    unzipBW.ReportProgress(unzippedFileCount);
                    System.Threading.Thread.Sleep(100);
                    return;
                }
        }

        //Kick off extraction
        private void unzipButton_Click(object sender, EventArgs e)
        {
            cancelUnzipButton.Visible = true;
            unzipBW.RunWorkerAsync();
        }

        //Update the main form while unzip runs in the background worker process
        void unzipBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //If there aren't any errors then add the extracted file to the log            
            if (unzipErrorMessage == null)
            {
                //First entry which details the archive to be unzipped (sinec number of files unzipped = 0)
                if (unzippedFileCount == 0)
                {
                    unzipLogTextbox.SelectionFont = new Font(unzipLogTextbox.Font, FontStyle.Bold);
                    unzipLogTextbox.AppendText("Unzipping " + zippedFileCount + " file(s) from '" + selectedFileNameLabel.Text + "', please wait..." + Environment.NewLine);
                }
                //If files have been unzipped then log what they are and increase the progress bar value
                else if (unzippedFolder == null)
                {
                    unzipLogTextbox.AppendText("Unzipped " + unzippedFileCount + @"/" + zippedFileCount + " file(s): " + unzippedFile + Environment.NewLine);
                    Double zippedFileCountProgress = zippedFileCount;
                    Double unzippedFileCountProgress = unzippedFileCount;
                    Double progressTotal = 100 / zippedFileCountProgress * unzippedFileCountProgress;
                    unzipProgressBar.Value = Convert.ToInt32(progressTotal);
                }
                else
                {
                    //Log folder extraction
                    unzipLogTextbox.AppendText("Created folder " + unzippedFolder + Environment.NewLine);
                }
            }
            //Log the files that already exist in red, assuming 'overwrite files' isn't selected
            else if (unzipErrorMessage == "File already exists")
            {
                unzipLogTextbox.SelectionColor = Color.Red;
                unzipLogTextbox.AppendText("Skipped " + unzippedFileCount + @"/" + zippedFileCount + ", file already exists: " + unzippedFile + Environment.NewLine);
                Double zippedFileCountProgress = zippedFileCount;
                Double unzippedFileCountProgress = unzippedFileCount;
                Double progressTotal = 100 / zippedFileCountProgress * unzippedFileCountProgress;
                unzipProgressBar.Value = Convert.ToInt32(progressTotal);
                unzipErrorMessage = null;
            }
            //Log that the cancel button has been pressed
            else if (unzipErrorMessage == "Cancelled")
            {
                unzipLogTextbox.SelectionColor = Color.Red;
                unzipLogTextbox.SelectionFont = new Font(unzipLogTextbox.Font, FontStyle.Bold);
                unzipLogTextbox.AppendText("Cancelled" + Environment.NewLine);
                unzipProgressBar.Value = 0;
            }
        }

        //Log success or failure if the background worker process ends
        void unzipBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If it ends because of incorrect password
            if (unzipErrorMessage == "Invalid password")
            {
                unzipLogTextbox.SelectionColor = Color.Red;
                unzipLogTextbox.SelectionFont = new Font(unzipLogTextbox.Font, FontStyle.Bold);
                unzipLogTextbox.AppendText("Invalid password for this archive." + Environment.NewLine);
            }
            //If it ends because there are no more files to unzip (ie. it was successful)
            else if (unzipErrorMessage == null)
            {
                unzipLogTextbox.SelectionColor = Color.Green;
                unzipLogTextbox.SelectionFont = new Font(unzipLogTextbox.Font, FontStyle.Bold);
                unzipLogTextbox.AppendText("Done!" + Environment.NewLine);
            }
            cancelUnzipButton.Visible = false;
        }

        //Cancel the background worker/extraction process when the cancel button is clicked
        private void cancelUnzipButton_Click(object sender, EventArgs e)
        {
            unzipBW.CancelAsync();
        }

        //Enable/disable the password textbox when the radio button is changed
        private void passwordRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordRadioButton1.Checked)
            {
                passwordTextbox.Enabled = false;
            }
        }

        private void passwordRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordRadioButton2.Checked)
            {
                passwordTextbox.Enabled = true;
            }
        }

        //Clear the manually selected destination folder if the automatic folder option is checked
        private void destinationRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (destinationRadioButton1.Checked)
            {
                selectedFolderLabel.Text = null;
                unzipButton.Enabled = true;
            }
        }

        //Show the About form, not currently enabled
        private void aboutButton_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
        }

    }
}

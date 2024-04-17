using Microsoft.Win32;
using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCEInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random Random = new Random();

        object steamInstallPath = "";

        private void SetInputToSteamDir()
        {
            InstallDirTextBox.Enabled = false;
            if (steamInstallPath == null)
            {
                MessageBox.Show("Steam not found! Cannot copy files to Steam library.");
                FilesSteamCheckbox.Checked = false;
                FilesManualCheckbox.Checked = true;
                InstallDirTextBox.Enabled = true;
                return;
            }
            string steamPath = steamInstallPath.ToString();
            InstallDirTextBox.Text = steamPath + @"\steamapps\sourcemods\csce\";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // dont ask
        }

        string lastManualInput = "";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Copy files to steam
            if (!FilesSteamCheckbox.Checked) return;
            lastManualInput = InstallDirTextBox.Text;
            SetInputToSteamDir();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // I'll do it myself
            if (!FilesManualCheckbox.Checked) return;
            if(lastManualInput != "") InstallDirTextBox.Text = lastManualInput;
            InstallDirTextBox.Enabled = true;

        }

        bool canContinue = true;
        string BrowserDownloadUrl = "";

        private void GetStuff()
        {

            steamInstallPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", null);
            SetInputToSteamDir();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var client = new GitHubClient(new ProductHeaderValue("CSCEInstaller"));
            var repo = "counter-strike-community-edition";//"CSCEInstaller";
            Release releases;
            try
            {
                var rels = await client.Repository.Release.GetAll("Siomek101", repo);
                label7.Text = "Version: " + rels[0].Name;
                releases = rels[0]; 
            }
            catch (NotFoundException)
            {
                GetStuff();
                MessageBox.Show("(release not found) Couldn't find CS:CE files on GitHub. Make sure you have internet connection and restart the installer. Installer will not continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var archive = "CSCEBinary.zip";
            foreach (var item in releases.Assets)
            {
                if(item.Name == archive)
                {
                    BrowserDownloadUrl = item.BrowserDownloadUrl;
                    break;
                }
            }
            if(BrowserDownloadUrl == "")
            {
                MessageBox.Show("Couldn't find CS:CE files on GitHub. Make sure you have internet connection and restart the installer. Installer will not continue.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                canContinue = false;
            }
            // MessageBox.Show(
            //     $"The latest release is tagged at {releases.TagName} and is named {releases.Name}, {assets}");
            GetStuff();
        }

        private void LogBox(object msg)
        {
            LogTextBox.Text += msg + Environment.NewLine;
        }
        private void LogBoxNoLn(object msg)
        {
            LogTextBox.Text += msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!canContinue || BrowserDownloadUrl == "")
            {
                LogBox("Couldn't find CS:CE files on GitHub. Make sure you have internet connection and restart the installer. Installer will not continue.");
                return;
            }
            LogBox("Starting Install Process");
            InstallSettingsPanel.Enabled = false;
            string installPath = InstallDirTextBox.Text;
            if(!Directory.Exists(installPath))
            {
                LogBox("Directory " + installPath + " doesn't exist. Creating...");
                Directory.CreateDirectory(installPath);
            } else
            {
                if(MessageBox.Show("Directory already exists. Do you want to replace it?", "Question", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    InstallSettingsPanel.Enabled = true;
                    LogBox("Installation aborted.");
                    return;
                }
            }
            // Old approach
            //LogBox("Extracting files into temporary folder...");
            //var tempFolder = Path.GetTempPath() + @"CSCE_TEMP" + Random.Next(100000, (int) (int.MaxValue/100));
            //Directory.CreateDirectory(tempFolder);
            //LogBox("Temporary folder: " + tempFolder);
            var tempFilename = Path.GetTempFileName();
            LogBox($"Downloading archive from Github");
            using (var client = new WebClient())
            {
                client.DownloadProgressChanged += (a,b) =>
                {
                    bytesLabel.Text = $"{b.BytesReceived}/{b.TotalBytesToReceive} bytes";
                };
                client.DownloadFileCompleted += (a, b) =>
                {
                    if (b.Error != null)
                    {
                        LogBox("Couldn't download file: ");
                        LogBox(b.Error.Message);
                        return;
                    }
                    LogBox("Extracting files using 7-zip...");
                    var sevenzipArgs = $"x \"{tempFilename}\" -y -o{installPath}";
                    Process.Start("7z.exe", sevenzipArgs).WaitForExit();

                    LogBox("Done!");
                    InstallSettingsPanel.Visible = false;
                    FinishLabel.Visible = true;
                    FinishExitButton.Visible = true;
                };
                client.DownloadFileAsync(new Uri(BrowserDownloadUrl), tempFilename);
            }
            //LogBox("Removing temporary folder...");
            //Directory.Delete(tempFolder, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Siomek101/CSCEInstaller");
        }

        private void InstallSettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

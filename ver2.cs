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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCEInstaller
{
    public partial class Ver2 : Form
    {
        public Ver2()
        {
            InitializeComponent();
        }

        Random Random = new Random();

        object steamInstallPath = "";
        bool canSteam = true;

        private void SetInputToSteamDir()
        {
            //InstallDirBox.Enabled = false;
            if (steamInstallPath == null)
            {
                //MessageBox.Show("Steam not found! Cannot copy files to Steam library.");
                InstallDirBox.Enabled = true;
                useSteam = false;
                button2_Click_1(this, new EventArgs());
                return;
            }
            string steamPath = steamInstallPath.ToString();
            InstallDirBox.Text = steamPath + @"\steamapps\sourcemods\csce\";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // dont ask
        }

        string lastManualInput = "";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Copy files to steam
            //if (!FilesSteamCheckbox.Checked) return;
            //lastManualInput = InstallDirTextBox.Text;
            //SetInputToSteamDir();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // I'll do it myself
            //if (!FilesManualCheckbox.Checked) return;
            //if(lastManualInput != "") InstallDirTextBox.Text = lastManualInput;
            //InstallDirTextBox.Enabled = true;

        }

        bool canContinue = true;
        string BrowserDownloadUrl = "";

        private void GetStuff()
        {

            steamInstallPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", null);
            SetInputToSteamDir();
        }

        List<Release> releases = new List<Release>();

        private async void Ver2_Load(object sender, EventArgs e)
        {
            var client = new GitHubClient(new ProductHeaderValue("CSCEInstaller"));
            var repo = "counter-strike-community-edition";//"CSCEInstaller";
            Release release;
            try
            {
                var nl = Environment.NewLine;
                var rels = await client.Repository.Release.GetAll("Siomek101", repo);
                VersionLabel.Text = "Version: " + rels[0].Name;
                release = rels[0];
               
                foreach( Release r in rels) {
                    ChangeLog.Text += $"{r.Name}{nl} {r.Body}{nl}";
                    releases.Add(r);
                }
            }
            catch (NotFoundException)
            {
                GetStuff();
                MessageBox.Show("(release not found) Couldn't find CS:CE files on GitHub. Make sure you have internet connection and restart the installer. Installer will not continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var archive = "CSCEBinary.zip";
            foreach (var item in release.Assets)
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
            StatusText.Text = "Status: " + msg;
        }

        bool useSteam = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if(!canContinue || BrowserDownloadUrl == "")
            {
                LogBox("Couldn't find CS:CE files on GitHub. Make sure you have internet connection and restart the installer. Installer will not continue.");
                return;
            }
            LogBox("Starting Install Process");
            StartInstallPanel.Enabled = false;
            string installPath = InstallDirBox.Text;
            if(!Directory.Exists(installPath))
            {
                LogBox("Directory " + installPath + " doesn't exist. Creating...");
                Directory.CreateDirectory(installPath);
            } else
            {
                if(MessageBox.Show("Directory already exists. Do you want to replace it?", "Question", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    StartInstallPanel.Enabled = true;
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
                    LogBox($"Downloading: {(b.BytesReceived) / 1000}/{(b.TotalBytesToReceive) / 1000} KB {b.ProgressPercentage}%");
                    StatusProgress.Value = b.ProgressPercentage;
                    StatusProgress.Visible = true;
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


                    var sevenzipArgs = $"/c abc.bat x \"{tempFilename}\" -y -o{installPath}";
                    Process.Start("cmd.exe", sevenzipArgs).WaitForExit();

                    LogBox($"Deleting temp file");
                    File.Delete(tempFilename);

                    LogBox("Installed!");
                    //InstallSettingsPanel.Visible = false;
                    //FinishLabel.Visible = true;
                    //FinishExitButton.Visible = true;


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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(!canSteam)
            {
                MessageBox.Show("Steam not found! Custom Install required");
            } else
            useSteam = !useSteam;
            if(useSteam)
            {
                lastManualInput = InstallDirBox.Text;
                SetInputToSteamDir();
            } else
            {
                if(lastManualInput != "")InstallDirBox.Text = lastManualInput;
            }
            InstallDirPanel.Visible = !useSteam;
            InstallButton.Text = useSteam ? "Steam Install" : "Custom Install";
        }

        Point mouseDown = new Point();
        bool moving = false;

        private void Ver2_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            mouseDown = e.Location;
        }

        private void Ver2_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void Ver2_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving)
            Location = new Point(Location.X - mouseDown.X + e.X, Location.Y - mouseDown.Y + e.Y);
        }
    }
}

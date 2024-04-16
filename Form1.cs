using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            steamInstallPath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", null);
            SetInputToSteamDir();
        }

        private void LogBox(object msg)
        {
            LogTextBox.Text += msg + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            LogBox("Extracting files using 7-zip...");
            var sevenzipArgs = "x archive.7z -o"+installPath;
            Process.Start("7z.exe", sevenzipArgs).WaitForExit();

            LogBox("Done!");
            InstallSettingsPanel.Visible = false;
            FinishLabel.Visible = true;
            FinishExitButton.Visible = true;

            //LogBox("Removing temporary folder...");
            //Directory.Delete(tempFolder, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

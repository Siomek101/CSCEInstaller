namespace CSCEInstaller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilesManualCheckbox = new System.Windows.Forms.RadioButton();
            this.FilesSteamCheckbox = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InstallDirTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InstallSettingsPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.FinishLabel = new System.Windows.Forms.Label();
            this.FinishExitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bytesLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.InstallSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSCEInstaller.Properties.Resources.icon_huge;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(168, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Counter-Strike: Community Edition Updater";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FilesManualCheckbox);
            this.panel1.Controls.Add(this.FilesSteamCheckbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 77);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FilesManualCheckbox
            // 
            this.FilesManualCheckbox.AutoSize = true;
            this.FilesManualCheckbox.Location = new System.Drawing.Point(6, 56);
            this.FilesManualCheckbox.Name = "FilesManualCheckbox";
            this.FilesManualCheckbox.Size = new System.Drawing.Size(124, 17);
            this.FilesManualCheckbox.TabIndex = 2;
            this.FilesManualCheckbox.Text = "Extract files Manually";
            this.FilesManualCheckbox.UseVisualStyleBackColor = true;
            this.FilesManualCheckbox.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FilesSteamCheckbox
            // 
            this.FilesSteamCheckbox.AutoSize = true;
            this.FilesSteamCheckbox.Checked = true;
            this.FilesSteamCheckbox.Location = new System.Drawing.Point(6, 20);
            this.FilesSteamCheckbox.Name = "FilesSteamCheckbox";
            this.FilesSteamCheckbox.Size = new System.Drawing.Size(168, 30);
            this.FilesSteamCheckbox.TabIndex = 1;
            this.FilesSteamCheckbox.TabStop = true;
            this.FilesSteamCheckbox.Text = "Copy files to Steam\r\n(show CS:CE in Steam Library)";
            this.FilesSteamCheckbox.UseVisualStyleBackColor = true;
            this.FilesSteamCheckbox.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select install option";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InstallDirTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 26);
            this.panel2.TabIndex = 3;
            // 
            // InstallDirTextBox
            // 
            this.InstallDirTextBox.Location = new System.Drawing.Point(89, 4);
            this.InstallDirTextBox.Name = "InstallDirTextBox";
            this.InstallDirTextBox.Size = new System.Drawing.Size(322, 20);
            this.InstallDirTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Install directory:";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Enabled = false;
            this.LogTextBox.Location = new System.Drawing.Point(12, 257);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(575, 181);
            this.LogTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstallSettingsPanel
            // 
            this.InstallSettingsPanel.Controls.Add(this.bytesLabel);
            this.InstallSettingsPanel.Controls.Add(this.label6);
            this.InstallSettingsPanel.Controls.Add(this.button1);
            this.InstallSettingsPanel.Controls.Add(this.panel1);
            this.InstallSettingsPanel.Controls.Add(this.panel2);
            this.InstallSettingsPanel.Location = new System.Drawing.Point(168, 40);
            this.InstallSettingsPanel.Name = "InstallSettingsPanel";
            this.InstallSettingsPanel.Size = new System.Drawing.Size(422, 211);
            this.InstallSettingsPanel.TabIndex = 5;
            this.InstallSettingsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InstallSettingsPanel_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 241);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Note: CS:CE needs Source SDK 2013 Multiplayer to run. It\'s FREE\r\nto download on s" +
    "team. Standalone version is coming soon.\r\n";
            // 
            // FinishLabel
            // 
            this.FinishLabel.AutoSize = true;
            this.FinishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FinishLabel.Location = new System.Drawing.Point(172, 41);
            this.FinishLabel.Name = "FinishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(302, 48);
            this.FinishLabel.TabIndex = 5;
            this.FinishLabel.Text = "Thanks for installing CS:CE!\r\nIf you want CS:CE to appear in your Steam Library,\r" +
    "\nyou need to restart Steam.";
            this.FinishLabel.Visible = false;
            // 
            // FinishExitButton
            // 
            this.FinishExitButton.Location = new System.Drawing.Point(511, 227);
            this.FinishExitButton.Name = "FinishExitButton";
            this.FinishExitButton.Size = new System.Drawing.Size(75, 23);
            this.FinishExitButton.TabIndex = 6;
            this.FinishExitButton.Text = "Finish";
            this.FinishExitButton.UseVisualStyleBackColor = true;
            this.FinishExitButton.Visible = false;
            this.FinishExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Made by Siomek101";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "With help of [fill]";
            this.label5.Visible = false;
            // 
            // bytesLabel
            // 
            this.bytesLabel.AutoSize = true;
            this.bytesLabel.Location = new System.Drawing.Point(6, 195);
            this.bytesLabel.Name = "bytesLabel";
            this.bytesLabel.Size = new System.Drawing.Size(0, 13);
            this.bytesLabel.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Version: ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FinishExitButton);
            this.Controls.Add(this.FinishLabel);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InstallSettingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Counter-Strike: Community Edition Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.InstallSettingsPanel.ResumeLayout(false);
            this.InstallSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton FilesManualCheckbox;
        private System.Windows.Forms.RadioButton FilesSteamCheckbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox InstallDirTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel InstallSettingsPanel;
        private System.Windows.Forms.Label FinishLabel;
        private System.Windows.Forms.Button FinishExitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label bytesLabel;
        private System.Windows.Forms.Label label7;
    }
}


namespace CSCEInstaller
{
    partial class Ver2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InstallButton = new System.Windows.Forms.Button();
            this.StartInstallPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.StatusProgress = new System.Windows.Forms.ProgressBar();
            this.InstallDirBox = new System.Windows.Forms.TextBox();
            this.InstallDirPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangeLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartInstallPanel.SuspendLayout();
            this.InstallDirPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CS:CE Installer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(846, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.InstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstallButton.Location = new System.Drawing.Point(0, 0);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(206, 63);
            this.InstallButton.TabIndex = 3;
            this.InstallButton.Text = "Steam Install";
            this.InstallButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InstallButton.UseVisualStyleBackColor = false;
            this.InstallButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StartInstallPanel
            // 
            this.StartInstallPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(154)))));
            this.StartInstallPanel.Controls.Add(this.button2);
            this.StartInstallPanel.Controls.Add(this.VersionLabel);
            this.StartInstallPanel.Controls.Add(this.InstallButton);
            this.StartInstallPanel.Location = new System.Drawing.Point(619, 267);
            this.StartInstallPanel.Name = "StartInstallPanel";
            this.StartInstallPanel.Size = new System.Drawing.Size(251, 63);
            this.StartInstallPanel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(207, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "▼";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(204)))));
            this.VersionLabel.Location = new System.Drawing.Point(24, 36);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(72, 13);
            this.VersionLabel.TabIndex = 4;
            this.VersionLabel.Text = "Version: 0.0.0";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.BackColor = System.Drawing.Color.Transparent;
            this.StatusText.Location = new System.Drawing.Point(619, 251);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(60, 13);
            this.StatusText.TabIndex = 5;
            this.StatusText.Text = "Status: Idle";
            // 
            // StatusProgress
            // 
            this.StatusProgress.Location = new System.Drawing.Point(619, 330);
            this.StatusProgress.Name = "StatusProgress";
            this.StatusProgress.Size = new System.Drawing.Size(251, 12);
            this.StatusProgress.TabIndex = 5;
            this.StatusProgress.Visible = false;
            // 
            // InstallDirBox
            // 
            this.InstallDirBox.Location = new System.Drawing.Point(0, 27);
            this.InstallDirBox.Name = "InstallDirBox";
            this.InstallDirBox.Size = new System.Drawing.Size(251, 20);
            this.InstallDirBox.TabIndex = 7;
            // 
            // InstallDirPanel
            // 
            this.InstallDirPanel.Controls.Add(this.label3);
            this.InstallDirPanel.Controls.Add(this.InstallDirBox);
            this.InstallDirPanel.Location = new System.Drawing.Point(619, 201);
            this.InstallDirPanel.Name = "InstallDirPanel";
            this.InstallDirPanel.Size = new System.Drawing.Size(251, 47);
            this.InstallDirPanel.TabIndex = 8;
            this.InstallDirPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Install directory:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = global::CSCEInstaller.Properties.Resources.test1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(882, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeLog
            // 
            this.ChangeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ChangeLog.ForeColor = System.Drawing.Color.White;
            this.ChangeLog.Location = new System.Drawing.Point(0, 388);
            this.ChangeLog.Multiline = true;
            this.ChangeLog.Name = "ChangeLog";
            this.ChangeLog.ReadOnly = true;
            this.ChangeLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChangeLog.Size = new System.Drawing.Size(882, 393);
            this.ChangeLog.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Changelog";
            // 
            // Ver2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(882, 783);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeLog);
            this.Controls.Add(this.InstallDirPanel);
            this.Controls.Add(this.StatusProgress);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.StartInstallPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ver2";
            this.Text = "Counter-Strike: Community Edition Updater";
            this.Load += new System.EventHandler(this.Ver2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ver2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ver2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ver2_MouseUp);
            this.StartInstallPanel.ResumeLayout(false);
            this.StartInstallPanel.PerformLayout();
            this.InstallDirPanel.ResumeLayout(false);
            this.InstallDirPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Panel StartInstallPanel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.ProgressBar StatusProgress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox InstallDirBox;
        private System.Windows.Forms.Panel InstallDirPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChangeLog;
        private System.Windows.Forms.Label label4;
    }
}


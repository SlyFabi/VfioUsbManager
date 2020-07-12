namespace VfioUsbClient
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnDetach = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleLookingGlassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cmTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(81, 12);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(224, 28);
            this.cbProfile.TabIndex = 0;
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.cbProfile_SelectedIndexChanged);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(16, 18);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(57, 20);
            this.lblProfile.TabIndex = 1;
            this.lblProfile.Text = "Profile:";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(20, 68);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(102, 40);
            this.btnAttach.TabIndex = 2;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnDetach
            // 
            this.btnDetach.Location = new System.Drawing.Point(273, 68);
            this.btnDetach.Name = "btnDetach";
            this.btnDetach.Size = new System.Drawing.Size(102, 40);
            this.btnDetach.TabIndex = 3;
            this.btnDetach.Text = "Detach";
            this.btnDetach.UseVisualStyleBackColor = true;
            this.btnDetach.Click += new System.EventHandler(this.btnDetach_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.cmTray;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "VFIO USB Client";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // cmTray
            // 
            this.cmTray.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attachToolStripMenuItem,
            this.detachToolStripMenuItem,
            this.toggleLookingGlassToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmTray.Name = "cmTray";
            this.cmTray.Size = new System.Drawing.Size(253, 132);
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.attachToolStripMenuItem.Text = "Attach";
            this.attachToolStripMenuItem.Click += new System.EventHandler(this.attachToolStripMenuItem_Click);
            // 
            // detachToolStripMenuItem
            // 
            this.detachToolStripMenuItem.Name = "detachToolStripMenuItem";
            this.detachToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.detachToolStripMenuItem.Text = "Detach";
            this.detachToolStripMenuItem.Click += new System.EventHandler(this.detachToolStripMenuItem_Click);
            // 
            // toggleLookingGlassToolStripMenuItem
            // 
            this.toggleLookingGlassToolStripMenuItem.Name = "toggleLookingGlassToolStripMenuItem";
            this.toggleLookingGlassToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.toggleLookingGlassToolStripMenuItem.Text = "Toggle Looking Glass";
            this.toggleLookingGlassToolStripMenuItem.Click += new System.EventHandler(this.toggleLookingGlassToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = global::VfioUsbClient.Properties.Resources.info_13213;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Location = new System.Drawing.Point(348, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(30, 32);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::VfioUsbClient.Properties.Resources.settings_icon_icons_com_49858;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Location = new System.Drawing.Point(312, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(30, 32);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 115);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnDetach);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.cbProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VFIO USB Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.cmTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnDetach;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip cmTray;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ToolStripMenuItem toggleLookingGlassToolStripMenuItem;
        private System.Windows.Forms.Button btnAbout;
    }
}


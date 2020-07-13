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
using VfioUsbClient.Profiles;
using VfioUsbClient.Properties;
using VfioUsbClient.UI;

namespace VfioUsbClient
{
    public partial class MainWindow : Form
    {
        private Profile _currentProfile;
        private bool _quit;

        public MainWindow()
        {
            InitializeComponent();
            Globals.Init();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ReloadProfiles();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            var procs = Process.GetProcessesByName("looking-glass-host");
            if (procs.Length > 0)
                toggleLookingGlassToolStripMenuItem.Text = "Stop Looking Glass";
            else
                toggleLookingGlassToolStripMenuItem.Text = "Start Looking Glass";

            if (Settings.Default.startMinimized)
            {
                trayIcon.Visible = true;
                Hide();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            trayIcon.Visible = true;
            Hide();
            e.Cancel = !_quit;
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            trayIcon.Visible = false;
        }

        private void cbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentProfile = Globals.Manager.GetProfileByName((string)cbProfile.SelectedItem);
            Settings.Default.lastProfileIndex = cbProfile.SelectedIndex;
            Settings.Default.Save();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.ShowDialog(this);
            ReloadProfiles();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog(this);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (Globals.Client == null)
            {
                MessageBox.Show(this, "Please specify an ip address for the server !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_currentProfile != null)
            {
                bool res;
                try
                {
                    res = Globals.Client.AttachProfile(_currentProfile);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Could not connect to the server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(res)
                    MessageBox.Show(this, "OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Internal server error !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetach_Click(object sender, EventArgs e)
        {
            if (Globals.Client == null)
            {
                MessageBox.Show(this, "Please specify an ip address for the server !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_currentProfile != null)
            {
                bool res;
                try
                {
                    res = Globals.Client.DetachProfile(_currentProfile);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Could not connect to the server !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (res)
                    MessageBox.Show(this, "OK", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Internal server error !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void attachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAttach_Click(sender, null);
        }

        private void detachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDetach_Click(sender, null);
        }

        private void toggleLookingGlassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleLookingGlass();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _quit = true;
            Close();
        }

        private void ReloadProfiles()
        {
            cbProfile.Items.Clear();
            cbProfile.Items.Add("<Select a Profile>");
            Globals.Manager.Profiles.ForEach(p => cbProfile.Items.Add(p.Name));

            if(Settings.Default.lastProfileIndex < cbProfile.Items.Count)
                cbProfile.SelectedIndex = Settings.Default.lastProfileIndex;
        }

        private void ToggleLookingGlass()
        {
            var procs = Process.GetProcessesByName("looking-glass-host");
            if (procs.Length > 0)
            {
                if(Settings.Default.changeInputLG)
                    SwitchDisplayInput(false);

                foreach (var proc in procs)
                {
                    proc.Kill();
                }

                toggleLookingGlassToolStripMenuItem.Text = "Start Looking Glass";
            }
            else
            {
                if (Settings.Default.changeInputLG)
                    SwitchDisplayInput(true);

                if (!File.Exists(Settings.Default.lgPath))
                {
                    MessageBox.Show(this, "Please set the correct looking glass exe path !", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var proc = new Process();
                proc.StartInfo.FileName = Settings.Default.lgPath;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";
                proc.Start();
                toggleLookingGlassToolStripMenuItem.Text = "Stop Looking Glass";
            }
        }

        private void SwitchDisplayInput(bool toLinux)
        {
            var input = new DisplayInput();
            input.displayNum = Settings.Default.displayId;

            if(toLinux)
                input.inputId = Settings.Default.linuxInputId;
            else
                input.inputId = Settings.Default.vmInputId;

            try
            {
                var res = Globals.Client.SwitchDisplayInput(input);
                if (!res)
                    throw new Exception();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Could not switch display input !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

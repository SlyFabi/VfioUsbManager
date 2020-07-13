using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VfioUsbClient.Properties;

namespace VfioUsbClient.UI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            tbServerIp.Text = Settings.Default.serverIP;
            cbStartMinimized.Checked = Settings.Default.startMinimized;
            tbLGPath.Text = Settings.Default.lgPath;
            cbSwitchInput.Checked = Settings.Default.changeInputLG;
            tbDisplayId.Text = Settings.Default.displayId.ToString();
            tbVmInputId.Text = Settings.Default.vmInputId.ToString("X2");
            tbLinuxInputId.Text = Settings.Default.linuxInputId.ToString("X2");

            cbSwitchInput_CheckedChanged(sender, e);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.Default.serverIP = tbServerIp.Text;
            Settings.Default.startMinimized = cbStartMinimized.Checked;
            Settings.Default.lgPath = tbLGPath.Text;
            Settings.Default.changeInputLG = cbSwitchInput.Checked;

            try
            {
                Settings.Default.displayId = int.Parse(tbDisplayId.Text);
                Settings.Default.vmInputId = int.Parse(tbVmInputId.Text, System.Globalization.NumberStyles.HexNumber);
                Settings.Default.linuxInputId = int.Parse(tbLinuxInputId.Text, System.Globalization.NumberStyles.HexNumber);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Please enter a valid hex number for your input ids !", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.Default.Save();
            Globals.Init();
            Close();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProfileEditor_Click(object sender, EventArgs e)
        {
            var editor = new ProfileEditor();
            editor.ShowDialog(this);
        }

        private void btnLGBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Select looking-glass-host.exe";
            dialog.Filter = "Looking Glass Host|looking-glass-host.exe";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                tbLGPath.Text = dialog.FileName;
            }
        }

        private void cbSwitchInput_CheckedChanged(object sender, EventArgs e)
        {
            tbDisplayId.Enabled = cbSwitchInput.Checked;
            tbVmInputId.Enabled = cbSwitchInput.Checked;
            tbLinuxInputId.Enabled = cbSwitchInput.Checked;
        }
    }
}

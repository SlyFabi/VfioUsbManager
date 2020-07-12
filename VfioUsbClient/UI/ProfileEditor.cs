using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VfioUsbClient.Profiles;

namespace VfioUsbClient
{
    public partial class ProfileEditor : Form
    {
        private Profile _currentProfile;

        public ProfileEditor()
        {
            InitializeComponent();
        }

        private void ProfileEditor_Load(object sender, EventArgs e)
        {
            ReloadProfiles();
        }

        private void cbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentProfile = Globals.Manager.GetProfileByName((string)cbProfile.SelectedItem);
            ReloadProfileData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var inputBox = new InputBox("Enter Profile name");
            inputBox.ShowDialog(this);

            if (inputBox.Input != null)
            {
                Globals.Manager.AddProfile(new Profile(inputBox.Input));
                ReloadProfiles();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbProfile.SelectedIndex != 0)
            {
                Globals.Manager.RemoveProfile(_currentProfile);
                ReloadProfiles();
            }
            else
            {
                MessageBox.Show(this, "No Profile selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            if (cbProfile.SelectedIndex != 0)
            {
                var selector = new UsbDeviceSelector();
                selector.ShowDialog(this);

                if (selector.SelectedDevice != null)
                {
                    _currentProfile.Devices.Add(selector.SelectedDevice);
                    ReloadProfileData();
                    Globals.Manager.Save();
                }
            }
            else
            {
                MessageBox.Show(this, "No Profile selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            if (cbProfile.SelectedIndex == 0)
            {
                MessageBox.Show(this, "No Profile selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lbDevices.Items.Count > 0)
            {
                var device = (UsbDevice)lbDevices.SelectedItem;
                _currentProfile.Devices.Remove(device);
                ReloadProfileData();
                Globals.Manager.Save();
            }
        }

        private void ReloadProfiles()
        {
            cbProfile.Items.Clear();
            cbProfile.Items.Add("<Select a Profile>");
            Globals.Manager.Profiles.ForEach(p => cbProfile.Items.Add(p.Name));

            cbProfile.SelectedIndex = 0;
            _currentProfile = null;
        }

        private void ReloadProfileData()
        {
            lbDevices.Items.Clear();
            if (_currentProfile == null)
                return;

            foreach (var device in _currentProfile.Devices)
            {
                lbDevices.Items.Add(device);
            }
        }
    }
}

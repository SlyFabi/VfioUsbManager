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
    public partial class UsbDeviceSelector : Form
    {
        public UsbDevice SelectedDevice { get; private set; }

        public UsbDeviceSelector()
        {
            InitializeComponent();
        }

        private void UsbDeviceSelector_Load(object sender, EventArgs e)
        {
            if (Globals.Client == null)
            {
                MessageBox.Show(this, "Please specify an ip address for the server !", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
                return;
            }

            List<UsbDevice> usbDevices = new List<UsbDevice>();
            try
            {
                usbDevices = Globals.Client.GetUsbDevices();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Could not get device list !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (var device in usbDevices)
            {
                lbDevices.Items.Add(device);
            }
        }

        private void lbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDevice = (UsbDevice)lbDevices.SelectedItem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SelectedDevice == null)
            {
                MessageBox.Show(this, "No device selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedDevice = null;
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VfioUsbClient.Profiles
{
    [Serializable]
    [XmlType("Device")]
    public class UsbDevice
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("VendorId")]
        public int VendorId { get; set; }
        [XmlElement("DeviceId")]
        public int DeviceId { get; set; }

        public UsbDevice()
        {
        }

        public UsbDevice(string name, int vendorId, int deviceId)
        {
            Name = name;
            VendorId = vendorId;
            DeviceId = deviceId;
        }

        public override string ToString()
        {
            return VendorId.ToString("X4") + ":" + DeviceId.ToString("X4") + " " + Name;
        }
    }
}

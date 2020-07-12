using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VfioUsbClient.Profiles
{
    [Serializable]
    [XmlType("Profile")]
    [XmlInclude(typeof(UsbDevice))]
    public class Profile
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlArray("Devices")]
        [XmlArrayItem("Device", typeof(UsbDevice))]
        public List<UsbDevice> Devices { get; set; }

        public Profile()
        {
        }

        public Profile(string name)
        {
            Name = name;
            Devices = new List<UsbDevice>();
        }
    }
}

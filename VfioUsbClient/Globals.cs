using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VfioUsbClient.Profiles;
using VfioUsbClient.Properties;

namespace VfioUsbClient
{
    public static class Globals
    {
        public static Client Client { get; private set; }
        public static ProfileManager Manager { get; } = ProfileManager.Load();

        public static void Init()
        {
            if (!string.IsNullOrEmpty(Settings.Default.serverIP))
            {
                Client = new Client(Settings.Default.serverIP);
            }
        }
    }
}

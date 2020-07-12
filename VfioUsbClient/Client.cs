using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VfioUsbClient.Profiles;

namespace VfioUsbClient
{
    public class Client
    {
        private TcpClient TcpClient { get; set; }

        private string _ip;
        private int _port;

        public Client(string ip)
            : this(ip, 20235)
        {
        }

        public Client(string ip, int port)
        {
            _ip = ip;
            _port = port;
        }

        public bool AttachProfile(Profile profile)
        {
            var cmd = "ap " + GetProfileString(profile);
            return Send(cmd) != "err";
        }

        public bool DetachProfile(Profile profile)
        {
            var cmd = "dp " + GetProfileString(profile);
            return Send(cmd) != "err";
        }

        private string GetProfileString(Profile profile)
        {
            return JsonConvert.SerializeObject(profile.Devices);
        }

        public List<UsbDevice> GetUsbDevices()
        {
            var resp = Send("getusb");
            var devices = JsonConvert.DeserializeObject<List<UsbDevice>>(resp);
            return devices;
        }

        private string Send(string data)
        {
            if (!Connect())
                return null;

            var dataBytes = Encoding.ASCII.GetBytes(data);
            var stream = TcpClient.GetStream();
            stream.Write(dataBytes, 0, dataBytes.Length);
            stream.Flush();

            var respBytes = new byte[4096];
            var bytesRead = stream.Read(respBytes, 0, respBytes.Length);

            stream.Close();

            return Encoding.ASCII.GetString(respBytes, 0, bytesRead);
        }

        private bool Connect()
        {
            if (TcpClient != null)
            {
                if (TcpClient.Connected)
                    return true;

                TcpClient.Close();
            }

            try
            {
                TcpClient = new TcpClient(_ip, _port);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
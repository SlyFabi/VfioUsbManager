using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using Libvirt;
using Newtonsoft.Json;

namespace VfioUsbServer
{
    public class PacketHandler
    {
        private NetworkStream Client { get; }

        private string _vmName;

        public PacketHandler(NetworkStream client, string vmName)
        {
            Client = client;
            _vmName = vmName;
        }
        
        public void Handle(byte[] data)
        {
            try
            {
                var dataStr = Encoding.ASCII.GetString(data);
                if (dataStr == "getusb")
                {
                    HandleGetUsbDevices();
                }
                else if (dataStr.StartsWith("ap "))
                {
                    HandleProfileEnable(dataStr, true);
                }
                else if (dataStr.StartsWith("dp "))
                {
                    HandleProfileEnable(dataStr, false);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error processing request: " + e);
                SendResponse("err");
            }
        }

        private void HandleProfileEnable(string dataStr, bool enable)
        {
            dataStr = dataStr.Substring(3);
            var devices = JsonConvert.DeserializeObject<List<UsbDevice>>(dataStr);
            var qemuHandle = Connect.Open("qemu:///system");
            var vmHandle = Domain.LookupByName(qemuHandle, _vmName);

            foreach (var device in devices)
            {
                if (enable)
                    Domain.AttachDevice(vmHandle, GenerateUsbXml(device.vendorId, device.deviceId));
                else
                    Domain.DetachDevice(vmHandle, GenerateUsbXml(device.vendorId, device.deviceId));
            }

            Connect.Close(qemuHandle);
            
            SendResponse("ok");
        }

        private void HandleGetUsbDevices()
        {
            var proc = new Process 
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "lsusb",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();

            var devices = new List<UsbDevice>();
            while (!proc.StandardOutput.EndOfStream)
            {
                var line = proc.StandardOutput.ReadLine();
                if(line == null)
                    continue;
                
                var lineTmp = line.Substring(line.IndexOf("ID ", StringComparison.Ordinal) + 3);
                var splitTmp = lineTmp.Split(new[] {' '}, 2);
                var ids = splitTmp[0].Split(':');
                
                var device = new UsbDevice();
                device.name = splitTmp[1];
                device.vendorId = int.Parse(ids[0], System.Globalization.NumberStyles.HexNumber);
                device.deviceId = int.Parse(ids[1], System.Globalization.NumberStyles.HexNumber);
                devices.Add(device);
            }

            var jsonData = JsonConvert.SerializeObject(devices);
            SendResponse(jsonData);
        }

        private void SendResponse(string msg)
        {
            try
            {
                var data = Encoding.ASCII.GetBytes(msg);
                Client.Write(data, 0, data.Length);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Could not send response!");
            }
        }
        
        private string GenerateUsbXml(int vendorId, int productId)
        {
            return @"<hostdev mode='subsystem' type='usb' managed='no'>
                <source>
                <vendor id='" + vendorId + @"'/>
                <product id='" + productId + @"'/>
                </source>
                </hostdev>";
        }
    }
}
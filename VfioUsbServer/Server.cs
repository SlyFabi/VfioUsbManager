using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace VfioUsbServer
{
    public class Server
    {
        private TcpListener TcpServer { get; }

        private Thread _acceptThread;
        private bool _isRunning;

        private string _vmName;

        public Server(string vmName)
        {
            TcpServer = new TcpListener(IPAddress.Any, 20235);
            _vmName = vmName;
        }

        public void Start()
        {
            _isRunning = true;
            TcpServer.Start();
            _acceptThread = new Thread(AcceptThread);
            _acceptThread.Start();
        }

        public void Stop()
        {
            _isRunning = false;
            _acceptThread.Join();
            TcpServer.Stop();
        }

        private void AcceptThread()
        {
            while (_isRunning)
            {
                var client = TcpServer.AcceptTcpClient();
                var stream = client.GetStream();
                var packetHandler = new PacketHandler(stream, _vmName);
                try
                {
                    while (client.Connected && _isRunning)
                    {
                        var data = new byte[4096];
                        var bytesRead = stream.Read(data, 0, data.Length);
                        Array.Resize(ref data, bytesRead);
                        packetHandler.Handle(data);
                        client.Close();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Client {0} disconnected.", client);
                }
            }
        }
    }
}
using System;
using Libvirt;

namespace VfioUsbServer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Please specify an VM Name. VifoUsbServer.exe [VM Name]");
                Environment.Exit(1);
            }

            if (!VMExists(args[0]))
            {
                Console.WriteLine("VM with name " + args[0] + " does not exist.");
                Environment.Exit(1);
            }
            
            var server = new Server(args[0]);
            server.Start();

            Console.WriteLine("Server started.");
        }

        private static bool VMExists(string vmName)
        {
            try
            {
                var qemuHandle = Connect.Open("qemu:///system");
                Domain.LookupByName(qemuHandle, vmName);
                Connect.Close(qemuHandle);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
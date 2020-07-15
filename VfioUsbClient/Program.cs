using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VfioUsbClient
{
    static class Program
    {
        private static readonly string INSTANCE_MUTEX = "Global\\VfioUsbManager";

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, INSTANCE_MUTEX))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("An instance is already running !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
        }
    }
}

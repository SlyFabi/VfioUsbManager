using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VfioUsbClient
{
    public partial class InputBox : Form
    {
        public string Input { get; private set; }

        public InputBox(string title)
        {
            InitializeComponent();
            Name = title;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Input = tbInput.Text;
            Close();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            Input = null;
            Close();
        }
    }
}

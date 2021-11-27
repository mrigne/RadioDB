using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRadioDB
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Base64 encoded email (for security to avoid spam when published to GitHub - can be replased to String when personally built)
            var encodedEmail = "bmVyb3p5YS5pZ29yQGdtYWlsLmNvbQ==";
            System.Diagnostics.Process.Start(new ProcessStartInfo($"mailto: {Helpers.Base64Helper.Base64Decode(encodedEmail)}") { UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

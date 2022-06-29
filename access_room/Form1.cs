using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace access_room
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Google_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void btn_Yahoo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.yahoo.jp");
        }

        private void btn_YouTube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com");
        }

        private void btn_Twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitter.com");
        }

        private void btn_Amazon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://amazon.co.jp");
        }

        private void btn_Map_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.co.jp/maps");
        }
    }
}

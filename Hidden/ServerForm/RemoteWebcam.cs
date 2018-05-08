using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerForm
{
    public partial class RemoteWebcam : Form
    {
        public bool expand_WC = false;
        
        public Bitmap webcam;
        public RemoteWebcam()
        {
            InitializeComponent();
        }

        private void RemoteWebcam_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = webcam;
        }

        private void RemoteWebcam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
            expand_WC = false;
        }
    }
}

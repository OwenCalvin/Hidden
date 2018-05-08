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
    public partial class RemoteDesktop : Form
    {
        public int X;
        public int Y;
        public int width;
        public int height;
        public bool expand_RD = false;
        public RemoteDesktop()
        {
            InitializeComponent();
        }
        public Image screen;
        private void RemoteDesktop_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image = screen;
        }

        private void RemoteDesktop_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void RemoteDesktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
            expand_RD = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //sendMouseClick(e.X, e.Y,pictureBox1.Width,pictureBox1.Height);
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //sendDoubleMouseClick(e.X, e.Y, pictureBox1.Width, pictureBox1.Height);
        }
    }
}

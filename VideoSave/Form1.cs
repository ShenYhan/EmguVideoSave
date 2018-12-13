using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

namespace VideoSave
{
    public partial class Form1 : Form
    {
        Capture capture_Iron;
        private Mat frame_Iron;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capture_Iron = new Capture("11.avi"); //打开视频、摄像头 
            capture_Iron.ImageGrabbed += Process_Iron;
            capture_Iron.Start();
        }
        private void Process_Iron(object sender, EventArgs e)
        {
            capture_Iron.Retrieve(frame_Iron, 0);
            System.Threading.Thread.Sleep((int)(800.0 / 10 - 5));
            imageBox1.Image = frame_Iron;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rectangle rect = new Rectangle(300, 300, 0, 0);
        Bitmap bmp = new Bitmap(@"timg.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            rect.Width += bmp.Width / 100;
            rect.Height += bmp.Height / 100;
            if (rect.Width > bmp.Width)
                timer1.Enabled = false;
            else
                g.DrawImage(bmp, rect);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

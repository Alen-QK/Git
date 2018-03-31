using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height = pictureBox1.Image.Height;
            int width = pictureBox1.Image.Width;
            Bitmap newbitmap = new Bitmap(width, height);
            Bitmap oldbitmap = (Bitmap)pictureBox1.Image;
            Color pixel;
            for (int x = 1; x < width; x++)
            {
                for (int y = 1; y < height; y++)
                {
                    int r, g, b;
                    pixel = oldbitmap.GetPixel(x, y);
                    r = 255 - pixel.R;
                    g = 255 - pixel.G;
                    b = 255 - pixel.B;
                    newbitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.Image = newbitmap;
        }
    }
}

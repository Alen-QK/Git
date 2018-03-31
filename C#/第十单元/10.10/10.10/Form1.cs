using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = System.DateTime.Now;
            Graphics g = Graphics.FromImage(bmp);
            for (int w = 0; w < bmp.Width; w++)
            {
                for (int h = 0; h < bmp.Height; h++) 
                {
                    Color color = bmp.GetPixel(w, h);
                    byte gray = (byte)((color.R * 229 + color.G * 587 + color.B * 114) / 1000);
                    bmp.SetPixel(w, h, Color.FromArgb(gray, gray, gray));
                }
            }
            g.DrawImage(bmp, 0, 0);
            pictureBox1.Image = bmp;
            g.Dispose();
            DateTime dt2 = System.DateTime.Now;
            TimeSpan ts1 = dt2.Subtract(dt1);
            MessageBox.Show("运行时间为" + ts1, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.ImageLocation);
        }
    }
}

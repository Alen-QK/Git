using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] lines = textBox1.Text.Split(new string[] { "\r\n" },StringSplitOptions.None);
            string[] province = new string[lines.Length];
            float[] student = new float[lines.Length];
            float a = 0;
            float b = 0;
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle rect = new Rectangle(50, 10, 180, 180);
            Rectangle r = new Rectangle(10, 20, 10, 10);
            Point p = new Point(20, 20);
            float start = 0;
            Random rnd = new Random();
            SolidBrush brush2 = new SolidBrush(Color.Black);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lines1 = lines[i].Split(new string[] { " " }, StringSplitOptions.None);
                student[i] = float.Parse(lines1[1]);
                province[i] = lines1[0];
                a += student[i];        
            }
            b = 360 / a;
            for (int i = 0; i < lines.Length; i++)
            {
                Color cc = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                SolidBrush brush1 = new SolidBrush(cc);
                float sweep = student[i] * b;
                g.FillPie(brush1, rect, start, sweep);
                g.FillRectangle(brush1, r);
                g.DrawString(province[i], this.Font, brush2, p);
                start += sweep;
                r.Y += 15;
                p.Y += 15;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

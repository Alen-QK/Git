using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int i = 9;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "朱以晨";
            int x = (this.Width - label1.Width) / 2;
            int y = (this.Height-SystemInformation.CaptionHeight - label1.Height) / 2;
            Point mypoint = new Point(x, y);
            label1.Location = mypoint;
            timer1.Interval = 100;
            timer1.Start();
            timer2.Interval = 100;
            timer2.Stop();
            this.KeyPreview = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Font = new Font("",i);
            i++;
            int x = (this.Width - label1.Width) / 2;
            int y = (this.Height - SystemInformation.CaptionHeight - label1.Height) / 2;
            Point mypoint = new Point(x, y);
            label1.Location = mypoint;
            if (label1.Width > this.Width)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Font = new Font("", i);
            i--;
            int x = (this.Width - label1.Width) / 2;
            int y = (this.Height - SystemInformation.CaptionHeight - label1.Height) / 2;
            Point mypoint = new Point(x, y);
            label1.Location = mypoint;
            if (label1.Width <= ((this.Width) / 10))
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}

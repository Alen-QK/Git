using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] txt = { "欢", "迎", "使", "用", "我", "设", "计", "的", "小", "程", "序" };
        public int a = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer2.Interval = 1000;
            timer1.Start();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           toolStripStatusLabel1.Text += txt[a];
           a++;
           if (a == 11)
           {
               timer1.Stop();
               timer2.Start();
           }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a = 0;
            toolStripStatusLabel1.Text = "";
            timer1.Start();
            timer2.Stop();
        }
    }
}

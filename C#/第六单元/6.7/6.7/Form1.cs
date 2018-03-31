using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] a = new int[1000000];
            Random r = new Random();
            for (int i = 0; i < 1000000; i++)
            {
                a[i] = r.Next(1000, 10000);
            }
            DateTime d1 = System.DateTime.Now;
            Array.Sort(a);
            DateTime d2 = System.DateTime.Now;
            TimeSpan ts1 = d2.Subtract(d1);
            label1.Text = "程序的开始时间是:" + d1.ToString() + "," + "程序的结束时间是:" + d2.ToString() + "," + "运行时间为:" + ts1.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

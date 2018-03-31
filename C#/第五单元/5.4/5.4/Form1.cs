using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5._4
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(2009, 2, 18, 0, 0, 0);
            DateTime dt2 = Convert.ToDateTime(textBox1.Text);
            TimeSpan ts1 = dt2.Subtract(dt1);
            int days = ts1.Days;
            int weeks = days / 7;
            label2.Text = "当前日期是" + "第" + weeks.ToString() + "周";
        }
    }
}

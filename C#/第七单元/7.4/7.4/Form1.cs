using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7._4
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] a = new double[7];
            a[0] = double.Parse(textBox1.Text);
            a[1] = double.Parse(textBox2.Text);
            a[2] = double.Parse(textBox3.Text);
            a[3] = double.Parse(textBox4.Text);
            a[4] = double.Parse(textBox5.Text);
            a[5] = double.Parse(textBox6.Text);
            a[6] = double.Parse(textBox7.Text);
            double max, min, sum = 0;
            max = min = a[0];
            for (int i = 0; i < 7; i++)
            {
                sum = sum + a[i];
                if (max < a[i])
                {
                    max = a[i];
                }
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            sum = sum - (max + min);
            label1.Text = "运动员得分：" + (sum / 5).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4._1
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
            int a, b, x, y, c, k;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            x = a;
            y = b;
            while (a % b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            k = (x * y) / b;
            label1.Text="最大公约数为"+b+"，"+"最小公倍数为"+k;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4._3
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
            Rectangle rectangle1 = new Rectangle();
            rectangle1.length = double.Parse(textBox1.Text);
            rectangle1.width = double.Parse(textBox2.Text);
            label3.Text = "矩形的面积是：" + rectangle1.s(rectangle1.length,rectangle1.width);
            label4.Text = "矩形的周长是：" + rectangle1.l(rectangle1.length,rectangle1.width);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4._5
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation ope1 = new Operation();
            ope1.a = double.Parse(textBox1.Text);
            ope1.b = double.Parse(textBox2.Text);
            if (comboBox1.Text == "加法")
            {
                label3.Text = "相加结果为：" + ope1.plus(ope1.a, ope1.b);
            }
            else if (comboBox1.Text == "减法")
            {
                label3.Text = "相减结果为：" + ope1.sub(ope1.a, ope1.b);
            }
            else if (comboBox1.Text == "乘法")
            {
                label3.Text = "相乘结果为：" + ope1.mul(ope1.a, ope1.b);
            }
            else if (comboBox1.Text == "除法")
            {
                label3.Text = "相除结果为：" + ope1.div(ope1.a, ope1.b);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

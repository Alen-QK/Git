using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a = 0;
        int count = 1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            if (x > a)
            {
                label2.Text = "猜得大了";
                label3.Text = "第"+count.ToString() + "次";
                ++count ;
                if (count == 20)
                {
                    MessageBox.Show("猜到第20次了！失败了hhh", "失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                }
            }
            if (x < a)
            {
                label2.Text = "猜得小了";
                label3.Text = "第" + count.ToString() + "次";
                ++count ;
                if (count == 20)
                {
                    MessageBox.Show("猜到第20次了！失败了hhh", "失败！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                }
            }
            if (x == a)
            {
                label2.Text = "猜对了";
                label3.Text = "第" + count.ToString() + "次";
                label4.Text = "第" + count.ToString() + "次猜对";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = rnd.Next(1, 101);
            //label2.Text = a.ToString();
        }
    }
}

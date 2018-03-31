using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4._2
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i,n;
            label2.Text = "计算结果：\n";
            n=int.Parse(textBox1.Text);
            for (i=1; i <= n; i++)
            {
                label2.Text += fib(i) + "\n";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int fib(int num)
        {
            if (num>=0&&num<=1)
            {
                return 1;
            }
            else 
            {
                return num = fib(num - 1) + fib(num - 2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

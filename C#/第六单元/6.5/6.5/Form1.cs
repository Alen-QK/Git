using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6._5
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[26];
            string s = textBox1.Text.ToUpper();
            for (int i = 0; i < s.Length; i++)
            {
                int s1 = char.Parse(s.Substring(i, 1)) - 'A';
                if (s1 >= 0 && s1 <= 25)
                {
                    a[s1]++;
                }
            }
            int max = a[0];
            int p = 0;
            for (int i = 0; i < 25; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    p = i;
                }
            }
            char c = Convert.ToChar('A' + p);
            label1.Text = "出现次数最多的字母是" + c + " " + "总共出现了" + max + "次";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

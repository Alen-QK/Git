using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5._2
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
            string key = textBox1.Text;
            //string[] buffer = key;
            int a = key.Length, a0, a1=0, a2=0, a3=0, a4=0, a5=0, a6=0, a7=0, a8=0, a9=0;
            a0 = (key.Length - key.Replace("0", "").Length) / "0".Length;
            a1 = (key.Length - key.Replace("1", "").Length) / "1".Length;
            a2 = (key.Length - key.Replace("2", "").Length) / "2".Length;
            a3 = (key.Length - key.Replace("3", "").Length) / "3".Length;
            a4 = (key.Length - key.Replace("4", "").Length) / "4".Length;
            a5 = (key.Length - key.Replace("5", "").Length) / "5".Length;
            a6 = (key.Length - key.Replace("6", "").Length) / "6".Length;
            a7 = (key.Length - key.Replace("7", "").Length) / "7".Length;
            a8 = (key.Length - key.Replace("8", "").Length) / "8".Length;
            a9 = (key.Length - key.Replace("9", "").Length) / "9".Length;
            label2.Text = "0 1 2 3 4 5 6 7 8 9";
            label3.Text = a0.ToString() + " " + a1.ToString() + " " + a2.ToString() + " " + a3.ToString() + " " + a4.ToString() + " " + a5.ToString() + " " + a6.ToString() + " " + a7.ToString() + " " + a8.ToString() + " " + a9.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

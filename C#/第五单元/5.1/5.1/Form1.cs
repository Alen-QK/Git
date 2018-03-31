using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] hashtable = new int[99];
            int[] output = new int[99];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int num = r.Next(50, 99);
                while (hashtable[num] > 0)
                {
                    num = r.Next(50, 99);
                }
                output[i] = num;
                hashtable[num] = 1;
                label1.Text += output[i] + " ";
            }
        }
    }
}

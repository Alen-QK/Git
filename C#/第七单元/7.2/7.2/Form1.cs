using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.MultiColumn = true;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }
    }
}

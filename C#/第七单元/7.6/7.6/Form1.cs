using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7._6
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;
            if (listBox1.SelectedItem == null)
                return;
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                return;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
            for (int j = 0; j < listBox2.Items.Count; j++)
            {
                listBox1.Items.Remove(listBox2.Items[j]);
            }
            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
                return;
            if (listBox2.SelectedItem == null)
                return;
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
                return;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox1.Items.Add(listBox2.Items[i]);
            }
            for (int j = 0; j < listBox1.Items.Count; j++)
            {
                listBox2.Items.Remove(listBox1.Items[j]);
            }
            listBox1.Sorted = true;
            listBox2.Sorted = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.Sorted = true;
            //listBox2.Sorted = true;
        }
    }
}

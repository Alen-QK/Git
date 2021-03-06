﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace q5
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
            DateTime dt1 = Convert.ToDateTime(textBox1.Text);
            DateTime dt2 = Convert.ToDateTime(textBox2.Text);
            int span = int.Parse(textBox3.Text);
            DateTime dt3 = new DateTime();
            TimeSpan ts1 = dt2.Subtract(dt1);
            int sign = 0;
            if ((ts1.Minutes + ts1.Hours * 60) % span != 0)
            {
                MessageBox.Show("时间跨度不是"+span.ToString()+"的倍数，最后一个小组时间不足！", "时间跨度有误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sign = 1;
            }
            if (dt1 == dt2)
            {
                MessageBox.Show("起始与结束时间不能相同！", "输入时间有误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sign = 1;
            }
            while (dt3 != dt2 && sign == 0)
            {
                dt3 = dt1.AddMinutes(span);
                listBox1.Items.Add(dt1.ToString("hh:mm") + "-" + dt3.ToString("hh:mm") + "\n");
                dt1 = dt3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

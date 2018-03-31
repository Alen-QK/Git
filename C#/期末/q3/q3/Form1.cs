﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(textBox1.Text);
            GregorianCalendar haha = new GregorianCalendar();
            int weekofyear = haha.GetWeekOfYear(dt1, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            label1.Text = "这一天是这一年的第" + dt1.DayOfYear.ToString() + "天";
            label2.Text = "这一天所在周属于该年的第" + weekofyear.ToString() + "周";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

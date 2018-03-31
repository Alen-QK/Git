using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5._3
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(textBox1.Text);
            DateTime dt2 = Convert.ToDateTime(textBox2.Text);
            TimeSpan ts1 = dt2.Subtract(dt1);
            int days = ts1.Days+1;
            int weekday = 0;
            for (int i = 0; i <days; i++)
            {
                DateTime tem = dt1.Date.AddDays(i);
                if (tem.DayOfWeek != System.DayOfWeek.Saturday && tem.DayOfWeek != System.DayOfWeek.Sunday)
                {
                    weekday++;
                }
            }
            label3.Text = "从" + dt1 + "到" + dt2 + "之间的工作日共有" + weekday.ToString() + "天";
        }
    }
}

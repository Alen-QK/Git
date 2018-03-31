using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4._6
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.sname = "赵六";
            student1.snumber = 14396;
            student1.cscore = int.Parse(textBox3.Text);
            student1.mscore = int.Parse(textBox4.Text);
            student1.escore = int.Parse(textBox5.Text);
            label6.Text = "学生姓名：" + student1.sname + "," + "学号：" + student1.snumber + "," + "语文成绩：" + student1.cscore + "," + "数学成绩：" + student1.mscore + "," + "英语成绩：" + student1.escore;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

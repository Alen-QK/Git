using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EWai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult myresult = openFileDialog1.ShowDialog();//打开对话框
            if (myresult == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default);//创建字节流
                richTextBox1.Text = sr.ReadToEnd();//以字节流形式将文本文件读入富文本框
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件|*.txt";//设置文件过滤
            toolStripStatusLabel1.Text = "学号：1513490426 姓名：齐堃";//制作者信息
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 统计字数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int chnnum = 0;//初始化中文字符数
            int engnum = 0;//初始化英文字符数
            int nbrnum = 0;//初始化阿拉伯数字数
            int bionum = 0;//初始化其他字符数
            int linnum = 1;//初始化文本行数
            foreach (char ch in richTextBox1.Text)
            {
                if (ch >= 0x4e00 && ch <= 0x9fbb)//如果为中文字符，相应计数器递增
                    chnnum++;
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))//如果为英文字符，相应计数器递增
                    engnum++;
                if (ch >= '0' && ch <= '9')//如果为数字，相应计数器递增
                    nbrnum++;
                if ("`~!@#$%^&*()_+-={}[]:\";'<>,.?/\\| ".IndexOf(ch) != -1)//如果为其他字符，相应计数器递增
                    bionum++;
                if (ch == '\n')//如果有换行标识，相应计数器递增
                    linnum++;
            }
            MessageBox.Show(string.Format("中文字数为：{0}\n英文字数为：{1}\n数字字数为：{2}\n其他字符数为：{3}\n行数为：{4}\n", chnnum, engnum, nbrnum, bionum, linnum), "统计字数", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//在消息框显示结果
        }

        private void 结束运行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//关闭程序
        }
    }
}

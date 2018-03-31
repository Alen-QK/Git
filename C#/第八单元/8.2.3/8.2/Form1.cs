using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int count = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "文本文件|*.txt|富文本文件|*.RichText";
        }

        private void 结束程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 打开文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult myresult=openFileDialog1.ShowDialog();
            if(myresult==DialogResult.OK)
            {
                for(int i=0;i<openFileDialog1.FileNames.Length;i++)
                {
                    richTextBox1.Text+="第"+count+++"个文件:\n"+System.IO.File.ReadAllText(openFileDialog1.FileNames[i],Encoding.Default)+"\n";
                    toolStripStatusLabel1.Text = openFileDialog1.FileNames[i];
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

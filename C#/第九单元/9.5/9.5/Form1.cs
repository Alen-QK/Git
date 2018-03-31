using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "bmp图片文件|*.bmp";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                //Bitmap bmp = new Bitmap(@openFileDialog1.FileName);
                FileStream fs = new FileStream(@openFileDialog1.FileName, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                byte[] bmpfile = br.ReadBytes((int)fs.Length);
                fs.Close();
                string result = string.Empty;
                for (int i = 0; i < bmpfile.Length; i++)
                {
                    result += " "+Convert.ToString(bmpfile[i], 16);
                }
                richTextBox1.Text = result;
                
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

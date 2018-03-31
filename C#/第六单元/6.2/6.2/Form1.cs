using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int m = r.Next(0, 10);
            int n = r.Next(0, 10);
            int i,j;
            int[,] arr = new int[m, n];
            int[,] brr = new int[n, m];
            for ( i = 0; i < m; i++)
            {
                for ( j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(10, 100);
                    brr[j, m-i-1] = arr[i, j];
                    label1.Text += arr[i, j] + " ";
                }
                label1.Text += "\n";
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    label2.Text += brr[i, j] + " ";
                }
                label2.Text += "\n";
            }
        }
    }
}

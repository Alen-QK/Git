using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics gMouse;
        Point ptStart, ptMove, p1, p2;
        Pen pen1 = new Pen(Color.Black);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            gMouse = pictureBox1.CreateGraphics();
            ptStart.X = e.X;
            ptStart.Y = e.Y;
            p1.X = e.X;
            p1.Y = e.Y;
            pictureBox1.Cursor = Cursors.Cross;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ptMove.X = e.X;
                ptMove.Y = e.Y;
                gMouse.DrawLine(pen1, ptStart, ptMove);
                ptStart = ptMove;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
            p2.X = e.X;
            p2.Y = e.Y;
            gMouse.DrawLine(pen1, p1, p2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

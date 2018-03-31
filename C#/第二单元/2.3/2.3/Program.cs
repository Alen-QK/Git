using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, s, pi;
            pi = 3.1425926;
            Console.WriteLine("请输入圆的半径:");
            r=double.Parse(Console.ReadLine());
            s = 2 * pi * r * r;
            Console.WriteLine("该圆的半径为{0}", s);
            Console.ReadLine();
        }
    }
}

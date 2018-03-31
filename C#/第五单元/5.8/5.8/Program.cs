using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = dt1.AddMonths(1 - dt1.Month).AddDays(1 - dt1.Day);
            DateTime dt3 = dt2.AddMonths(12).AddDays(-1);
            Console.Write("本年年初为{0},本年年末为{1}", dt2, dt3);
            Console.ReadLine();
        }
    }
}

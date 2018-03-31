using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = dt1.AddMonths(0 - (dt1.Month - 1) % 3).AddDays(1 - dt1.Day);
            DateTime dt3 = dt2.AddMonths(3).AddDays(-1);
            Console.Write("本季初是{0},本季末是{1}", dt2, dt3);
            Console.ReadLine();
        }
    }
}

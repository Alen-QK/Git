using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = dt1.AddDays(1-Convert.ToInt32(dt1.DayOfWeek.ToString("d")));
            DateTime dt3 = dt2.AddDays(6);
            Console.Write("本周一为{0},本周日为{1}", dt2, dt3);
            Console.ReadLine();
        }
    }
}

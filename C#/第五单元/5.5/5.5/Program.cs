using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = dt1.AddYears(1);
            string dt3 = dt2.DayOfWeek.ToString();
            Console.Write("明年的今天是{0}", dt3);
            Console.ReadLine();
        }
    }
}

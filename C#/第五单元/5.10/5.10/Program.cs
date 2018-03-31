using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Today;
            DateTime dt2 = dt1.AddDays(1 - dt1.Day);
            DateTime dt3 = dt2.AddMonths(1).AddDays(-1);
            TimeSpan ts1 = dt3.Subtract(dt2);
            int days = ts1.Days+1;
            int weekday = 0;
            for (int i = 0; i < days; i++)
            {
                DateTime tem = dt2.Date.AddDays(i);
                if (tem.DayOfWeek != System.DayOfWeek.Saturday && tem.DayOfWeek != System.DayOfWeek.Sunday)
                {
                    weekday++;
                }
            }
            Console.Write("本月工作日共有{0}天",weekday);
            Console.ReadLine();
        }
    }
}

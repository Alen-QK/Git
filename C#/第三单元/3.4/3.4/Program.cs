using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double e, n, i;
            e = 1;
            n = 1;
            for (i = 1; 1.0 / n > Math.Pow(10, -6); i++)
            {
                n *= i;
                e = e + 1.0 / n;
            }
            Console.WriteLine("e={0}", e);
            Console.ReadLine();
        }
    }
}

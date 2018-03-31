using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b, c;
            for (x = 100; x <= 999; x++)
            {
                a = x / 100;
                b = x % 100 / 10;
                c = x % 10;
                if ((a * a * a) + (b * b * b) + (c * c * c) == x)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}

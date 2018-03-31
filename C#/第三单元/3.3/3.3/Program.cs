using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,s,t,pi;
            t = 1; pi = 0; n = 1.0; s = 1;
            while (Math.Abs(t) > Math.Pow(10, -6))
            {
                pi = pi + t;
                n = n + 2;
                s = -s;
                t = s/n;
            }
            pi = pi * 4;
            Console.WriteLine("pi={0}", pi);
            Console.ReadLine();
        }
    }
}

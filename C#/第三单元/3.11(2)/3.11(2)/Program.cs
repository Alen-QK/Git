using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._11_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 100; i <= 200; i++)
            {
                if (i % 3 != 0)
                {
                    Console.Write("{0}\n", i);
                }
            }
            Console.ReadLine();
        }
    }
}

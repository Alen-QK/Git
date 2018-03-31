using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._11_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=300, count=0;
            while (count<=99)
            {
                if ((i % 3 == 0) && (i % 5) == 0)
                {
                    Console.Write("{0} ", i);
                    count += 1;
                }
                i = i + 1;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._11_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum=0;
            for (i = 101; i <= 500; i += 2)
            {
                Console.Write("{0}\n",i);
                sum = sum + i;
            }
            Console.Write("100~500的基数总和为{0}",sum);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._11_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,count=0;
            for (i = 1000; i >= 0; i--)
            {
                for (j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                if (j >= i)
                    {
                        Console.Write("{0} ", i);
                        count += 1;
                    }
                if (count == 10)
                    {
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}

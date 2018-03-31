using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,i,j,k;
            a = int.Parse(Console.ReadLine());
            for (i = ((a+1)/2); i >= 1; i--)
            {
                for (j = 1; j <= ((a + 1) / 2 - i); j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}

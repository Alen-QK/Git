using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0;
            for (i = 2; i <= 1000; i++)
            {
                sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    } 
                }
                if (sum == i)
                    {
                        Console.WriteLine(i);
                    }
            }
            Console.ReadLine();
        }
    }
}

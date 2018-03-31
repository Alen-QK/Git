using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            for (a = 0; a <= 30; a++)
            {
                for (b = 0; b <= 30; b++)
                {
                    for (c = 0; c <= 30; c++)
                    {
                        if ((a * 3 + b * 2 + c * 1 == 50) && (a + b + c == 30))
                        { 
                        Console.WriteLine("男人有{0}个，女人有{1}个，孩子有{2}个",a,b,c);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            char[] a = num.ToCharArray();
            int x = a.Length;
            char[] b = new char[x];
            Array.Copy(a, 0, b, 0, x);
            Array.Reverse(a);
            int y = 0;
            for (int i = 0; i < x; i++)
            {
                if (a[i] != b[i])
                {
                    y = 1;
                    break;
                }
            }
            if (y == 0)
            {
                Console.Write("这是回文数");
            }
            if (y == 1)
            {
                Console.Write("这不是回文数");
            }
            Console.ReadLine();
        }
    }
}

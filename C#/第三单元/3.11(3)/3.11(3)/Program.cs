using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._11_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, count=0;
            for (i = 1; i <= 1000; i++)
            {
                if ((i % 5 == 0) && (i % 7 == 0))
                {
                    count = count + 1;
                }
            }
            Console.Write("满足条件的数有{0}个", count);
            Console.ReadLine();
        }
    }
}

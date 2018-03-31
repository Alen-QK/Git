using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, a=1;
            while (i < 10)
            {
                a = (a + 1) * 2;
                i++;
            }
            Console.Write("第一天共摘了{0}个桃子", a);
            Console.ReadLine();
        }
    }
}

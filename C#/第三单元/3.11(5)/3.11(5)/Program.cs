using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._11_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n, sum=0;
            Console.Write("请输入n的值：");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                k = 1;
                for (j = 1; j <= i; j++)
                {
                    k *= j;
                }
                sum =sum+k;
            }
            Console.Write("结果为{0}", sum);
            Console.ReadLine();
        }
    }
}

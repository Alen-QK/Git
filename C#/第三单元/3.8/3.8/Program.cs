using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double max,min,sum=0;
            int i;
            double[] a=new double[7];
           
            Console.Write("请输入7个分数\n");
            for (i = 0; i < 7; i++)
            {
              a[i] = double.Parse(Console.ReadLine());  
            }
            max = min = a[0];
            for (i = 0; i < 7; i++)
            {
                sum = sum + a[i];
                if (max <= a[i])
                {
                    max = a[i];
                }
                if (min >= a[i])
                {
                    min = a[i];
                }
            }
            sum = sum - (max + min);
            Console.WriteLine("最高分{0},最低分{1}", max, min);
            Console.WriteLine("选手平均成绩为{0}", sum/5 );
            Console.ReadLine();
        }
    }
}

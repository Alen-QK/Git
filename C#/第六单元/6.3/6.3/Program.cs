using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int max = 0;
            int p=0;
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = r.Next(10, 100);
                Console.Write("{0}  ",arr[i]);
            }
            max = arr[0];
            for (int i = 0; i < 10; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    p=i;
                }
            }
            Console.Write("最大值为{0},位于数组的{1}个单元的位置", max, p+1);
            Console.ReadLine();
        }
    }
}

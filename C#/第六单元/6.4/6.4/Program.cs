using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int[] brr = new int[20];
            int sum = 0, min = 0, p=0;
            double a;
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                arr[i] = r.Next(10, 99);
                sum = sum + arr[i];
                Console.Write("{0} ", arr[i]);
            }
            a = sum / 20;
            Console.WriteLine("数组平均值为{0}", a);
            for (int i = 0; i < 20; i++)
            {
                brr[i] = System.Math.Abs((int)a-arr[i]);
                //Console.Write("{0} ", brr[i]);
            }
            min = brr[0];
            for (int i = 0; i < 20; i++)
            {
                if (min > brr[i])
                {
                    min = brr[i];
                    p = i;
                }
            }
            Console.WriteLine("最接近平均值的数为{0}", arr[p]);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 9; i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    for (k = 0; k <= 9; k++)
                    {
                        if (i!=j&&i!=k&&j!=k&&i*100+j*10+k+i+j*10+k*100==1333)
                        {
                            Console.Write("a={0},b={1},c={2}\n", i, j, k);
                        }
                     }
                }
            }
            Console.ReadLine();
        }
    }
}

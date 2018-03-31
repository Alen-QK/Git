using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._4
{
    class Ball
    {
        public double r;
        public double pi=3.14;
        public double x = 4.0 / 3.0 ;
        public double s(double a)
        {
            return 4 * pi * a * a;
        }
        public double v(double b)
        {
            return x * pi * b * b * b;
        }
    }
}

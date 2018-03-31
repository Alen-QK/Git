using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._7
{
    class Max
    {
        public long a;
        public long b;
        public long choose(long x, long y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}

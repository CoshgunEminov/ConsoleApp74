using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
     public static class Factorial
    {
        public static int factorial(this int x)
        {
            if (x <= 1) return 1;
            if (x == 2) return 2;
            else
                return x * factorial(x - 1);
        }
    }

}


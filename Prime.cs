using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    public static class Prime
    {
        public static bool isprime(this int number, int v)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 1) ;
                return false;
            }
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class WithoutUsingRecursion
    {
        public double  Factorial (int num)
        {
            int i = 1;
            long res = 0;
            while (i <= num)
            {
                if (i == 1)
                    res = 1;
                res *= i;
                i++;
            }

            Console.WriteLine(res);
            return res;
        }

    }
}

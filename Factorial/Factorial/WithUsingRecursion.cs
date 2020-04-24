using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Factorial
{
    class WithUsingRecursion
    {
        public double GetFactorial(int number)
            {
                if (number == 0)
                {
                    return 1;
                }
                else
                {
                    return number * GetFactorial(number - 1);
                }
            }
    }
    
}

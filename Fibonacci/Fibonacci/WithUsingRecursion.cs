using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class WithUsingRecursion
    {
        public int Fibonachi(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                return Fibonachi(number - 1) + Fibonachi(number - 2);
            }
        }
    }
}

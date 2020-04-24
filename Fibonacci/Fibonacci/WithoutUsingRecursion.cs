using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    class WithoutUsingRecursion
    {
        public int Fibonacci(int number)
        {
            int number0 = 0;
            int number1 = 1;
            int tmp;

            for (int i = 0; i < number; i++)
            {
                tmp = number0;
                number0 = number1;
                number1 += tmp;
            }

            Console.WriteLine(number0);
            return number0;
        }
    
    }
}

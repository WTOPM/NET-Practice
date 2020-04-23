using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Second : First
    {
        public void Test()
        {
            Name += " Hello";
            Console.WriteLine(Name);
        }
    }
}

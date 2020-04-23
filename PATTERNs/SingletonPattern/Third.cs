using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Third : First
    {
        public void Test()
        {
            Name += " Hello Hello";
            Console.WriteLine(Name);
        }
    }
}

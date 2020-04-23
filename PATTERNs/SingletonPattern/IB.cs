using System;

namespace SingletonPattern
{
    public interface IB : IA
    {
        new void Test(string b = "Hello B")
        {
            Console.WriteLine(b);
        }


    }
}
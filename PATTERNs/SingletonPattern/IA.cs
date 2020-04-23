using System;

namespace SingletonPattern
{
    public interface IA
    {
        void Test(string a = "Hello A")
        {
            Console.WriteLine(a);
        }
    }
}
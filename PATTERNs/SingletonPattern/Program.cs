using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Initialize();

            Console.WriteLine(s1.GetHashCode());

            Singleton s2 = Singleton.Initialize();// - содержит ссылку на s1

            Console.WriteLine(s2.GetHashCode());

            Console.ReadKey();
        }
    }
}

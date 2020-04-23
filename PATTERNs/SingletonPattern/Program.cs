using System;

namespace SingletonPattern
{
    class Program : IA, IB
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Initialize();

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s1.GetType());


            Singleton s2 = Singleton.Initialize();// - содержит ссылку на s1

            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s2.GetType());


            if (s2.GetType() == typeof(Singleton))
                Console.WriteLine("Это реально класс Singleton");

            Console.WriteLine(s1.ToString());

            First first = new First();
            Second second = new Second();
            Third third = new Third();

          
            second.Test();
            third.Test();



            Console.ReadKey();


            
        }
    }
}

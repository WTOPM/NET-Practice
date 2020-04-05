using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseShip ship = new TransportShip();

            string res = ship.ToString();

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

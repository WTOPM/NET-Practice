using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            TransportShip ship = new TransportShip();

            string res = ship.Move(1000); // Inheritance

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

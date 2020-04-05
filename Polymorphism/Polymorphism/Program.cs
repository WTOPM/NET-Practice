using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseShip ship = GetShip(ShipType.TransportShip);
           

            string result = ship.Fight();
            

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static BaseShip GetShip(ShipType shipType)
        {
            switch (shipType)
            {
                case ShipType.FightShip:
                    return new FightShip();

                case ShipType.TransportShip:
                    return new TransportShip();

                default:
                    throw new Exception("Неизвестный тип корабля");
            }
        }
    }
}

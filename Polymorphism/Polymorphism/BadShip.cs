using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism // Without Polymorphism ((
{
    public enum ShipType
    {
        TransportShip = 1,
        FightShip = 2
    }

    public class BadShip
    {
        public ShipType ShipType { get; set; }

        public string Move(int distance)
        {
        double time = 0;

        if (ShipType == ShipType.TransportShip)
        {
            time = (double) distance / 1000;
        }

        if (ShipType == ShipType.FightShip)
            {
                time = (double)distance / 2000;
            }
        return string.Format("Пройдено километров: {0} за время:", distance, time);
        }

        public string Fight()
        {
            if (ShipType == ShipType.TransportShip)
            {
                return "Транспортный корабль не может вступать в бой";
            }

            if (ShipType == ShipType.FightShip)
            {
                return "Корабль уничтожен";
            }

            return "Неизвестный тип корабля";
        }
    }
}

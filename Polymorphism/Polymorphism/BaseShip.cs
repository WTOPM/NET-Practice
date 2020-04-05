using System;

namespace Polymorphism
{
    public class BaseShip // :System.Object
    {
        protected int _speed;

        public virtual string Move(int distance)
        { 

            string result = string.Format("Пройдено километров: {0}", distance);

            return result;
        }

        public override string ToString()
        {
            return "Базовый класс для всех кораблей";
        }
    }

    public class TransportShip : BaseShip
    {
        public override string Move(int distance)
        {
            string result = base.Move(distance);
            result += string.Format("\r\nТранспортный корабль преодалел километров:", distance);
            return result;
        }

        public override string ToString()
        {
            return "Транспортный корабль";
        }

    }
}

using System;

namespace Polymorphism
{
    public class BaseShip
    {
        public virtual string Move(int distance)
        {
            string result = string.Format("Пройдено километров: {0}", distance);

            return result;
        }

        public virtual string Fight()
        {
            return "Произошел бой";
        }
    }

    public class FightShip : BaseShip
    {
        public override string Move(int distance)
        {
            return string.Format("Пройдено километров: {0} за время:", distance);
        }
        public override string Fight()
        {
            return "Противник уничтожен";
        }
        public override string ToString()
        {
            return "Боевой корабль";
        }
    }
    public class TransportShip : BaseShip
    {
        public override string Move(int distance)
        {
            return string.Format("Пройдено километров: {0} за время:", distance);
        }
        public override string Fight()
        {
            return "Транспортный корабль не может вступать в бой";
        }
        public override string ToString()
        {
            return "Боевой корабль";
        }
    }
}

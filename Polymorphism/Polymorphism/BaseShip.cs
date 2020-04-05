namespace Polymorphism
{
    public class BaseShip // :System.Object
    {
        
        private int _counter;
        protected int _speed;

        public string Move(int distance)
        {
            _counter++;

            string result = string.Format("Пройдено километров: {0}", distance);

            return result;
        }
    }

    public class TransportShip : BaseShip
    {
        public void Start()
        {

        }
    }
}

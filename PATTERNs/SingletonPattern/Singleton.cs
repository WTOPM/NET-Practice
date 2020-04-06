using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton single = null;// - Приватное статическое поле single типа Singleton с присвоенным значением null

        protected Singleton()// - protected конструктор по умолчанию
        {
            
        }

        public static Singleton Initialize()// - Фабричный метод
        {
            if (single == null)// - Содержит ли переменная single в себе ссылку на обьект
                single = new Singleton();// - присваиваем ссылку на новый экземпляр класса Singleton

            return single;
        }
    }
}

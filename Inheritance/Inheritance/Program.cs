using System;

namespace Inheritance
{
    class Person
    {
        string name;
        int age;

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Person(string name)");
        }
        public Person(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("Person(string name, int age)");
        }
    }
    class Employee : Person
    {
        string company;

        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Employee(string name, int age, string company)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee("Tom", 22, "Microsoft");
        }
    }
}
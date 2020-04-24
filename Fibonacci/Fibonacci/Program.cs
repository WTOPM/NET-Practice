using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the number of factorial WITHOUT recursion:");
            var without = new WithoutUsingRecursion();
            without.Fibonacci(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Enter the number of factorial WITH recursion:");
            var with = new WithUsingRecursion();
            Console.WriteLine(with.Fibonachi(int.Parse(Console.ReadLine())));
        }
    }
}

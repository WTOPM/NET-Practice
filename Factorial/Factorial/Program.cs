using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the number of factorial WITHOUT recursion:");
            var without = new WithoutUsingRecursion();
            without.Factorial(int.Parse(Console.ReadLine()));
            
            Console.WriteLine($"Enter the number of factorial WITH recursion:");
            var with = new WithUsingRecursion();
            Console.WriteLine(with.GetFactorial(int.Parse(Console.ReadLine())));
        }
    }
}

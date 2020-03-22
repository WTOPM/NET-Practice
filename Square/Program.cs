using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Heron's formula states that the area of triangle:");

            Console.WriteLine($"Edit AB line:");
            double ab = double.Parse(Console.ReadLine());

            Console.WriteLine($"Edit BC line:");
            double bc = double.Parse(Console.ReadLine());

            Console.WriteLine($"Edit CB line:");
            double cb = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"AB: {ab}, BC: {bc}, CB: {cb}.");

            double p = (ab + bc + cb) / 2;
            double sqrt = Math.Sqrt(p * (p - ab) * (p - bc) * (p - cb));

            Console.WriteLine($"Square of the triangle: {Math.Round(sqrt, 2)}");
        }
            
    }

}






using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What the number is greater?");

            Console.WriteLine($"First number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Second number:");
            double num2 = double.Parse(Console.ReadLine());
        //1th
            if (num1 < num2)
            {
                Console.WriteLine($"{num2} greater then {num1}");
            }
            else
            {
                Console.WriteLine($"{num1} greater then {num2}");
            }
        //2th
            string greater = num1 > num2 ? "First number is greater" : "Second number is greater";
            Console.WriteLine(greater);
        //3rd
            double max = num2;
            if (num1 > num2)
            {
                max = num1;
            }
            Console.WriteLine($"{max} is greater");
        }
            
    }

}






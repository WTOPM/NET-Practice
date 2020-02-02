using System;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Fibonacci numbers");
            Console.WriteLine($"Enter the number:");
            int num = int.Parse(Console.ReadLine());

            double[] fibonacci = new double[num];
            double f0 = 0;
            double f1 = 1;

            fibonacci[0] = f0;
            fibonacci[1] = f1;

            for (int i = 2; i < num; i++)
            {
                double fn = f0 + f1;
                fibonacci[i] = fn;

                f0 = f1;
                f1 = fn;
            }

            foreach (double sum in fibonacci)
            {
                Console.WriteLine(sum);
            }

            }
         

        }

       

    }








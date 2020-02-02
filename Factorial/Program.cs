using System;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the factorial:");
            int num = int.Parse(Console.ReadLine());
            int i = 1;
            long res = 0;
            while (i <= num)
            {
                if (i == 1)
                res = 1;
                res *= i;
                i++;
            }
            Console.WriteLine(res);
        }
    }
}








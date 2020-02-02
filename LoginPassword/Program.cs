using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Login:");
            string login = Console.ReadLine();
            Console.WriteLine($"Password:");
            string pass = Console.ReadLine();
            string[] arrayLogin = {"Max", "Lexis", "Vasya"};
            bool existLogin = Array.Exists(arrayLogin, element => element == login);
            if (existLogin == true)
            {
                var arrayPass = new Dictionary<string, string>();
                arrayPass["Max"] = "google";
                arrayPass["Lexis"] = "admin";
                arrayPass["Vasya"] = "root";
                if (arrayPass[login] == pass)
                    Console.WriteLine("exist");
                else
                    Console.WriteLine("NotExist");
            }
            else
                Console.WriteLine("ERROR");
        }
    }
}








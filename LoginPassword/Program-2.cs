using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLogin = { "Max", "Lexis", "Vasya" };
            string[] arrayPass = { "google", "admin", "root" };
            Console.WriteLine($"Login:");
            string login = Console.ReadLine();
            bool existLogin = Array.Exists(arrayLogin, element => element == login);
            if (existLogin)
            {
                Console.WriteLine($"Password:");
                string pass = Console.ReadLine();
                if(Array.IndexOf(arrayLogin, login) == Array.IndexOf(arrayPass, pass))
                    Console.WriteLine("Login successful");
                else
                    Console.WriteLine("Wrong password");
            }
            else
                Console.WriteLine("Wrong user name");
        }
    }
}








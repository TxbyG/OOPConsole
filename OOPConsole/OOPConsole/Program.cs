using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartApp(args);
        }

        static void StartApp(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tutorial.");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Instructions.");
            Console.WriteLine("2. Deal 3 cards.");
            Console.WriteLine("3. Quit.");

            string User_input = Console.ReadLine();

            switch (User_input)
            {
                case "1":
                    Instructions(args);
                    break;
                case "2":
                    Console.WriteLine("Test");
                    break;
                case "3":
                    ExitApp(args);
                    break;
            }
        }

        static void Instructions(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
        }


        static async void ExitApp(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Goodbye.");
            await Task.Delay(5);

        }
    }
}

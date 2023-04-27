using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            Console.WriteLine("");
            Console.WriteLine("Welcome to the LinCode Tutorial.");
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Instructions.");
            Console.WriteLine("2. Deal 3 cards.");
            Console.WriteLine("3. Quit.");
            Console.WriteLine("");

            string User_input = Console.ReadLine();

            switch (User_input)
            {
                case "1":
                    Tutorial.Instructions(args);
                    break;
                case "2":
                    Test.Tests(args);
                    break;
                case "3":
                    ExitApp(args);
                    break;
                default:
                    StartApp(args);
                    break;
                
            }
        }

        static async void ExitApp(string[] args)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Goodbye.");
            await Task.Delay(500);
            Environment.Exit(0);

        }

        static void Score(string[] args)
        {
            //int answerCorrect;
            //int answerIncorrect;
            string text = File.ReadAllText("C:/Users/Computing/source/repos/OOPConsole/OOPConsole/data.txt");
            Console.WriteLine(text);
        }
    }
}

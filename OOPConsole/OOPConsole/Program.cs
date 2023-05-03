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

        public static void StartApp(string[] args)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Welcome to the LinCode Tutorial.");
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. Tutorial.");
            Console.WriteLine("2. Deal 3 cards.");
            Console.WriteLine("3. Test.");
            Console.WriteLine("4. Quit.");
            Console.WriteLine("");

            string User_input = Console.ReadLine();

            if (User_input == 1)
            {
                Tutorial.Instructions();
            }
            if (User_input == 2)
            {
                Pack.Packs();
            }
            if (User_input == 3)
            {
                Test.Tests();
            }
            if (User_input == 4)
            {
                ExitApp();
            }
            else
            {
                Console.WriteLine("Error! please try again");
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

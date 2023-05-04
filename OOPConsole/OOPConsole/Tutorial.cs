using System;
using System.Text;

namespace OOPConsole
{
    internal class Tutorial
    {

        // Inform the user on how to use the console.
        public static void Instructions(string[] args)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("       Tutorial");
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Console.WriteLine("Deal 3 cards");
            Console.WriteLine("Test");
            Console.WriteLine("Quit - is a way of closing the application down.");
            Console.WriteLine("");

            Console.WriteLine("1. Go back");

            string User_input = Console.ReadLine();

            if (User_input == 1)
            {
                Program.StartApp();
            }
            else
            {
                Instructions();
            }
        }
    }
}

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace OOPConsole
{
    internal class Test
    {

        // Use this file to test the maths questions.
        // Save data to txt file.
        public static void Tests(string[] args)
        {
            Console.Clear();

             // Generate a number from 1 to 13
            System.Random random = new System.Random(); 
            int num1 = random.Next(1,13);
            int num2 = random.Next(1,13);
            string value = random.Next(1,13);
            float correctAnswer;

            string User_input = Console.ReadLine();

            // Times
            if (value == "*")
            {
                correctAnswer = num1 * num2;
                if (User_input == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    TestLoop();
                }
                else
                {
                    Console.WriteLine("Incorrect! " + num1 " * " + num2 + "=" + correctAnswer);
                    TestLoop();
 
                }
            }
            // Add
            else if (value == "+")
            {
                correctAnswer = num1 + num2;
                if (User_input == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    TestLoop();

                }
                else
                {
                    Console.WriteLine("Incorrect! " + num1 " + " + num2 + "=" + correctAnswer);
                    TestLoop();
                }
            }

            // Subtract
            else if (value == "-")
            {
                correctAnswer = num1 - num2;
                if (User_input == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    TestLoop();
                }
                else
                {
                    Console.WriteLine("Incorrect! " + num1 " - " + num2 + "=" + correctAnswer);
                    TestLoop();
                }
            }

            // Divide
            else if (value == "/")
            {
                correctAnswer = num1 / num2;
                if (User_input == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    TestLoop();
                }
                else
                {
                    Console.WriteLine("Incorrect! " + num1 " / " + num2 + "=" + correctAnswer);
                    TestLoop();
                }
            }
            else
            {
                Console.WriteLine("Error! Please try again.");
            }
        }

        // Looping system
        void TestLoop()
        {
            string User_input = Console.ReadLine();
            Console.WriteLine("Would you like to try another?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            if (User_input == "No")
            {
                Program.StartApp()
            }
            else if
            {
                Tests();
            }

        }
    }
}
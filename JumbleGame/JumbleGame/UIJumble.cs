using JumbleGame;
using System;
using System.Threading;

namespace Jumble_Game
{
    internal class UIJumble
    {
        public void DisplayWelcome()
        {
            Console.Beep(658, 125);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t                     *******************************    ");
            Console.WriteLine("\t\t\t                     *                             *    ");
            Console.WriteLine("\t\t\t                     *         Word Jumble!        *    ");
            Console.WriteLine("\t\t\t                     *                             *    ");
            Console.WriteLine("\t\t\t                     *******************************    ");
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Thread.Sleep(2000);
            Console.WriteLine("\nHere's how it works...");
            Console.Clear();
            Console.WriteLine("\nThe computer will choose a random secret word and jumble all the letters in the word");
            Thread.Sleep(2000);
            Console.WriteLine("\nIt's then your job to guess the secret word");
            Thread.Sleep(2000);
            Console.WriteLine("\nSimple enough, right?  Ok, let's get started then...");
            Thread.Sleep(2000);
        }

        public void Play()
        {
            bool x = false;
            Jumble scramble = new Jumble();
            scramble.DisplayScramble();
            string result = scramble.DisplayScramble();
            Console.WriteLine();
            Console.WriteLine("The scrambled word is: " + result);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Now it's your turn to take a guess!");

            do
            {
                string answer = TakeAGuess();
                bool check = scramble.CompareResult(answer);
                x = check;
                if (check == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrect answer. Please try again!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Your answer, " + answer + ", was correct!");
                }
            } while (x == false);
        }

        public string TakeAGuess()
        {
            Console.WriteLine();
            Console.WriteLine("Your guess: ");
            string guess = Console.ReadLine();
            return guess;
        }

        public void SayGoodbye()
        {
            Console.Clear();
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t                    *******************************    ");
            Console.WriteLine("\t\t\t                    *      Thanks for playing!    *    ");
            Console.WriteLine("\t\t\t                    *            Goodbye          *    ");
            Console.WriteLine("\t\t\t                    *******************************    ");
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
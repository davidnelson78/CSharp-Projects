using Jumble_Game;
using System;

namespace JumbleGame
{
    internal class Program
    {
        private static void Main()
        {
            //a new instance of the Info class called myInfo is created
            Info myInfo = new Info();
            //starts the AssignmentInfo method from the Info class and passes in the assignment data string
            myInfo.DisplayInfo("Assignment 2 - Jumble Game");

            string Q = "y";
            do
            {
                UIJumble start = new UIJumble();
                start.DisplayWelcome();
                start.Play();
                Console.WriteLine();
                Console.WriteLine("Do you wish to play again? (y/n)");
                Q = Console.ReadLine();
                if (Q != "y" && Q != "Y")
                    break;
                Console.Clear();
            } while (true);
            UIJumble end = new UIJumble();
            end.SayGoodbye();
        }
    }
}
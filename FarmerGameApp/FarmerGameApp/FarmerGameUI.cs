using System;

namespace FarmerGame
{
    internal class FarmerGameUI
    {
        public void PlayAgain()
        {
            string Q = "y";
            do
            {
                DisplayWelcome();
                Play();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Would you like to play again? Y/N");
                Q = Console.ReadLine();
                string question = Q.ToLower();

                if (question != "y")
                    break;
                Console.Clear();
            } while (true);
        }

        private FarmerGame gameLogic;

        private static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Farmer Game - a test of logic!");
            Console.WriteLine();
            Console.WriteLine("The goal as the Farmer is to move all your");
            Console.WriteLine("goods - the fox, the chicken, and the grain -");
            Console.WriteLine("to the other side of the river without losing any of them");
            Console.WriteLine();
            Console.WriteLine("Press enter to play!");
            Console.ReadLine();
            Console.Clear();
        }

        public void Play()
        {
            gameLogic = new FarmerGame();
            string move = "";
            do
            {
                DisplayGameState();
                string result = PromptForMove(move);
                DisplayGameState();
                ProcessChoice(result);
                bool hasWon = gameLogic.DetermineWin();

                if (hasWon == true)
                {
                    Console.WriteLine("You have WON the game!");
                    return;
                }
                if (gameLogic.AnimalAteFood() == true)
                {
                    gameLogic.GameOver();
                    return;
                }
            } while (gameLogic.AnimalAteFood() == false);
        }

        public void ProcessChoice(string result)
        {
            string choice = result;

            gameLogic.Move(choice);

            if (gameLogic.AnimalAteFood() == false)
            {
                return;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Oh no! The food was eaten!");
                return;
            }
        }

        public string PromptForMove(string move)
        {
            string userInput = "";
            Console.WriteLine();
            Console.WriteLine("Type Chicken, Fox, or Grain and press enter to move it.");
            Console.WriteLine("\n");
            Console.WriteLine("To move just the farmer, press enter");
            userInput = Console.ReadLine();
            string moveObject = userInput.ToLower();
            return moveObject;
        }

        private void DisplayGameState()
        {
            Console.Clear();
            DisplayNorthBank();
            DisplayRiver();
            DisplaySouthBank();
            Console.WriteLine();
            Console.WriteLine("The farmer is on the " + gameLogic.Farmer + " bank");
        }

        private void DisplayNorthBank()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t^^^ North Bank ^^^");
            Console.WriteLine();
            Console.WriteLine("\t" + gameLogic.NorthBank());
            Console.WriteLine();
            Console.WriteLine("\t- - - - - - - - - ");
        }

        private void DisplayRiver()
        {
            Console.WriteLine();
            Console.WriteLine("\t~ ~ ~ ~ ~ ~ ~ ~ ~ ");
            Console.WriteLine("\t ~ ~ ~ River ~ ~ ~");
            Console.WriteLine("\t~ ~ ~ ~ ~ ~ ~ ~ ~ ");
            Console.WriteLine();
        }

        private void DisplaySouthBank()
        {
            Console.WriteLine("\t- - - - - - - - - ");
            Console.WriteLine();
            Console.WriteLine("\t" + gameLogic.SouthBank());
            Console.WriteLine();
            Console.WriteLine("\tvvv South Bank vvv");
            Console.WriteLine();
        }
    }
}
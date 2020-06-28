using System;

namespace TicTacToeGame
{
    internal class TicTacToeUI
    {
        private const int NUM_PLAYERS = 2;
        private const int FIRST = 0;
        private const int SECOND = 1;
        private TicTacToeLogic theBoard;
        private Player[] thePlayers = new Player[NUM_PLAYERS];
        private int current;

        public TicTacToeUI()
        {
            current = FIRST;
        }

        public void Play()
        {
            string Q = "y";

            DisplayWelcome();
            DisplayGrid();
            do
            {
                current = FIRST;
                theBoard = new TicTacToeLogic();
                theBoard.Reset();

                Player player1 = new Player();
                Player player2 = new Player();

                thePlayers[FIRST] = player1;
                thePlayers[SECOND] = player2;

                //removed extra code here for the players. No longer needed.

                while (IsPlaying())
                {
                    DisplayBoardGrid();
                    thePlayers[current].MakeMove(ref theBoard);
                    NextPlayer();
                }

                DisplayBoardGrid();
                AnnounceWinner();

                Q = PlayAgain();
                if (Q != "y")
                    break;
            } while (true);

            Console.Clear();
            Console.WriteLine("\n\n\nThanks for playing!!");
            Console.WriteLine("\n\nPress enter to exit");
            Console.ReadLine();
        }

        public void NextPlayer()
        {
            current = (current + 1) % NUM_PLAYERS;
        }

        private void DisplayGrid()
        {
            System.Console.WriteLine("\n  0 | 1 | 2 ");
            System.Console.WriteLine("  ---------- ");
            System.Console.WriteLine("  3 | 4 | 5 ");
            System.Console.WriteLine("  ---------- ");
            System.Console.WriteLine("  6 | 7 | 8 ");
            Console.WriteLine("\n\nPress enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        private void DisplayBoardGrid()
        {
            char[] thegrid;
            thegrid = theBoard.PlayingBoard;
            Console.Clear();
            Console.WriteLine("\n\n\n\t  {0} | {1} | {2} ", thegrid[0], thegrid[1], thegrid[2]);
            Console.WriteLine("\t  ---------- ");
            Console.WriteLine("\t  {0} | {1} | {2} ", thegrid[3], thegrid[4], thegrid[5]);
            Console.WriteLine("\t  ---------- ");
            Console.WriteLine("\t  {0} | {1} | {2}", thegrid[6], thegrid[7], thegrid[8]);
            Console.WriteLine("\n\n");
        }

        private void DisplayWelcome()
        {
            Console.WriteLine("\nWelcome to a game of Tic Tac Toe!");
            Console.WriteLine("\nUse the numbers to pick where to place your X's and O's, as shown below.");
        }

        public void AskMove(char player)
        {
            Console.WriteLine("\nPlayer {0}, where would you like to move?(0-8)\n", player);
        }

        private void AnnounceWinner()
        {
            Console.WriteLine("\nThe game has ended, and the results are in!");

            if (IsTie())
            {
                Console.WriteLine("\n\nThe game is a tie.");
            }
            else
            {
                Console.WriteLine("\n\nThe winner is... ");
                if (theBoard.IsWinner(thePlayers[FIRST].GetPiece()))
                    Console.WriteLine("Player {0}!!", thePlayers[FIRST].GetPiece());
                else
                    Console.WriteLine("Player {0}!!", thePlayers[SECOND].GetPiece());
            }
        }

        public bool IsPlaying()
        {
            return (!theBoard.IsFull() && !theBoard.IsWinner(thePlayers[FIRST].GetPiece()) && !theBoard.IsWinner(thePlayers[SECOND].GetPiece()));
        }

        public bool IsTie()
        {
            return (theBoard.IsFull() && !theBoard.IsWinner(thePlayers[FIRST].GetPiece()) && !theBoard.IsWinner(thePlayers[SECOND].GetPiece()));
        }

        public string PlayAgain()
        {
            Console.WriteLine("\nWould you like to play again? (Y/N)");
            string doAgain = Console.ReadLine();
            string Q = doAgain.ToLower();
            return Q;
        }
    }
}
using System;

namespace TicTacToeGame
{
    internal class Player
    {
        private const int NUM_PIECES = 2;
        private char[] PIECES = new char[NUM_PIECES] { 'X', 'O' };
        private static int current;
        protected char m_piece;

        public Player()
        {
            m_piece = PIECES[current];
            current = (current + 1) % NUM_PIECES;
        }

        public char GetPiece()
        {
            return m_piece;
        }

        public void MakeMove(ref TicTacToeLogic aBoard)
        {
            int move;
            TicTacToeUI theGame = new TicTacToeUI();
            do
            {
                theGame.AskMove(GetPiece());
                string X = Convert.ToString(Console.ReadLine());
                if (X == "")
                {
                    move = Convert.ToInt32("9");
                }
                else
                {
                    move = Convert.ToInt32(int.Parse(X));
                }
            } while (!aBoard.IsLegalMove(move));

            aBoard.ReceiveMove(GetPiece(), move);
        }
    }
}
using System;

namespace TicTacToeGame
{
    internal class HumanPlayer : Player
    {
        public override void MakeMove(ref TicTacToeLogic aBoard)
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
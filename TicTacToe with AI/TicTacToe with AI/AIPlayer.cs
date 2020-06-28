using System;

namespace TicTacToe_with_AI
{
    internal class AIPlayer : Player //inheriting from player
    {
        public override void MakeMove(ref TicTacToeLogic aBoard)
        {
            //Uncomment the below to randomize the list of numbers
            Random r = new Random();
            int i = r.Next(8);
            int move = 0;
            //Comment out the below when randomizing the list of numbers
            //int i = 0;

            int[] nums = { 4, 0, 2, 6, 8, 1, 3, 5, 7 };  //the list of numbers

            do
            {
                //move is set to the first number of the list, then incremented at each pass
                move = nums[i];
                ++i;
            } while (!aBoard.IsLegalMove(move));
            aBoard.ReceiveMove(GetPiece(), move);
        }
    }
}
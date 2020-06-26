namespace TicTacToeGame
{
    internal class Program
    {
        private static void Main()
        {
            Info myInfo = new Info();
            TicTacToeUI theGame = new TicTacToeUI();

            myInfo.DisplayInfo();
            theGame.Play();
        }
    }
}
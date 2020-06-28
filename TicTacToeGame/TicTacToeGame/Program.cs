namespace TicTacToeGame
{
    internal class Program
    {
        private static void Main()
        {
            Info myID = new Info();
            TicTacToeUI theGame = new TicTacToeUI();

            myID.StudentInfo();
            theGame.Play();
        }
    }
}
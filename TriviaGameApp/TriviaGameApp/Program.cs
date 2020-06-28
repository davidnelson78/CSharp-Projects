namespace TriviaGameApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyInfo myID = new MyInfo();
            Controller cTroller = new Controller();

            myID.StudentInfo();

            cTroller.DisplayWelcome();

            cTroller.Play();
        }
    }
}
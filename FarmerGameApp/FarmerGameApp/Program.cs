using System.Threading;

namespace FarmerGame
{
    internal class Program
    {
        private static void Main()
        {
            //a new instance of the Info class called myInfo is created
            Info myInfo = new Info();
            //starts the AssignmentInfo method from the Info class and passes in the assignment data string
            myInfo.DisplayInfo("Assignment 3 - Farmer Game");

            Thread.Sleep(4000);

            ElectionUI playGame = new ElectionUI();
            playGame.MainMethod();
        }
    }
}
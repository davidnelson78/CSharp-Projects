using System;

namespace BaseballPlayerApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //a new instance of the Info class called myInfo is created
            Info myInfo = new Info();
            //starts the AssignmentInfo method from the Info class and passes in the assignment data string
            myInfo.AssignmentInfo("Assignment 1 - Baseball Player App");

            //a new instance of the BaseBallPlayerUI class called aPlayer is created.
            BaseBallPlayerUI aPlayer = new BaseBallPlayerUI();
            //starts the MainMethod from the BaseBallPlayerUI class
            aPlayer.MainMethod();

            Console.Read();
        }
    }
}
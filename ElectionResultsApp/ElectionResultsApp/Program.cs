namespace ElectionResultsApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //a new instance of the Info class called myInfo is created
            Info myInfo = new Info();
            //starts the AssignmentInfo method from the Info class and passes in the assignment data string
            myInfo.DisplayInfo("Assignment 3 - Election Results");

            Thread.Sleep(4000);

            ElectionUI start = new ElectionUI();
            start.MainMethod();
        }
    }
}
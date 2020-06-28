using System;

namespace TicTacToe_with_AI
{
    internal class Info
    {
        public void DisplayInfo()
        {
            string studentInfo = "David Nelson";
            string courseName = "ITDEV 115-501";
            string dueDate = "20 NOV 2017";
            string assignment = "Tic Tac Toe with AI";
            string instructor = "Robert Menzl";

            //Contains my info for ID in assignments
            Console.WriteLine("* * * * * * * * * * * * * * *");
            Console.WriteLine();
            Console.WriteLine("Name:\t\t{0}", studentInfo);
            Console.WriteLine("Course:\t\t{0}", courseName);
            Console.WriteLine("Date:\t\t{0}", dueDate);
            Console.WriteLine("Assign:\t\t{0}", assignment);
            Console.WriteLine("Instructor:\t{0}", instructor);
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * * * * *");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
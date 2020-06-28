using System;

namespace ElectionResultsApp
{
    internal class Info
    {
        //the assignment string from Program class is passed into the AssignmentInfo method
        public void DisplayInfo(string assignment)
        {
            Console.WriteLine("****************************************\n");
            Console.WriteLine("Name:\t\tDavid Nelson");
            Console.WriteLine("Course:\t\tITDEV-115-501");
            Console.WriteLine("Instructor:\tMr. Menzl");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("*****************************************");
        }
    }
}
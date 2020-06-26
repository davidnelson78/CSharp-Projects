using System;

namespace PlayerApp
{
    internal class Info
    {
        public void DisplayInfo(string assignment)
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Name:\t\tRobert Menzl");
            Console.WriteLine("Course:\t\tITDEV-115-002");
            Console.WriteLine("Instructor:\tMr. Menzl");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
        }
    }
}
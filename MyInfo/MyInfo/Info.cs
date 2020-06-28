using System;

namespace MyInfo
{
    internal class MyInfo
    {
        public void DisplayInfo()
        {
            Console.WriteLine("************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Name:\t\tDavid Nelson");
            Console.WriteLine("Course:\t\tITDEV-115-501");
            Console.WriteLine("Instructor:\tMr. Menzl");
            Console.WriteLine("Assignment:\tAssignment 1 - Display Info");
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("************************************************************************");
        }
    }
}
﻿using System;

namespace TriviaGameApp
{
    internal class MyInfo
    {
        public void StudentInfo()
        {
            string studentInfo = "David Nelson";
            string courseName = "ITDEV 115-501";
            string dueDate = "10 NOV 2017";
            string assignment = "Trivia Game";
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
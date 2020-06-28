using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Info
    {
        public void DisplayInfo(string assignment)
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Name:\t\tRobert Menzl");
            Console.WriteLine("Course:\t\tITDEV-110-001");
            Console.WriteLine("Instructor:\tMr. Menzl");
            Console.WriteLine("Assignment:\t{0}", assignment);
            Console.WriteLine("Date:\t\t" + System.DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
        }
    }
}
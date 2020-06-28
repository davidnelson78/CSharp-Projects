using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("Assignment #2A - Practice Arrays");

            StudentUI aStudent = new StudentUI();
            aStudent.MainMethod();

            Console.Read();
        }
    }
}
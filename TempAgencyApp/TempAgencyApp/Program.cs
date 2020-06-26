using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempAgencyApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("Temp Agency Application");

            TempAgencyUI theAgency = new TempAgencyUI();
            theAgency.MainMethod();

            Console.ReadKey();
        }
    }
}
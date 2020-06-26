using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempAgencyApp
{
    internal class TempAgencyUI
    {
        public void MainMethod()
        {
            int numberOfPeople;

            DisplayInstructions();
            Console.Write("\n\nPlease enter the number of sales people in this group: ");
            while (int.TryParse(Console.ReadLine(), out numberOfPeople) == false)
            {
                Console.WriteLine("\n\tERROR IN INPUT\n\tPlease try again\n");
                Console.Write("\n\nPlease enter the number of sales people in this group: ");
            }

            TempAgency anAgency = new TempAgency(numberOfPeople);

            GetSalesPersonsNames(anAgency);

            GetSalesData(anAgency);

            anAgency.ProduceSalesProductionTable();

            DisplayResults(anAgency);
        }

        private static void DisplayInstructions()
        {
            Console.WriteLine("\n\nYou will be asked to enter data for the temporary sales people.  After entering");
            Console.WriteLine("the number of sales people in this month's group, enter their first name, followed by");
            Console.WriteLine("a space and then their last name.  Next you will enter the expected sales for the first");
            Console.WriteLine("month.\n\n");
            Console.WriteLine("Hit any key when you are ready to continue");
            Console.ReadKey();

            Console.Clear();
        }

        private static void GetSalesPersonsNames(TempAgency myAgency)
        {
            string theName;

            Console.WriteLine("\n\n");

            for (int x = 0; x < myAgency.Salesman.Length; x++)
            {
                Console.Write("Please enter the {0}'s salesperson's name: ", x + 1);
                theName = Console.ReadLine();
                myAgency.SetSalesPerson(x, theName);
            }
        }

        private static void GetSalesData(TempAgency agency)
        {
            double initialSales;

            Console.WriteLine("\n\n");

            for (int x = 0; x < agency.Salesman.Length; x++)
            {
                Console.Write("Please enter the initial sales figure for {0}: \t", agency.Salesman[x]);
                while (double.TryParse(Console.ReadLine(), out initialSales) == false)
                {
                    Console.WriteLine("\n\tERROR IN INPUT\n\tPlease try again\n");
                    Console.WriteLine("Please enter the initial sales figure for {0}\t: ", agency.Salesman[x]);
                }

                agency.SetInitialSales(x, initialSales);
            }
        }

        private static void DisplayResults(TempAgency agency)
        {
            string[] theName = new string[2];

            DisplayHeader(agency);

            for (int index = 0; index < agency.Salesman.GetLength(0); index++)
            {
                theName = agency.Salesman[index].Split(' ');
                Console.Write(theName[1] + ", " + theName[0]);

                Console.Write("\t\t      {0:C2}      {1:C2}         {2:C2}         {3:C2}         {4:C2}", agency.Sales[index, 0], agency.Sales[index, 1], agency.Sales[index, 2], agency.Sales[index, 3], agency.Sales[index, 4]);

                Console.Write("\n");
            }
        }

        private static void DisplayHeader(TempAgency theAgency)
        {
            double inc = 0.05;

            Console.Clear();

            Console.Write("{0, -20}           {1, -10}", "SalesPerson", "Initial");

            for (int col = 1; col < theAgency.Sales.GetLength(1); col++)
            {
                Console.Write("{0, -6}   {1, -1}    ", "      Month", col);
            }
            Console.WriteLine();

            Console.Write("    {0, -14}            {1, -2}", "Name", "  Sales   ");

            for (int col = 1; col < theAgency.Sales.GetLength(1); col++)
            {
                Console.Write("   {0, 9}        ", inc.ToString("P0"));
                inc = inc + 0.05;
            }
            Console.WriteLine("\n___________________________________________________________________________________________________________________\n");
        }
    }
}
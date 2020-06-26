using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempAgencyApp
{
    internal class TempAgency
    {
        private string[] salesman;
        private double[,] sales;
        private const int MONTHS = 4;

        public TempAgency(int numberOfSalesPeople)
        {
            salesman = new string[numberOfSalesPeople];
            sales = new double[numberOfSalesPeople, MONTHS + 1];
        }

        public string[] Salesman
        {
            get
            {
                return salesman;
            }
        }

        public double[,] Sales
        {
            get
            {
                return sales;
            }
        }

        public void SetSalesPerson(int index, string name)
        {
            salesman[index] = name;
        }

        public void SetInitialSales(int index, double initialSales)
        {
            sales[index, 0] = initialSales;
        }

        public void ProduceSalesProductionTable()
        {
            for (int index = 0; index < sales.GetLength(0); index++)
            {
                sales[index, 1] = 1.05 * sales[index, 0];
                sales[index, 2] = 1.1 * sales[index, 1];
                sales[index, 3] = 1.15 * sales[index, 2];
                sales[index, 4] = 1.2 * sales[index, 3];
            }
        }
    }
}
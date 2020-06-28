using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {
        private int id;
        private string name;
        private double[] hours = new double[7];

        public Student()
        {
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void EnterHours(int index, double hrs)
        {
            hours[index] = hrs;
        }

        public double[] GetNumberHours()
        {
            return hours;
        }

        public double CalculateAvg()
        {
            double total = 0.0;

            foreach (double entry in hours)
                total = total + entry;

            return (total / hours.Length);
        }
    }
}
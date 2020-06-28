using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class StudentUI
    {
        private string[] days = { "Sunday   ", "Monday   ", "Tuesday  ", "Wednesday", "Thursday ", "Friday   ", "Saturday " };

        public void MainMethod()
        {
            int iden;
            Student myStudent = new Student();

            Console.Write("Please enter your name:\t\t");
            myStudent.Name = Console.ReadLine();

            Console.Write("Please enter your student id:\t");
            while (int.TryParse(Console.ReadLine(), out iden) == false)
            {
                Console.WriteLine("\nYou entered an invalid response!  Please try again\n\n");
                Console.Write("Please enter your student id:\t");
            }

            myStudent.ID = iden;

            Console.WriteLine("\n");

            FillHours(myStudent);

            DisplayData(myStudent);

            DisplayAverage(myStudent);
        }

        public void DisplayAverage(Student theStudent)
        {
            Console.Write("\n\nThe average number of hours studied per day was {0:N2}", theStudent.CalculateAvg());
        }

        public void DisplayData(Student anyStudent)
        {
            double[] weeklyHours = new double[days.Length];

            Console.Clear();
            Console.WriteLine("\n\n\nName: {0}", anyStudent.Name);
            Console.WriteLine("ID: {0}", anyStudent.ID);
            Console.WriteLine("\n\nThe number of hours of study that you did during the week are as follows:");

            weeklyHours = anyStudent.GetNumberHours();

            for (int i = 0; i < days.Length; i++)
            {
                Console.Write("\t{0}:", days[i]);
                Console.WriteLine("\t{0:N2}", weeklyHours[i]);
            }
        }

        public void FillHours(Student theStudent)
        {
            for (int index = 0; index < days.Length; index++)
            {
                double hrs;

                Console.Write("Enter the number of hours that you studied ITDEV-115 on {0}:\t ", days[index]);
                while (double.TryParse(Console.ReadLine(), out hrs) == false)
                {
                    Console.WriteLine("\nYou entered an invalid response!  Please try again\n\n");
                    Console.Write("Enter the number of hours that you studied ITDEV-115 on {0}:\t ", days[index]);
                }

                theStudent.EnterHours(index, hrs);
            }
        }
    }
}
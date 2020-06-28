using System;

namespace StudentGradesApp
{
    internal class GradesUI
    {
        private StudentS myStudentS;

        public void MainMethod()
        {
            StudentS s = new StudentS();
            s.PopulateStudents("grades.txt");

            if (s.Complete == true)
            {
                DisplayInfo();
            }
            else
            {
                Console.WriteLine("Error - The file was not loaded");
            }
        }

        private void DisplayInfo()
        {
            Console.WriteLine("Student id\tLast Name\tAverage  \tGrade");

            for (int index = 0; index < myStudentS.ListLength; index++)
            {
                Console.WriteLine(" {0} \t {1}    \t {2}    \t {3}", myStudentS.StudentID(index), myStudentS.StudentLastName(index), myStudentS.StudentAverage(index), myStudentS.StudentGrade(index));
            }
        }
    }
}
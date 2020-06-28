using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/******************************
 * Student: David Nelson
 * Purpose: Students Class - hold List of Students
 ************************************/

namespace StudentGradesApp
{
    internal class StudentS
    {
        private bool complete = false;

        private List<Student> theStudentList;

        public string PopulateStudents(string path)
        {
            //this is the method you need to implement...NO CONSOLE LOGIC in this file.
            //use the parameter path for file name, and return an error string!!
            FileInfo theSourceFile = new FileInfo(@path);
            string[] field;
            string line = null;
            char[] delimiter = { System.Convert.ToChar(",") };
            int index = 0;

            StreamReader reader = theSourceFile.OpenText();

            try
            {
                line = reader.ReadLine();

                while (line != null)
                {
                    field = line.Split(delimiter);

                    Student student = new Student();

                    student.StudentID = field[0];
                    student.NameFirst = field[1];
                    student.NameLast = field[2];
                }

                while (index < 20)
                {
                    Student.EnterGrade(earnedValue, possValue);

                    index++;
                }

                theStudentList.Add(this.student);
            }
            catch (System.IO.IOException e)
            {
                Console.Error.WriteLine(e.Message);
            }
            return "Exception Occurred";
        }

        public int ListLength
        {
            get { return theStudentList.Count; }
        }

        public bool Complete { get => complete; set => complete = value; }

        public string StudentID(int index)
        {
            return theStudentList.ElementAt(index).ID;
        }

        public string StudentLastName(int index)
        {
            return theStudentList.ElementAt(index).NameLast;
        }

        public string StudentGrade(int index)
        {
            theStudentList.ElementAt(index).CalGrade();
            return theStudentList.ElementAt(index).LetterGrade;
        }

        public float StudentAverage(int index)
        {
            theStudentList.ElementAt(index).CalGrade();
            return theStudentList.ElementAt(index).Average;
        }
    }
}
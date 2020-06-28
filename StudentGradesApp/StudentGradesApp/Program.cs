namespace StudentGradesApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyInfo myID = new MyInfo();
            myID.StudentInfo();

            GradesUI grades = new GradesUI();
            grades.MainMethod();
        }
    }
}
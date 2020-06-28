using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndDirectoryProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] anArray = { "ITDEV-115", "File Example", "Robert Menzl" };
            string[] secondArray = new string[4];
            string thePath = "G:\\users\\robert\\documents\\visual studio 2012\\Projects\\Atestfile";

            File.WriteAllLines(thePath, anArray);

            Console.WriteLine("File Name: " + thePath);
            Console.WriteLine("Created: " + File.GetCreationTime(thePath));
            Console.WriteLine("Attributes: " + File.GetAttributes(thePath));
            Console.WriteLine("Last Written To: " + File.GetLastWriteTime(thePath));
            Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());
            Console.WriteLine("Parent Directory: " + Directory.GetParent(Directory.GetCurrentDirectory()));

            File.AppendAllText(thePath, "Section 002");

            Console.WriteLine("\n\n" + File.ReadAllText(thePath));
            secondArray = File.ReadAllLines(thePath);

            Console.WriteLine("\n\nClass: \t\t" + secondArray[0]);
            Console.WriteLine("Assignment: \t" + secondArray[1]);
            Console.WriteLine("Name:\t \t" + secondArray[2]);
            Console.WriteLine("Section: \t" + secondArray[3]);

            Console.ReadKey();
        }
    }
}
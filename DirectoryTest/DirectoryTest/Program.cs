using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name;
            long size;

            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine("Current Directory: \n{0}\n", Directory.GetCurrentDirectory());

            Console.WriteLine("The parent directory is {0}", dir.Parent);
            Console.WriteLine("The root directory is {0}", dir.Root);

            Console.WriteLine("\n\n   File Name\t\t\t\t\t\tSize\n");

            foreach (FileInfo fil in dir.GetFiles("*.exe"))
            {
                name = fil.Name;
                size = fil.Length;
                Console.WriteLine("{0}    {1,12:N0}", name.PadRight(45), size);
            }

            Console.ReadLine();
        }
    }
}
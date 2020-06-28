using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Queue firstInFirstOut = new Queue();
            Stack lastInFirstOut = new Stack();

            string name;
            int age;
            object obj;

            firstInFirstOut.Enqueue("jill won");
            firstInFirstOut.Enqueue("donna abbott");
            firstInFirstOut.Enqueue(34);
            firstInFirstOut.Enqueue("jeremy door");
            firstInFirstOut.Enqueue("jill won");

            Console.WriteLine("the first object in the queue is " + firstInFirstOut.Dequeue());
            name = (string)firstInFirstOut.Dequeue();
            Console.WriteLine("the second object in the queue is " + name);

            age = (int)firstInFirstOut.Dequeue();
            Console.WriteLine("the third object is and integer that equals " + age);
            Console.WriteLine("\n\n");

            lastInFirstOut.Push("jill won");
            lastInFirstOut.Push("donna abbott");
            lastInFirstOut.Push(34);
            lastInFirstOut.Push("jeremy door");

            Console.WriteLine("the last object in the stack is " + lastInFirstOut.Pop());
            Console.WriteLine("the next object is " + lastInFirstOut.Peek());

            Console.ReadKey();
        }
    }
}
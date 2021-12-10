using StacksAndQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome to Stack and Queue Program**********");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
        }
    }
}

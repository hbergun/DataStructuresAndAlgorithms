using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithOneWayLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine(stack.IsEmpty());
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pull());
            Console.WriteLine(stack.Pull());
            Console.WriteLine(stack.Peek());

            Console.ReadKey();
        }

    }
}

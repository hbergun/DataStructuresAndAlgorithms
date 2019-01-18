using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(100);

            stack.Push(10);
            stack.Push(9);
            stack.Push(8);
            stack.Push(7);
            stack.Push(6);
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
        
            //stack.Peek();
        }
    }
}

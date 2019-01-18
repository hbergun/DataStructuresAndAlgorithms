using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircluarLinkedList
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            CircluarLinkedList CL = new CircluarLinkedList();
            CL.AddFirst(5);
            CL.AddFirst(4);
            CL.AddFirst(3);
            CL.AddFirst(2);
            CL.AddFirst(1);
            Console.WriteLine(CL.Traverse());
            CL.AddFirst(0);
            Console.WriteLine(CL.Traverse());
            CL.AddLast(6);
            Console.WriteLine(CL.Traverse());
            CL.AddPosition(6, 100);
            Console.WriteLine(CL.Traverse());
            CL.AddLast(666);
            Console.WriteLine(CL.Traverse());
            Console.WriteLine(CL.GetNode(8).Data);
            CL.DeletePosition(3);
            Console.WriteLine(CL.Traverse());
            CL.AddLast(667);
            Console.WriteLine(CL.Traverse());

            Console.ReadKey();
                
        }
    }
}

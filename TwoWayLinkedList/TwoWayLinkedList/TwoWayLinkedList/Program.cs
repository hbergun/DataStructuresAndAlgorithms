using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoWayLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoWayLinkedList DL = new TwoWayLinkedList();
            DL.AddFirst(5);
            DL.AddFirst(4);
            DL.AddFirst(3);
            DL.AddFirst(2);
            DL.AddFirst(1);
            Console.WriteLine(DL.Traverse());
            Console.WriteLine(DL.GetNode(4).Value);
            DL.AddPosition(4,0);
            Console.WriteLine(DL.Traverse());
            DL.DeletePosition(5);
            Console.WriteLine(DL.Traverse());
            DL.DeleteLast();
            Console.WriteLine(DL.Traverse());
            DL.DeleteFirst();
            Console.WriteLine(DL.Traverse());
            DL.AddFirst(0);
            Console.WriteLine(DL.Traverse());
            DL.AddLast(999);
            Console.WriteLine(DL.Traverse());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListConcrete LL = new LinkedListConcrete();
            LL.AddFirst(5);
            LL.AddFirst(4);
            LL.AddFirst(3);
            LL.AddFirst(2);
            LL.AddFirst(1);
            Console.WriteLine(LL.Traverse());
            LL.AddLast(100);
            Console.WriteLine(LL.Traverse());
            LL.AddPosition(3, 300);
            Console.WriteLine(LL.Traverse());
            Console.WriteLine(LL.GetNode(3).Data);
            LL.DeleteFirst();
            Console.WriteLine(LL.Traverse());
            LL.DeleteFromPosition(4);
            Console.WriteLine(LL.Traverse());
            LL.DeleteLast();
            Console.WriteLine(LL.Traverse());
            LL.AddLast(999);
            Console.WriteLine(LL.Traverse());
            LL.DeleteLast();
            Console.WriteLine(LL.Traverse());
            LL.AddPosition(3,100);
            Console.WriteLine(LL.Traverse());
            LL.DeleteLast();
            Console.WriteLine(LL.Traverse());
            LL.DeleteFirst();
            Console.WriteLine(LL.Traverse());
            Console.WriteLine(LL.GetNode(0).Data);
            Console.WriteLine(LL.GetNode(2).Data);



            Console.ReadKey();
        }
    }
}

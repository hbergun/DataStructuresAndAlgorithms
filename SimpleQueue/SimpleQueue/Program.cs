using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(5);
            Console.WriteLine(queue.IsEmpty());
            queue.enqueue("Hasan");
            queue.enqueue("Berk");
            queue.enqueue("Ergün");
            queue.enqueue("Yazılım");
            queue.enqueue("Mühendisi");
            Console.WriteLine("Peek Effect " + queue.Peek());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());
            Console.WriteLine(queue.dequeue());

            Console.Read();
        }
    }
}

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
          
            object value = Denemeler();
            Console.WriteLine(((TestSınıfı)value).X);

            object Denemeler()
            {
                return new TestSınıfı();
            }
            Console.ReadKey();
        }

        public class TestSınıfı
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        float

    }
}

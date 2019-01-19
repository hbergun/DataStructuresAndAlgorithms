using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithOneWayLinkedList
{
    public abstract class LinkedListADT
    {
        public Node Last { get; set; }
        public Node LastPrev { get; set }
        private int size = -1;

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (size > -1)
                    size = value;
            }

        }
        public abstract void AddLast(int value);
        public abstract int GetLast();
    }
}

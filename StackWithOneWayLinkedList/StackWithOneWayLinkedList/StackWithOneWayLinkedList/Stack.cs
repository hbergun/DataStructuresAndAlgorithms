using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithOneWayLinkedList
{
    public class Stack : IStack
    {
        private LinkedListConcrete linkedList;
        public Stack()
        {
            linkedList = new LinkedListConcrete();
        }
        public bool IsEmpty()
        {
            return linkedList.Size == -1 ? true : false;
        }

        public int Peek()
        {
            return linkedList.Last.Data;
        }

        public int Pull()
        {
            return linkedList.GetLast();
        }

        public void Push(int Value)
        {
            linkedList.AddLast(Value);
        }
    }
}

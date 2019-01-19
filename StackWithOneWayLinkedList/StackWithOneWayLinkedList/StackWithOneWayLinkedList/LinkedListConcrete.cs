using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithOneWayLinkedList
{
    public class LinkedListConcrete : LinkedListADT
    {
        public override void AddLast(int value)
        {
            Node Temp = new Node() { Data = value };
            if (Last == null)
            {
                Last = Temp;
                Size++;
            }
            else
            {
                Last.Next = Temp;
                Last = Temp;
                Size++;
            }
        }

        public override int GetLast()
        {
            return Last.Data; 
        }
    }
}

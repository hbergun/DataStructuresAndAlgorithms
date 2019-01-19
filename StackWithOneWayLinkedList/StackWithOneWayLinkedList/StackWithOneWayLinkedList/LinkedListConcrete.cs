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
            //if (Last.Prev != null || Last!=null)
            if (Last == null)
            {
                Last = Temp;
                Size++;
            }
            else
            {
                Temp.Prev = Last;
                Last = Temp;
                Size++;
            }
        }

        public override int GetLast()
        {
            if (Size!=-1)
            {
                Node Temp = Last;
                Last = null;
                Last = Temp.Prev;

                int ReturnValue = Temp.Data;
                Temp = null;
                Size--;

                return ReturnValue;
            }
            else
            {
                return int.MinValue;
            }
        }
    }
}

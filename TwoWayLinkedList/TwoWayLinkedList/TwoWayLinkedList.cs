using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoWayLinkedList
{
    public class TwoWayLinkedList : TwoWayLinkedListADT
    {
        public override void AddFirst(int value)
        {
            Node Temp = new Node { Value = value };
            if(Head == null)
            {
                Head = Temp;
                Size++;
            }
            else
            {
                Temp.Next = Head;
                Head.Prev = Temp;
                Head = Temp;
                Size++;
            }
        }

        public override void AddLast(int value)
        {
            
        }

        public override void AddPosition(int position, int value)
        {
            throw new NotImplementedException();
        }

        public override void DeleteFirst()
        {
            throw new NotImplementedException();
        }

        public override void DeleteLast()
        {
            throw new NotImplementedException();
        }

        public override void DeletePosition(int position)
        {
            throw new NotImplementedException();
        }

        public override Node GetNode(int position)
        {
            Node Temp=Head;
            for (int i = 0; i < position; i++)
            {
                Temp = Temp.Next;
            }
            return Temp;
        }

        public override StringBuilder Traverse()
        {
            throw new NotImplementedException();
        }
    }
}

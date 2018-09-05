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
            Node Temp = new Node { Value = value };
            GetNode(Size).Next = Temp;
            Size++;
        }
        public override void AddPosition(int position, int value)
        {
            if (position != 0 && position <= Size)
            {
                Node Temp = new Node { Value = value };
                Node GetNodeValue = GetNode(position - 1);
                Temp.Next = GetNodeValue.Next;
                Temp.Prev = GetNodeValue;
                GetNodeValue.Next.Prev = Temp;
                GetNodeValue.Next = Temp;
                Size++;
            }
            else if (position == 0)
                AddFirst(value);
            else
                return;
          
        }

        public override void DeleteFirst()
        {
            if (Size != 0)
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            else
                return;

        }

        public override void DeleteLast()
        {
            if (Size != 0)
            {
                Node Temp = GetNode(Size - 1);
                Temp.Next.Prev = null;
                Temp.Next = null;
            }
            else
                return;

        }

        public override void DeletePosition(int position)
        {
            if (position > 0 && position < Size)
            {
                Node Current = GetNode(position);
                Current.Prev.Next = Current.Next;
                Current.Next.Prev = Current.Prev;
                Current.Prev = null;
                Current.Next = null;
            }
            else if (position == 0)
                DeleteFirst();
            else if (position == Size)
                DeleteLast();
            else
                return;
           
        }

        public override Node GetNode(int position)
        {
            if (Size >= position && position >= 0)
            {
                Node Temp = Head;
                for (int i = 0; i < position; i++)
                    Temp = Temp.Next;
                return Temp;
            }
            else if (position == 0)
                return Head;
            else
                throw new Exception("Geçersiz Pozisyon");

        }

        public override StringBuilder Traverse()
        {
            StringBuilder ReturnValue = new StringBuilder();
            Node Temp = Head;
            while (Temp != null)
            {
                ReturnValue.Append(Temp.Value + "-->");
                Temp = Temp.Next;
            }
            return ReturnValue;
        }
    }
}

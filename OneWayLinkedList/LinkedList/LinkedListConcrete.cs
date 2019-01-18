using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListConcrete : LinkedListADT
    {
        //HBE...
        public override void AddFirst(int value)
        {
            Node Temp = new Node { Data = value };
            if (Head == null) //İf The List İs Empty,The First Value İs The Root(Head)
            {
                Head = Temp;
                Size++;
            }
            else
            {
                Temp.Next = Head;
                Head = Temp;
                Size++;
            }
        }//Passed
        public override StringBuilder Traverse()
        {
            StringBuilder Elements = new StringBuilder();
            Node Temp = Head;
            while (Temp != null)
            {
                Elements.Append(Temp.Data + "-->");
                Temp = Temp.Next; //Next Data
            }
            return Elements;
        }//Passed
        public override void AddPosition(int position, int value)
        {
            Node Add = new Node() { Data = value };

            if (position <= Size && position > 0)
            {
                Node Previous = GetNode(position - 1);
                Add.Next = Previous.Next;
                Previous.Next = Add;
                Size++;
            }
            else if (position == 0)
            {
                AddFirst(position);
            }
            else
                throw new Exception("Hatalı Pozisyon");

        }//Passed
        public override Node GetNode(int position)
        {
            if (Size >= position && position >= 0)
            {
                Node TempReturn = Head;
                for (int i = 0; i < position; i++)
                    TempReturn = TempReturn.Next;
                return TempReturn;
            }
            else
                throw new Exception("Geçersiz Pozisyon");

        }//Passed
        public override void DeleteFirst()
        {
            if (Size != 0)
            {
                Head = Head.Next;
                Size--;
            }
            else
                return;
        }//Passed

        public override void DeleteFromPosition(int position)
        {
            Node Previous = GetNode(position - 1);
            Previous.Next = Previous.Next.Next;
            Size--;
        }//Passed

        public override void DeleteLast()
        {
            Node Temp = GetNode(Size - 1);
            Temp.Next = null;
            Size--;
        }//Passed

        public override void AddLast(int value)
        {
            Node Add = new Node { Data = value };
            if (Head == null) //Because No Elements
                AddFirst(value);
            else
            {
                GetNode(Size).Next = Add; //Because C#(for advanced data type) Call(Pass) By Reference 
                Size++;                   //Primitive Data Type Call(Pass) By Value 
            }
        }
    }//Passed
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircluarLinkedList
{
    public class CircluarLinkedList : CircluarLinkedListADT
    {
        public override void AddFirst(int value) //Circluar 
        {
            Node Add = new Node { Data = value };
            if (Last == null) //İf My List İs Empty,First Element İs Root(Head)
            {
                Last = Add;
                Add.Next = Last;
                Size++;
            }
            else
            {
                Add.Next = Last.Next;
                Last.Next = Add;             //BigO(1);
                Size++;                      
            }
        }//Passed

        public override StringBuilder Traverse()
        {
            StringBuilder Elements = new StringBuilder();
            Node Temp = Last.Next; //Temp==Head Because Last.Next==Head
            while (Temp!= Last)
            {
                Elements.Append(Temp.Data + "-->");
                Temp = Temp.Next;
            }
            Elements.Append(Temp.Data);
            return Elements;
        } //Passed

        public override void AddPosition(int position, int value)
        {
            Node Add = new Node() { Data = value };
            if (Size >= position && position > 0)
            {
                Node Before = GetNode(position - 1);
                Add.Next = Before.Next;
                Before.Next = Add;
                Size++;
            }
            else if (position == 0)
                AddFirst(value);
            else
                throw new Exception("Geçersiz Pozisyon");
        }//Passed

        public override Node GetNode(int position)
        {
            if (Size >= position && position >= 0)
            {
                Node TempReturn = Last.Next;
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
                Last.Next = Last.Next.Next;
                Size--;
            }
            else
                return;
        }//Passed
        public override void DeletePosition(int position)
        {
            if (position >= 1)
            {
              Node Before = GetNode(position - 1);
              Before.Next = Before.Next.Next;
              Before = null;
              Size--;
            }
            else if (position == 0)
            {
                Last.Next = Last.Next.Next;
                Size--;
            }
            else
                return;
                
        }//Passed

        public override void DeleteLast()
        {
            Node LastPrev = GetNode(Size - 1);
            LastPrev.Next = LastPrev.Next.Next;
            Last = LastPrev;
            Size--;

        }//Passed
        public override void AddLast(int value)
        {
            Node Add = new Node { Data = value};
            Add.Next = Last.Next;
            Last.Next = Add;
            Last = Add;
            Size++;
        }//Passed
    }
}

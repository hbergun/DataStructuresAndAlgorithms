using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircluarLinkedList
{
    public abstract class CircluarLinkedListADT
    {
        public Node Last;
        private int size = -1;

        public int Size 
        {
            get
            {
                return size;
            }

            set
            {
                if (value <= 0)
                    size = 0;
                else
                    size = value;
            }
        }
        public abstract void AddFirst(int value);
        public abstract void AddLast(int value);
        public abstract void AddPosition(int position, int value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePosition(int position);
        public abstract Node GetNode(int position);

        public abstract StringBuilder Traverse();
    }
}

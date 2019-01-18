using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithArray
{
    public class Stack : IStack
    {
        private int[] StackArray;
        public Stack(int StackSize)
        {
            this.StackArray = new int[StackSize];
        }
        private int top = -1;
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public int Peek()
        {
            return StackArray[Top];
        }

        /// <summary>
        /// This Method is Used To Pull From The Stack
        /// </summary>
        /// <returns></returns>
        public int Pull()
        {
            if (IsEmpty() == false)
            {
                int TopValue = StackArray[Top];
                StackArray[Top--] = 0;
                return TopValue;
            }
            else
                 throw new Exception("Stack Is Empty : Exception (DownFlow)");
        }
        /// <summary>
        /// This Method is Used To Add Value To The Stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            if (StackArray.Length != Top + 1)
                StackArray[++Top] = value;
            else
                throw new Exception("Stack Is Full : Exception (OverFlow) ");
        }
    }
}

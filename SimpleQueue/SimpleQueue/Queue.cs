using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue
{
    public class Queue<T> : IQueue<T>
    {
        private int size;
        private int front;
        private int rear;
        private int count;
        public T[] QueueArray { get; set; }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Queue(int size) //Ctor
        {
            this.QueueArray = new T[size];
            this.size = size;
            front = 0;
            rear = -1;
            count = 0;
        }

        public T dequeue()
        {
            if (IsEmpty())
                throw new Exception("Queue Downflow");
            T Temp = QueueArray[front];
            QueueArray[front++] = default(T);
            count--;
            return Temp;
        }

        public void enqueue(T value)
        {
            if (count == size || rear == size - 1 )
            {
                throw new Exception("Queue Dolu");
            }
            QueueArray[++rear] = value;
            count++;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            return QueueArray[rear];
        }
    }
}

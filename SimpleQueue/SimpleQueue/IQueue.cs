using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue
{
    public interface IQueue<T>
    {
        void enqueue(T value);
        T dequeue();
        T Peek();
        bool IsEmpty();

    }
}

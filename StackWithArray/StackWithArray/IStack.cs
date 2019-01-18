using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackWithArray
{
    public interface IStack
    {
        void Push(int value);
        int Pull();
        int Peek();
        bool IsEmpty();
        int Top { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApplication
{
    internal class GenericNode<T>
    {
        public T Data { get; set; }
        public int Count { get; set; }
        public GenericNode<T> Next { get; set; }

        public GenericNode(T data)
        {
            Data = data;
            Count = 1;
            Next = null;
        }
    }
}
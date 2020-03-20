using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public int index;
        public Node( T data)
        {
            this.Data = data;
        }
        
    }
}

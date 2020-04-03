using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public T Value { get; private set; }
        public BinaryTreeNode(T value)
        {
            if (value != null)
            {
                Value = value;
            }
            else throw  new ArgumentNullException("Incorrect data");
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProject
{
    public class BinaryTree<T> : IEnumerable<T>
     where T : IComparable
    {
        private BinaryTreeNode<T> _head;
        private int _count;

        delegate void AddNewNode(string message);
        event AddNewNode Notify;
        public void Add(T value)
        {
            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(_head, value);
            }
            Notify?.Invoke($"Add new node with value: {value}");
            _count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }
        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            BinaryTreeNode<T> current = _head;
            parent = null;

            while (current != null)
            {
                int result = current.Value.CompareTo(value);

                if (result > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }
            return current;
        }

        public bool Remove(T value)
        {
            BinaryTreeNode<T> current, parent;

            current = FindWithParent(value, out parent);

            if (current == null)
            {
                return false;
            }

            _count--;

            if (current.Right == null)
            {
                if (parent == null)
                {
                    _head = current.Left;
                }
                int result1 = parent.Value.CompareTo(current.Value);
                if (result1 > 0)
                {
                    parent.Left = current.Left;
                }
                if (result1 < 0)
                {
                    parent.Right = current.Left;
                }
                return true;
            }

            if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;
                if (parent == null)
                {
                    _head = current.Right;
                    return true;
                }
                int result2 = parent.Value.CompareTo(current.Value);
                if (result2 > 0)
                {
                    parent.Left = current.Right;
                }
                if (result2 < 0)
                {
                    parent.Right = current.Right;
                }
                return true;
            }


            BinaryTreeNode<T> leftmost = current.Right.Left;
            BinaryTreeNode<T> leftmostParent = current.Right;
            while (leftmost.Left != null)
            {
                leftmostParent = leftmost;
                leftmost = leftmost.Left;
            }
            leftmostParent.Left = leftmost.Right;
            leftmost.Left = current.Left;
            leftmost.Right = current.Right;
            if (parent == null)
            {
                _head = leftmost;
                return true;
            }
            int result = parent.Value.CompareTo(current.Value);
            if (result > 0)
            {
                parent.Left = leftmost;
            }
            if (result < 0)
            {
                parent.Right = leftmost;
            }
            Notify?.Invoke($"Devete node with value: {value}");
            return true;
        }

        //Inorder(Left, root, right) 
        public IEnumerator<T> InOrderTraversal()
        {
            if (_head != null)
            {
                //stack - last in first out
                Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();

                BinaryTreeNode<T> current = _head;

                bool goLeftNext = true;

                stack.Push(current);

                while (stack.Count > 0)
                {
                    if (goLeftNext)
                    {
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }

                    yield return current.Value;

                    if (current.Right != null)
                    {
                        current = current.Right;

                        goLeftNext = true;
                    }
                    else
                    {
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Clear()
        {
            _head = null;
            _count = 0;
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
    }
}

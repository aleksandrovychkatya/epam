using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MyArray<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        public int startIndex;
        public int endIndex;
        public int count;

        public MyArray(int start, int end)
        {
            if (end > start)
            {
                startIndex = start;
                endIndex = end;
            }
            else throw new IndexOutOfRangeException("Неправильные индексы");
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            int tempIndex = startIndex;
            if (tempIndex + count <= endIndex)
            {
                node.index = tempIndex + count;
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    tail.Next = node;
                }
                tail = node;

                count++;
            }
            else throw new IndexOutOfRangeException();

        }
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    count--;
                    if (current.index < endIndex)
                    {
                        while (current != null)
                        {
                            current.index -= 1;
                            current = current.Next;
                        }
                    }
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public T this[int indexValue]
        {
            get
            {
                if (indexValue >= startIndex && indexValue <= endIndex)
                {
                    Node<T> current = head;
                    while (current != null)
                    {
                        if (current.index == indexValue)
                        {
                            return current.Data;
                        }
                        current = current.Next;
                    }
                    throw new ArgumentNullException();
                }
                else throw new IndexOutOfRangeException("Неверный индекс");
            }
            set
            {
                if (indexValue >= startIndex && indexValue <= endIndex)
                {
                    Node<T> current = head;
                    while (current != null)
                    {
                        if (current.index == indexValue)
                        {
                            current.Data = value;
                            return;
                        }
                        current = current.Next;
                    }
                    throw new ArgumentNullException();
                }
                else throw new IndexOutOfRangeException();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApplication
{
    internal class DLList<T>
    {
        public GenericNode<T> Head { get; set; }
        public GenericNode<T> Tail { get; set; }

        public DLList()
        {
            Head = null;
            Tail = null;
        }

        public void InsertLast(T data)
        {
            GenericNode<T> newNode = new GenericNode<T>(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public GenericNode<T> GetNodePosition(T data)
        {
            GenericNode<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void IncreaseCount(GenericNode<T> node)
        {
            node.Count++;
        }

        public void Traverse(int totalCharCount)
        {
            GenericNode<T> current = Head;
            while (current != null)
            {
                Console.WriteLine($"{current.Data} : {current.Count} : {Math.Round((double)current.Count / totalCharCount * 100, 2)}%");
                current = current.Next;
            }
        }

        public void SortByVAlAsc()
        {
            GenericNode<T> current = Head;
            GenericNode<T> index = null;
            T tempData;
            int tempCount;

            if (Head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.Next;

                    while (index != null)
                    {
                        if (Comparer<T>.Default.Compare(current.Data, index.Data) > 0)
                        {
                            tempData = current.Data;
                            tempCount = current.Count;
                            current.Data = index.Data;
                            current.Count = index.Count;
                            index.Data = tempData;
                            index.Count = tempCount;
                        }
                        index = index.Next;
                    }
                    current = current.Next;
                }
            }
        }

        public void SortByFrequencyDesc()
        {
            GenericNode<T> current = Head;
            GenericNode<T> index = null;
            T tempData;
            int tempCount;

            if (Head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.Next;

                    while (index != null)
                    {
                        if (current.Count < index.Count)
                        {
                            tempData = current.Data;
                            tempCount = current.Count;
                            current.Data = index.Data;
                            current.Count = index.Count;
                            index.Data = tempData;
                            index.Count = tempCount;
                        }
                        index = index.Next;
                    }
                    current = current.Next;
                }
            }
        }
    }
}

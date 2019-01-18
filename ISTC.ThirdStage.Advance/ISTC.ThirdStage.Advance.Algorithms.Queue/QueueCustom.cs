using System;
using System.Collections.Generic;
using System.Linq;

namespace ISTC.ThirdStage.Advance.Algorithms.Queue
{
    public class QueueCustom<T>
    {
        private static readonly Node<T> HeadNode = new Node<T>(default(T));

        private readonly Node<T> _head;
        private Node<T> _tail;

        public QueueCustom()
        {
            _head = HeadNode;
            _tail = _head;
        }

        public int Count { get; private set; }

        public void Enqueue(T value)
        {
            _tail = _tail.Add(value);
            Count++;
        }

        public T Dequeue()
        {
            Count--;
            return _head.Remove();
        }

        public override string ToString()
        {
            return string.Join(" ", GetValues().Select(v => v.ToString()));
        }

        private IEnumerable<T> GetValues()
        {
            var current = _head.Next;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        #region Node

        private class Node<TNode>
        {
            public Node(T value)
            {
                Value = value;
            }
            public T Value { get; }
            public Node<T> Next { get; private set; }

            public Node<T> Add(T value)
            {
                Next = new Node<T>(value);
                return Next;
            }

            public T Remove()
            {
                if (Next == null)
                {
                    throw new InvalidOperationException();
                }
                var ret = Next.Value;
                Next = Next.Next;
                return ret;
            }
        }

        #endregion
    }
}

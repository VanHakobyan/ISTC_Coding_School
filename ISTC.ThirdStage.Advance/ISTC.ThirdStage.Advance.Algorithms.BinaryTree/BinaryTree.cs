using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.ThirdStage.Advance.Algorithms.BinaryTree
{
    public class BinaryTree
    {
        public BinaryTree()
        {
            Count = 0;
            Root = null;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public void Insert(int value)
        {
            if (IsEmpty())
            {
                Root = new Node(value);
            }
            else
            {
                Root.Insert(Root, value);
            }

            ++Count;
        }

        public Node FindByValue(int value)
        {
            return Root.FindByValue(Root, value);
        }

        public bool IsExists(int value)
        {
            return Root.IsExists(Root, value);
        }

        public override string ToString()
        {
            return Root.ToString(Root);
        }

        public Node Root { get; set; }
        public int Count { get; private set; }
    }

    public class Node
    {
        public Node(int rootValue)
        {
            Value = rootValue;
        }

        public int Value { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }

        public void Insert(Node rootNode, int value)
        {
            if (value < rootNode.Value)
            {
                if (rootNode.Left == null)
                {
                    rootNode.Left = new Node(value);
                }
                else
                {
                    Insert(Left, value);
                }
            }
            else if (value > Value)
            {
                if (rootNode.Right == null)
                {
                    rootNode.Right = new Node(value);
                }
                else
                {
                    Insert(Right, value);
                }
            }

        }

        public bool IsExists(Node rootNode, int value)
        {
            return FindByValue(rootNode, value) != null;
        }

        public bool IsLeaf()
        {
            return (Left == null) && (Right == null);
        }

        public Node FindByValue(Node rootNode, int value)
        {
            if (rootNode == null) return null;
            if (rootNode.Value == value) return rootNode;

            if (value < rootNode.Value)
            {
                return FindByValue(rootNode.Left, value);
            }

            if (value > rootNode.Value)
            {
                return FindByValue(rootNode.Right, value);
            }

            return null;
        }

        public string ToString(Node rootNode)
        {
            if (rootNode == null) return string.Empty;

            return ToString(rootNode.Left) + " " + rootNode.Value + ToString(rootNode.Right);
        }
    }

}

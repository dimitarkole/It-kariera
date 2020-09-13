using System;
using System.Collections.Generic;
using System.Text;

namespace BTree
{
   public class BinaryTree<T> where T : IComparable
    {
        private class Node
        {
            public Node Left { get; set; }

            public Node Right { get; set; }

            public T Item { get; set; }

            public override string ToString()
            {
                var result = this.Item.ToString() + " ";
                if (this.Left != null) result += this.Left.ToString();
                if (this.Right != null) result += this.Right.ToString();
                return result;
            }
        }

        private Node Root { get; set; }

        public int Count { get; private set; }
        
        public bool Contains(T item)
        {
            if (Root == null)
            {
                return false;
            }

            Node iterator = Root;
            while (true)
            {
                if (iterator == null)
                {
                    return false;
                }
                else if (iterator.Item.CompareTo(item) == 0)
                {
                    return true;
                }
                else if (iterator.Item.CompareTo(item) > 0)
                    iterator = iterator.Left;
                else if (iterator.Item.CompareTo(item) < 0)
                    iterator = iterator.Right;
            }
        }

        public void Add(T item)
        {
            Node node = new Node();
            node.Item = item;

            if (Root == null)
            {
                Root = node;
                return;
            }

            Node iterator = Root;
            while (true)
            {
                if (iterator.Left != null && iterator.Item.CompareTo(item) >= 0)
                    iterator = iterator.Left;
                else if (iterator.Right != null && iterator.Item.CompareTo(item) < 0)
                    iterator = iterator.Right;
                else
                    break;
            }

            if (iterator.Item.CompareTo(item) >= 0)
                iterator.Left = node;
            else if (iterator.Item.CompareTo(item) < 0)
                iterator.Right = node;
        }

        public void Remove(T item)
        {
            if (this.Contains(item) == false) return;

            Node iterator = Root;
            while (true)
            {
                if (iterator == null)
                {
                    return;
                }
                else if (iterator.Item.CompareTo(item) == 0)
                {
                    // TODO: business logic here
                    var element = iterator;
                    if(element.Right!= null)
                    {
                        while (element.Left != null)
                        {
                            element = element.Left;
                        }
                        iterator.Item = element.Item;
                        element.Left = null;
                    }
                    else if(element.Left != null)
                    {
                        iterator.Item = element.Left.Item;
                        iterator.Left = null;
                    }
                    else
                    {
                        iterator = null;
                    }
                    return;
                }
                else if (iterator.Item.CompareTo(item) > 0)
                    iterator = iterator.Left;
                else if (iterator.Item.CompareTo(item) < 0)
                    iterator = iterator.Right;
            }
        }

        public override string ToString()
        {
            return this.Root.ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08062019
{
    class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(object element, Node prevNode)
            {
                this.Element = element;
                prevNode.Next = this;
            }

            public Node(object element)
            {
                this.Element = element;
                Next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
        {
            Node current = new Node(item);
            if (head == null)
            {
                head = current;
                tail = current;
                count++;
            }
            else
            {
                tail.Next = current;
                tail = current;
                count++;
            }

        }

        
        public object Remove(int index)
        {
            int i = 0;
            Node current = head;
            Node previos = null;
            while (current != null)
            {
                if (i != index)
                {
                    previos = current;
                    current = current.Next;
                    i++;
                }
                else
                {
                    previos.Next = current.Next;
                    //current = previos;
                    count--;
                    return current;
                }
            }
            return -1;

        }

      


        public int Remove(object item)
        {
            Node current = head;
            Node previos = null;
            while (current != null)
            {
                if (current.Element == item)
                {
                    previos.Next = current.Next;
                    current = previos;
                    count--;
                    return 1;

                }
                else
                {
                    previos = current;
                    current = current.Next;
                }
            }
            return -1;
        }

        public int IndexOf(object item)
        {
            int i = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Element == item)
                {
                    return i;
                }
                current = current.Next;
                i++;
            }
            return -1;

        }


        public bool Contains(object item)
        {
            if (this.IndexOf(item) == -1) return false;
            else return true;
        }

        public object this[int index]
        {
            get
            {
                int i = 0;
                Node current = head;
                while (current != null)
                {
                    if (i == index)
                    {
                        return current.Element;
                    }
                    current = current.Next;
                    i++;

                }
                return -1;
            }
            set
            {
                int i = 0;
                Node current = head;
                while (current != null)
                {
                    if (i == index)
                    {
                        current.Element = value;
                    }
                    current = current.Next;


                }
                throw new IndexOutOfRangeException();
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

    }
}

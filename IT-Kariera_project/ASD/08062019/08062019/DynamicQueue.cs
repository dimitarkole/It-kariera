using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08062019
{
    class DynamicQueue<T>
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


    }
}

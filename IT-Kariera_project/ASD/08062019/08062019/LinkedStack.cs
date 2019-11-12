using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08062019
{
    class LinkedStack<T>
    {
        private class Node<T>
        {
            private T value;
            public Node<T> nextNode;

            public Node<T> NextNode { get => this.nextNode; set => this.nextNode = value; }
            public T Value { get => value; set => this.value = value; }

            public Node(T value, Node<T> nextNode = null) {
                this.Value = value;
                this.NextNode = nextNode;
            }
        }

        private Node<T> firstNode;

        public LinkedStack()
        {
            this.firstNode = null;
            this.Count = 0;
        }

        public int Count { get; private set; }
        public void Push(T element) {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;

        }

        public T Pop()
        {
            if(this.Count==0) throw new InvalidOperationException("Stack empty");
            T element = this.firstNode.Value;
            this.firstNode = this.firstNode.nextNode;
            this.Count--;

            return element;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];
            var value = this.firstNode;
            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = value.Value;
                value = value.NextNode;
            }
            return arr;
        }

    }
}

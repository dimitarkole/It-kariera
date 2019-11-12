using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08062019
{
    class LinkedQueue<T>
    {
        private class QueueNode<T>
        {
            private T value;
            private QueueNode<T> prevNode;
            private QueueNode<T> nextNode;

            public T Value { get => value;private set => this.value = value; }
            public QueueNode<T> NextNode { get => nextNode; set => nextNode = value; }
            public QueueNode<T> PrevNode { get => prevNode; set => prevNode = value; }

            public QueueNode(T value)
            {
                this.Value = value;
            }
        }
        
        public int Count { get; private set; }
        private QueueNode<T> head;
        private QueueNode<T> teil;

        public LinkedQueue()
        {
            this.Count = 0;
        }
        public void Enqueue(T element) {
            if (this.Count == 0)
            {
                this.head = this.teil = new QueueNode<T>(element);
            }
            else
            {
                var newHead = new QueueNode<T>(element);
                newHead.NextNode = this.head;
                this.head.PrevNode = newHead;
                this.head = newHead;
            }
            this.Count++;

        }

        public T Dequeue() {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue empty");
            }
            var element = this.teil.Value;
            if (this.teil.PrevNode == null)
            {
                this.head= this.teil = null;
            }
            else
            {
                this.teil = this.teil.PrevNode;
            }
            this.Count--;
            return element;
        }

        public T[] ToArray() {
            T[] arr = new T[this.Count];
            var value = this.head;
            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = value.Value;
                value = value.NextNode;
            }
            return arr;

        }

    }
}

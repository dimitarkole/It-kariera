using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08062019
{
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        private class ListNode<T>
        {          

            public T Value { get; private set; }
            public ListNode<T> NextNode { get; set; }
            public ListNode<T> PrevNode { get; set; }

            public ListNode(T value)
            {
                Value = value;
            }
        }

        private ListNode<T> head;
        private ListNode<T> teil;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if(this.Count==0)
            {
                this.head = this.teil = new ListNode<T>(element);
            }
            else
            {
                var newHead = new ListNode<T>(element);
                newHead.NextNode = this.head;
                this.head.PrevNode=newHead;
                this.head = newHead;
            }
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.head;
            while(currentNode!=null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.teil = new ListNode<T>(element);
            }
            else
            {
                var newHead = new ListNode<T>(element);
                newHead.PrevNode = this.head;
                this.head.NextNode = newHead;
                this.head = newHead;
            }
        }

        public T RemoveFirst(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }

            var firstElement = this.head.Value;
            this.head = this.head.NextNode;
            if(this.head!=null)
            {
                this.head.PrevNode = null;
            }
            else
            {
                this.teil = null;
            }
            this.Count--;
            return firstElement;
        }

        public T RemoveLast(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }

            var lastElement = this.teil.Value;
            this.teil = this.teil.PrevNode;
            if (this.head != null)
            {
                this.teil.PrevNode = null;
            }
            else
            {
                this.head = null;
            }
            this.Count--;
            return lastElement;
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];
            int position = 0;
            var element = this.head;
            while(element!=null)
            {
                arr[position] = element.Value;
                element = element.NextNode;
            }
            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;
            while(currentNode!=null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        
    }
}

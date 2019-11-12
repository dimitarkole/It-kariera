using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08062019
{
    class CircularQueue<T>
    {
        private T[] elements;
        private int endIndex;
        private int startIndex;
        private const int DefaultCapacity = 4;
        public int Count { get; private set; }

        public CircularQueue(int capacity = DefaultCapacity) {
            this.elements = new T[capacity];
            this.startIndex = -1;
            this.endIndex = 0;
            this.Count = 0;
        }

        public CircularQueue()
        {
            this.elements = new T[16];
            this.startIndex = -1;
            this.endIndex = 0;
            this.Count = 0;
        }

        public void Enqueue(T element)
        {
            if(this.Count>=this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        private void Grow()
        {
            var newElements = new T[2 * this.Count];
            this.CopyAllElements(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private void CopyAllElements(T[] resultArr)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                resultArr[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
        }

        public T Dequeue() {
            if (this.Count == 0) throw new InvalidOperationException("The queue is empty!");
            var result = this.elements[startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            this.Count--;
            return result;
        }

        public T Peek()
        {
            if (this.Count == 0) throw new InvalidOperationException("The queue is empty!");
            var result = this.elements[startIndex];
            return result;
        }

        public T[] ToArray() {
            var resultArr = new T[this.Count];
            CopyAllElements(resultArr);
            return resultArr;
        }


        public void Clear()
        {
            this.elements = new T[DefaultCapacity];
            this.startIndex = -1;
            this.endIndex = 0;
            this.Count = 0;
        }

        private bool Contains(T element)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[destinationIndex].Equals(element)) return true;
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08062019
{
    class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        public T[] Elements { get => elements; set => elements = value; }

        private const int InitialCapacity = 16;
        public ArrayStack(int capacity = InitialCapacity) {
            this.Elements = new T[capacity];
            this.Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count) throw new ArgumentOutOfRangeException();
                return elements[index];
            }
            set
            {
                if (index >= this.Count) throw new ArgumentOutOfRangeException();
                elements[index] = value;
            }
        }

        public void Push(T element) {
            if (this.Count >= this.Elements.Length)
            {
                this.Grow();
            }
            this.Elements[this.Count++] = element;

        }

        private void Grow() {
            T[] copy = new T[this.Elements.Length * 2];
            for (int i = 0; i < this.Elements.Length; i++)
            {
                copy[i] = Elements[i];
            }
            this.Elements = copy;
        }


        public T Pop() {
            T element = this.Elements[this.Count--];
            this.Elements[this.Count] = default(T);
            if (this.Count <= this.Elements.Length / 4)
            {
                this.Shrink();
            }
            return element;
        }

        private void Shrink()
        {
            T[] copy = new T[this.Elements.Length / 2];
            for (int i = 0; i < this.Elements.Length; i++)
            {
                copy[i] = Elements[i];
            }
            this.Elements = copy;
        }

        public T[] ToArray() {
            return this.Elements;
        }

    }
}

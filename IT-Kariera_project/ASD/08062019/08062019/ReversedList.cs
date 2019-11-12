using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _08062019
{
    class ReversedList<T> : IEnumerable<T>
    {
        private const int initionalCapacity = 2;
        private T[] items;

        public ReversedList(int capacity= initionalCapacity)
        {
            this.items = new T[capacity];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count) throw new ArgumentOutOfRangeException();
                return items[index];
            }
            set
            {
                if (index >= this.Count) throw new ArgumentOutOfRangeException();
                items[this.Count -1- index] = value;


            }
        }


        public int Capacity()
        {
            return items.Length;
        }

        public void Add(T item)
        {
            if (this.Count >= this.items.Length)
            {
                this.Grow();
            }
            this.items[this.Count++] = item;
        }

        private void Grow()
        {
            var copy = new T[2 * this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public T RemoveAt(int index)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }
            T element = items[(this.Count--) - index];
            this.Shift(index);

            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            return element;
        }

        private void Shift(int index)
        {
            for (int i = this.Count-index-1; i < this.Count; i++)
            {
                this.items[this.Count - index] = this.items[this.Count - index+ 1];
            }
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = items[i];
            }
            this.items = copy;
        }





        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.items)
            {
                yield return item;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            string result="";
            for (int i = 0; i < this.Count; i++)
            {
               result += " " + this.items[this.Count - 1- i];
            }
            return result;
        }
    }
}

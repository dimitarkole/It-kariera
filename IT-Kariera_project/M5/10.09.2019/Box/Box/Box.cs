using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            Data = new List<T>();
        }

        public List<T> Data
        {
            get { return data; }
            set { data = value; }
        }

        public int Count => this.data.Count;

        public void Add(T item)
        {
            this.Data.Add(item);
        }

        public T Remove()
        {
            var rem = this.Data[this.Count - 1];
            this.Data.RemoveAt(this.Count - 1);
            return rem;
        }

        public override string ToString()
        {

            return $"{Data.GetType().FullName}: {string.Join("",Data)} ";
        }
    }
}

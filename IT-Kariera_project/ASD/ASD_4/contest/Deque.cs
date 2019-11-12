using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contest
{
    public class Deque<T> where T: Train
    {
        private Stack<T> passagerTrain;
        private Stack<T> freightTrain;
        private Stack<T> history;
        private const int defaultCapacity = 16;

        public Deque() : this(defaultCapacity) { }

        public Deque(int capacity)
        {
            this.passagerTrain = new Stack<T>(capacity);
            this.freightTrain = new Stack<T>(capacity);
            this.history = new Stack<T>();
        }
        public Deque(IEnumerable<T> collection)
             : this(collection.Count())
        {
            //създава дека с капацитет съответстващ на посочената колекция 
            //и прехвърля елементите от колекцията в дека\
            foreach (var item in collection)
            {
                if(item is Train)
                {
                    Train train =(Train) Convert.ChangeType(item, typeof(Train));
                    if(train.Type=="P")
                    {
                        passagerTrain.Push(item);
                    }
                    else
                    {
                        freightTrain.Push(item);
                    }

                }
            }
        }
        public int Capacity; //показва капацитета
        public int Count; //показва броят елементи

        public void AddFront(T item)
        {
            this.passagerTrain.Push(item);
            //добавя елемент отпред
            this.Count++;
        }

        public void AddBack(T item)
        {
            //добавя елемент отзад
            this.freightTrain.Push(item);
            this.Count++;

        }
        public T RemoveFront()
        {
            //връща и премахва елемента отпред          
            if (this.passagerTrain.Count > 0)
            {
                this.Count--;
                this.history.Push(this.passagerTrain.Peek());
                return this.passagerTrain.Pop();
            }
            else return null;
        }

        public T RemoveBack()
        {
            //връща и премахва елемента отзад
            if (this.freightTrain.Count > 0)
            {
                this.Count--;
                this.history.Push(this.freightTrain.Peek());
                return this.freightTrain.Pop();
            }
            else return null;
            
        }
        public T GetFront()
        {
            //връща, без да премахва, елемента отпред
            //връща и премахва елемента отпред          
            if (this.passagerTrain.Count > 0)
            {
                this.Count--;
                return this.passagerTrain.Peek();
            }
            else return null;
        }
        public T GetBack()
        {
            //връща, без да премахва, елемента отзад
            if (this.freightTrain.Count > 0)
            {
                this.Count--;
                return this.freightTrain.Peek();
            }
            else return null;
        }

        public T[] GetHistory()
        {
            return this.history.ToArray();
        }

    }
}

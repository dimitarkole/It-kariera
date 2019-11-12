using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class StackOfStrings
    {
        private List<string> data;

        public List<string> Data { get => data; set => data = value; }

        public void Push(string item)
        {
            this.Data.Add(item);
        }

        public string Pop()
        {
            string item="";
            if (this.IsEmpty()==false)
            {
                int index = this.Data.Count - 1;
                item = this.Data[index];
                this.Data.RemoveAt(index);
            }
            return item;
        }

        public string Peek()
        {
            string item = "";
            if (this.IsEmpty() == false)
            {
                int index = this.Data.Count - 1;
                item = this.Data[index];
            }
            return item;
        }

        public bool IsEmpty()
        {
            if(this.Data.Count==0)return false;
            return true;
        }
    }
}

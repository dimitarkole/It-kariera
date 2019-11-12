using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restourant
{
    class Fridge
    {
        class Product
        {
            private string name;
            private Product next;

            public Product(string name)
            {
                this.Name = name;
                //this.Next = null;
            }

            public string Name { get => name; set => name = value; }
            public Product Next { get => next; set => next = value; }

            public override string ToString()
            {
                return $"Product {this.Name}";
            }

        }

        private Product head;
        private Product tail;
        private int count;

        public int Count { get => count; private set => count = value; }
        private Product Tail { get => tail; set => tail = value; }
        private Product Head { get => head; set => head = value; }

        public Fridge()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public void AddProduct(string ProductName)
        {
            Product current = new Product(ProductName);
            if (Head == null)
            {
                this.Head = current;
                this.Tail = current;
            }
            else
            {
                this.Tail.Next = current;
                this.Tail = current;
            }
            this.Count++;
        }

        public string[] CookMeal(int start, int end)
        {
            List<string> allProduct = new List<string>();
            Product current = Head;
            int index = 0;
            while (current != null)
            {
                if ((index >= start) && (index < end)) allProduct.Add(current.Name);
                current = current.Next;
                index++;
            }

            return allProduct.ToArray();
        }


        public string RemoveProductByIndex(int index)
        {
            if (this.Count < index) return null;
            return RemoveProductByName("",index);
        }

        public string RemoveProductByName(string name, int index = -1)
        {
            int counterElement = 0;
            if (head.Name == name || counterElement==index)
            {
                name = Head.Name;
                Head = Head.Next;
                this.Count--;
                return name;
            }
            Product current = Head;

            while (current != null)
            {
                if (current.Next.Name == name || counterElement+1 == index)
                {
                    

                    if (current.Next == tail || counterElement == count)
                    {
                        name = tail.Name;
                        tail = current;
                        tail.Next = null;
                    }
                    else
                    {
                        
                        name = current.Next.Name;                        
                        current.Next= current.Next.Next;
                    }
                    count--;
                    Console.WriteLine(string.Join(" ", ProvideInformationAboutAllProducts()));
                    return name;
                }
                current = current.Next;
                counterElement++;                
            }
            return null;
        }

        public bool CheckProductIsInStock(string name)
        {
            Product current = Head;
            Product previos = null;
            while (current != null)
            {
                if (name == current.Name) return true;
                previos = current;
                current = current.Next;
            }
            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            List<string> allProduct = new List<string>();
            Product current = Head;
            while (current != null)
            {
                allProduct.Add(current.ToString());
                current = current.Next;
            }
            
            return allProduct.ToArray();
        }

        
        /*
Add cherry
Add salami
Add eggs
Remove eggs
Print
Add eggs
Print
END
         * 
         * */
    }
}
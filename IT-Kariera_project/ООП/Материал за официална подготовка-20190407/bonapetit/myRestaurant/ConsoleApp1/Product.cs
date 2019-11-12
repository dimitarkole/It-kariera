using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        private string name;
        private double price;
        private int weight;

        public Product(string name, double price, int weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }

        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 3)
                {
                    throw new ArgumentException("...");
                }
                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set {
                if (value<0.01)
                {
                    throw new ArgumentException("...");
                }
                price = value;
            }
        }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("...");
                }
                weight = value;
            }
        }

        public override string ToString()
        {
            string name = this.Name;
            int weight = this.Weight;
            return name+" - "+weight;
        }

        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            Dictionary<string, Product>  ordererdProduct= products
                .OrderBy(x=>x.Value.Price)
                .ToDictionary(x => x.Key, x => x.Value);
            return ordererdProduct.First().Value;
        }





    }
}

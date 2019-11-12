using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entitys.Products
{
    public abstract class Product
    {
        private double price;

        public double Price
        {
            get { return price; }
            set {
                if (value<0) throw new InvalidOperationException("Price cannot be negative!");
                price = value; 
            }
        }

        private double weight;

       
        public double Weight 
        {
            get { return weight; }
            set
            {
                if (value < 0) throw new InvalidOperationException("Price cannot be negative!");
                weight = value;
            }
        }

        public Product(double price, double weight)
        {
            Price = price;
            Weight = weight;
        }

    }
}

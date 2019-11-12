namespace StorageMaster.Entitys.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Product
    {
        protected Product(double price, double weight)
        {
            this.price = price;
            this.Weight = weight;
        }
        private double price;
        public double Price { 
            get=>this.price;
            private set
            {
                if (value < 0) throw new InvalidOperationException("Price cannot be negative!");
                price = value;
            }
        }

        public double Weight { get; set; }
    }
}

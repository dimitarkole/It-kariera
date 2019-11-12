using StorageMaster.Entitys.Products;

namespace StorageMaster.Entitys.Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Vehicle
    {
        private List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.trunk = new List<Product>();
            Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        public bool IsFull => this.trunk.Sum(p => p.Weight) >= this.Capacity;

        public bool IsEmpty => this.trunk.Count == 0;


        public void LoadProduct(Product product)
        {
            if(this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            this.trunk.Add(product);
        }

        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            Product product = this.trunk[this.trunk.Count - 1];
            this.trunk.RemoveAt(this.trunk.Count - 1);
            return product;
        }
    }
}

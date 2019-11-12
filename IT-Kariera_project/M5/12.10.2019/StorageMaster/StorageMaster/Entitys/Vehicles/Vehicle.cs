using StorageMaster.Entitys.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entitys.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private IReadOnlyCollection<Product> trunk ;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.Trunk = new List<Product>();
        }

        public IReadOnlyCollection<Product> Trunk 
        {
            get { return trunk; }
            set { trunk = value; }
        }
        public int MyProperty { get; set; }

        public bool IsFull
        {
            get {

                List<Product> products = new List<Product>(this.Trunk);
                var allWeight = products.Sum(p => p.Weight);
                if (allWeight >= this.Capacity) return true;
                return false;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (this.Trunk.Count == 0) return true;
                return false;
            }
        }

        public void LoadProduct(Product product)
        {
            if(this.IsFull==true)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            var copyTrunk = new List<Product>(this.Trunk);
            copyTrunk.Add(product);
            this.Trunk = copyTrunk;
        }

        public Product Unload()
        {
            if (this.IsEmpty == true)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            var copyTrunk = new List<Product>(this.Trunk);
            var returnElement = copyTrunk[copyTrunk.Count - 1];
            copyTrunk.RemoveAt(copyTrunk.Count - 1);
            this.Trunk = copyTrunk;
            return returnElement;
        }

    }
}

using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StorageMaster.Entities.Storage
{
    public abstract class Storage
    {
        public Vehicle[] garage;

        private List<Product> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.garage = new Vehicle[this.GarageSlots];
            this.FillGarage(vehicles);
            this.products = new List<Product>();
        }

        private void FillGarage(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;
            foreach (var vehicle in vehicles)
            {
                this.garage[index++] = vehicle;
            }
        }

       

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull => 
            this.products.Sum(p=>p.Weight) >= this.Capacity;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(garage);

        public IReadOnlyCollection<Product> Products => products.AsReadOnly();


        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");

            }

            Vehicle vehicle = this.garage[garageSlot];
            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);
            int index= deliveryLocation.AddVehicle(vehicle);
            this.garage[garageSlot]= null;
            return index;
        }


        public int AddVehicle(Vehicle vehicle)
        {
            int index = Array.IndexOf(this.garage, null);
            if(index==-1)
            {
                throw new InvalidOperationException("No room in garage!");

            }
            this.garage[index] = vehicle;
            return index;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            Vehicle vehicle = this.GetVehicle(garageSlot);
            int count = 0;
            while (!vehicle.IsEmpty)
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                count++;
                if (this.IsFull)
                {
                    throw new InvalidOperationException("Storage is full!");
                }
            }
            

            return count;
        }
    }
}

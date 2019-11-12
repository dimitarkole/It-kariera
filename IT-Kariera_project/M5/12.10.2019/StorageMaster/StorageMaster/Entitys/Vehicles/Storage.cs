using StorageMaster.Entitys.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entitys.Vehicles
{
    abstract class Storage
    {
        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = garageSlots;
            Garage = new List<Vehicle>(vehicles);
            Products = new List<Product>();
        }

        public string Name { get; set; }

        public int Capacity  { get; set; }

        public int GarageSlots { get; set; }

        public bool IsFull { 
            get {
                List<Product> products = new List<Product>(this.Products);
                var countSumOfProduct = products.Sum(p=>p.Weight);
                if (countSumOfProduct >= this.Capacity) return true;
                return false;
            }
            set { 

            }
        }

        public IReadOnlyCollection<Vehicle> Garage  { get; set; }

        public IReadOnlyCollection<Product> Products  { get; set; }

        public Vehicle GetVehicle(int garageSlot)
        {
            if(garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            List<Vehicle> garage = new List<Vehicle>(this.GarageSlots);
            if (garage.Count==0)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            var returnVehicle = garage[garageSlot];
            return returnVehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            List<Vehicle> garage = new List<Vehicle>(this.GarageSlots);

            var vehicle = GetVehicle(garageSlot);
            var countEmpyGarageSlots = garage.Count(g => g == null);
            if(countEmpyGarageSlots==0)
            {
                throw new InvalidOperationException("No room in garage!");
            }
            garage[garageSlot] = null;

            List<Vehicle> deliveryGarage = new List<Vehicle>(this.GarageSlots);
            deliveryGarage.Add(vehicle);
            deliveryLocation.Garage = deliveryGarage;
            return deliveryGarage.Count-1;
        }

        public int UnloadVehicle(int garageSlot)
        {
            if (IsFull ==true)
            {
                throw new InvalidOperationException("Storage is full!");
            }
            var vehicle = GetVehicle(garageSlot);
            int count=0;
            while ((IsFull==false)||(vehicle.IsEmpty==false))
            {
                var product = vehicle.Unload();
                List<Product> products = new List<Product>(this.Products);
                products.Add(product);
                count++;
            }
            return count;
        }
    }
}

using StorageMaster.Entities.Products;
using global::StorageMaster.Entities.Storage;
using global::StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StorageMaster
{
   

    public class StorageMaster
    {
        private Dictionary<string, Stack<Product>> products;
        private Dictionary<string, Storage> storages;
        private Vehicle currentVehicle;


        public StorageMaster()
        {
            this.products = new Dictionary<string, Stack<Product>>();
            this.storages = new Dictionary<string, Storage>();
        }

        public string AddProduct(string type, double price)
        {
            Product product = CreareProduct(type, price);
            if(this.products.ContainsKey(type)==false)
            {
                this.products.Add(type, new Stack<Product>());
            }

            this.products[type].Push(product);
            string result= $"Added {type} to pool";
            return result;
        }

      

        public string RegisterStorage(string type, string name)
        {
            Storage storage = CreareStorage(type, name);
            this.storages.Add(name, storage);
            string result = $"Registered {name}";
            return result;
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {

            Storage storage = this.storages[storageName];
            Vehicle vehicle = storage.GetVehicle(garageSlot);
            this.currentVehicle = vehicle;
            string result =  $"Selected { currentVehicle.GetType().Name}";
            return result;
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            int loadedProductsCount = 0;
            foreach (var productName in productNames)
            {
                if((this.products.ContainsKey(productName))
                    && (this.products[productName].Count > 0))
                {
                    Product product = this.products[productName].Pop();
                    this.currentVehicle.LoadProduct(product);
                    loadedProductsCount++;
                }
                else
                {
                    throw new InvalidOperationException($"{productName} is out of stock!");
                }
            }
            int productCount = productNames.Count();
            string vehicleType = currentVehicle.GetType().Name;
            string result = $"Loaded {loadedProductsCount}/{productCount} products into {vehicleType}";
            return result;
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (this.storages.ContainsKey(sourceName) ==false)
            {
                throw new InvalidOperationException($"Invalid source storage!");
            }

            if (this.storages.ContainsKey(destinationName) == false)
            {
                throw new InvalidOperationException($"Invalid destination storage!");
            }


            Storage sourceStorage = this.storages[sourceName];
            Storage destinateStorage = this.storages[destinationName];
            int destinationGarageSlot=sourceStorage.SendVehicleTo(sourceGarageSlot, destinateStorage);
            string vehicleType = currentVehicle.GetType().Name;

            string result = $"Sent {vehicleType} to {destinationName} (slot {destinationGarageSlot})";
            return result;
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            Vehicle vehicle = storage.GetVehicle(garageSlot);
            int productsInVehicle = vehicle.Trunk.Count();
            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);
            string result = $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
            return result;
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storages[storageName];
            Dictionary<string, int> productCounts = new Dictionary<string, int>();
            foreach (Product product in storage.Products)
            {
                string type = product.GetType().Name;
                if (productCounts.ContainsKey(type) == false)
                {
                    productCounts.Add(type, 0);
                }
                productCounts[type]++;

            }
            string[] sortedProduct = productCounts
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key)
                .ToDictionary(x => x.Key, x => x.Value)
                .Select(s => $"{s.Key} ({s.Value})")
                .ToArray();

            double productWeight = storage.Products.Sum(p => p.Weight);
            string stockLine = $"Stock({ productCounts}/" +
                $"{storage.Capacity}): [{string.Join(", ", sortedProduct)}]";

            string[] garageNames = storage.garage
                .Select(g => g==null? "empty" :g.GetType().Name)
                .ToArray();
            string garageLine = $"Garage: [{string.Join("|", garageNames)}]";
            string result = stockLine + Environment.NewLine + garageLine;
            return result;
        }

        public string GetSummary()
        {
            var sortedStorage = this.storages
                .OrderByDescending(s=> s.Value.Products.Sum(p=>p.Price))
                .ToDictionary(x=> x.Key, x=> x.Value);
            StringBuilder sb = new StringBuilder();
            foreach (var storage in sortedStorage)
            {
                sb.AppendLine($"{storage.Key}");
                double totalProce = storage.Value.Products.Sum(p => p.Price);
                sb.AppendLine($"Storage worth: ${string.Format("{0:0.00}",totalProce)}");
            }

            string result = sb.ToString().Trim();
            return result;
        }


        private Product CreareProduct(string type, double price)
        {
            Product product = null;
            switch (type)
            {
                case "Ram":
                    product = new Ram(price);
                    break;
                case "Gpu":
                    product = new Gpu(price);
                    break;
                case "HardDrive":
                    product = new HardDrive(price);
                    break;                
                case "SolidStateDrive":
                    product = new SolidStateDrive(price);
                    break;
                default:
                    throw new InvalidOperationException("Invalid product type!");
            }
            return product;
        }
        private Storage CreareStorage(string type, String name)
        {
            Storage storage = null;
            switch (type)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;
                case "DistributionCenter":
                    storage = new DistributionCenter(name);
                    break;
                case "Warehouse":
                    storage = new Warehouse(name);
                    break;
                default:
                    throw new InvalidOperationException("Invalid storage type!");
            }
            return storage;
        }
    }

}

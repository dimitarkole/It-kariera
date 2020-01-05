using StorageMaster.Core.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class Engine
    {
        private StorageMaster storage;

        private bool isRuning;

        private StringBuilder outputs;

        public Engine()//IReader reader, IWriter writer)
        {
            this.storage = new StorageMaster();
            outputs = new StringBuilder();
        }

        public void Run()
        {
            this.isRuning = true;
            while(isRuning==true)
            {
                try
                {
                    string line = Console.ReadLine();
                    string result = this.PocessCommand(line);
                    Console.WriteLine(result);
                    outputs.AppendLine(result);
                }
                catch (InvalidOperationException e)
                {
                    string result = $"Error: {e.Message}";
                    outputs.AppendLine(result);
                }
            }
            Console.Clear();
            Console.WriteLine(outputs.ToString().Trim());

        }

        private string PocessCommand(string line)
        {
            string[] tokens = line.Split();
            string command = tokens[0];
            string output = "";
            string storageName;
            int garageSlote;
            switch (command)
            {
                case "AddProduct":
                    string productName = tokens[1];
                    double price = double.Parse(tokens[2]);
                    output=this.storage.AddProduct(productName, price);
                    break;
                case "RegisterStorage":
                    string storageType = tokens[1];
                    string name = tokens[2];
                    output = this.storage.RegisterStorage(storageType, name);
                    break;
                case "SelectVehicle":
                    storageName = tokens[1];
                    garageSlote = int.Parse(tokens[2]);
                    output = this.storage.SelectVehicle(storageName, garageSlote);
                    break;
                case "LoadVehicle":
                    string[] products = tokens.Skip(1).ToArray();
                    output = this.storage.LoadVehicle(products);
                    break;
                case "SendVehicleTo":
                    string sourceName = tokens[1];
                    int sourceGarageSlote = int.Parse(tokens[2]);
                    string destinationName = tokens[3];

                    output = this.storage.SendVehicleTo(sourceName, sourceGarageSlote, destinationName);
                    break;
                case "UnloadVehicle":
                    storageName = tokens[1];
                    garageSlote = int.Parse(tokens[2]);
                    output = this.storage.UnloadVehicle(storageName, garageSlote);
                    break;
                case "GetStorageStatus":
                    storageName = tokens[1];
                    output = this.storage.GetStorageStatus(storageName);
                    break;
                case "END":
                    this.isRuning = false;
                    output = storage.GetSummary();
                    break;
                default:break;
            }
            return output;

        }
    }
}

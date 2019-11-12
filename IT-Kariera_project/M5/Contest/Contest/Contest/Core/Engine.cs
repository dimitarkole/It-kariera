using CryptoMiningSystem.Core.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptoMiningSystem.Core
{
    public class Engine
    {
        private SystemManager manager;

        public Engine(IReader reader, IWriter writer)
        {
            this.manager = new SystemManager();
        }

        public void Run()
        {
            List<string> commandArgs = Console.ReadLine()
                   .Split(' ')
                   .ToList();
            while (commandArgs[0] != "Shutdown")
            {
                List<string> args = commandArgs.Skip(1).ToList();
                switch (commandArgs[0])
                {
                    case "RegisterMiner":
                        //manager.RegisterMiner(args);
                        break;
                    case "RegisterProvider":
                       // manager.RegisterProvider(args);
                        break;
                    case "Day":
                       // manager.Day();
                        break;
                    default:
                        break;
                }
            }
           // manager.ShutDown();

        }

        private string PocessCommand(string line)
        {
            return line;
            /*string[] tokens = line.Split();
            string command = tokens[0];
            string output = "";
            string storageName;
            int garageSlote;
            switch (command)
            {
                case "AddProduct":
                    string productName = tokens[1];
                    double price = double.Parse(tokens[2]);
                    output = this.storage.AddProduct(productName, price);
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
                default: break;
            }
            return output;
            */
        }
    }
}

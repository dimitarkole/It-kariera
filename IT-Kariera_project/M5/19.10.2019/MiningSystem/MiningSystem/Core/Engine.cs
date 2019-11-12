using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiningSystem.Core
{
    public class Engine
    {
        private SystemManager manager;

        public Engine()
        {
            this.manager = new SystemManager();
        }

        public void Run()
        {
            List<string> commandArgs = Console.ReadLine()
                   .Split(' ')
                   .ToList();
            while (commandArgs[0]!= "Shutdown")
            {
                List<string> args = commandArgs.Skip(1).ToList();
                switch (commandArgs[0])
                {
                    case "RegisterMiner":
                        manager.RegisterMiner(args);
                        break;
                    case "RegisterProvider":
                        manager.RegisterProvider(args);
                        break;
                    case "Day":
                        manager.Day();
                        break;
                    default:
                        break;
                }
            }
            manager.ShutDown();

        }
    }
}

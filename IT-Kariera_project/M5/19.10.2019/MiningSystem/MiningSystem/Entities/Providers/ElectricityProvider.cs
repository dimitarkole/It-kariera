using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Providers
{
    public class ElectricityProvider : Provider
    {
        public ElectricityProvider(string id, double energyOutput) 
            : base(id, energyOutput * 1.5)
        {
        }
    }
}

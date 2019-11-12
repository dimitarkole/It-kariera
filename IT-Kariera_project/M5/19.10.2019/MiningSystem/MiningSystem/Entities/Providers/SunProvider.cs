using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Providers
{
    public class SunProvider : Provider
    {
        public SunProvider(string id, double energyOutput) 
            : base(id, energyOutput * 1.25)
        {
        }
    }
}

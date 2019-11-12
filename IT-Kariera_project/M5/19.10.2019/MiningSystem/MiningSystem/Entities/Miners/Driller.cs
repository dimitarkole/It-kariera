using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Miners
{
    public class Driller : Miner
    {
        public Driller(string id, double coalOutput, double energyRequirement)
            : base(id, coalOutput*3, energyRequirement*2)
        {

        }
    }
}

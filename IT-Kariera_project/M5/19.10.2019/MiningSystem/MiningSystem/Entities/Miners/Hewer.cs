using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Miners
{
    public class Hewer : Miner
    {
        private int enduranceFactor ;

        public int EnduranceFactor 
        {
            get { return enduranceFactor ; }
            set { enduranceFactor  = value; }
        }

        public Hewer(string id, double coalOutput, double energyRequirement, int enduranceFactor) 
            : base(id, coalOutput, energyRequirement / enduranceFactor)
        {
        }
    }
}

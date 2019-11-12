using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Miners
{
    public abstract class Miner
    {
        private string id ;

        private double coalOutput;

        private double energyRequirement;

        protected Miner(string id, double coalOutput, double energyRequirement)
        {
            this.Id = id;
            this.CoalOutput = coalOutput;
            this.EnergyRequirement = energyRequirement;
        }

        public string Id
        {
            get { return id ; }
            protected set { id  = value; }
        }

        public double CoalOutput
        {
            get { return coalOutput; }
            protected set {
                if (value < 0)
                    throw new ArgumentException($"{nameof(this.CoalOutput)}");
                coalOutput = value;
            }
        }
        public double EnergyRequirement
        {
            get { return energyRequirement; }
            protected set {
                if (!((value > 0) && (value < 20000)))
                    throw new ArgumentException($"{nameof(this.energyRequirement)}");
                energyRequirement = value; 
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name} Miner - {this.Id}");
            sb.AppendLine($"Coal Output: {this.coalOutput}");
            sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

            return sb.ToString().Trim(); 
        }

    }
}

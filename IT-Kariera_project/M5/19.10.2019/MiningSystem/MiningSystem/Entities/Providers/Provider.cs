using System;
using System.Collections.Generic;
using System.Text;

namespace MiningSystem.Entities.Providers
{
    public abstract class Provider
    {
        private string id;

        private double energyOutput;


        protected Provider(string id, double energyOutput)
        {
            this.Id = id;
            this.EnergyOutput = energyOutput;
        }

        public string Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public double EnergyOutput
        {
            get { return energyOutput; }
            protected set {
                if (!((value > 0) && (value < 10000)))
                    throw new ArgumentException();
                energyOutput = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name} Provider - {this.Id}");
            sb.AppendLine($"Energy Output: {this.energyOutput}");
            return sb.ToString().Trim();
        }
    }
}

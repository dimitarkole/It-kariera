using MiningSystem.Entities.Miners;
using MiningSystem.Entities.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiningSystem.Core
{
    public class SystemManager
    {
        private List<Miner> miners;
        private List<Provider> providers;
        private double totalEnergy;
        private double totalCollectedEnetgy;

        public SystemManager()
        {
            this.providers = new List<Provider>();
            this.miners = new List<Miner>();
            totalEnergy = 0;
            totalCollectedEnetgy = 0;
        }

        public string RegisterMiner(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            double coalOutput = double.Parse(arguments[0]);
            double energyRequirementm = double.Parse(arguments[0]);
            Miner miner = null;
            string result;
            try
            {
                switch (type)
                {
                    case "Driller":
                        miner = new Driller(id, coalOutput, energyRequirementm);
                        break;
                    case "Hewer":
                        int enduranceFactor = int.Parse(arguments[0]);
                        miner = new Hewer(id, coalOutput, energyRequirementm, enduranceFactor);
                        break;
                    default:
                        return null;
                }
                result = $"Successfully registered {type} Miner – {id}";
            }
            catch (ArgumentException ex)
            {
                result = $"Miner is not registered, because of it's {ex.Message}";
            }
            return result;
        }

        public string RegisterProvider(List<string> arguments)
        {
            string type = arguments[0];
            string id = arguments[1];
            int energyOutput = int.Parse(arguments[0]);

            Provider provider = null;
            string result;
            try
            {
                switch (type)
                {
                    case "Sun":
                        provider = new SunProvider(id, energyOutput);
                        break;
                    case "Electricity":
                        provider = new ElectricityProvider(id, energyOutput);   
                       break;
                    default:
                        return null;
                }
                result = $"Successfully registered {type} Provider – {id}";
            }
            catch (ArgumentException ex)
            {
                result = $"Provider is not registered, because of it's {ex.Message}";

            }
            return result;
        }

        public string Day()
        {
            this.totalEnergy += providers.Sum(p => p.EnergyOutput);
            double totalEnergyRequirement = miners.
                Sum(m=> m.EnergyRequirement);
            double coalCollected = 0;

            if (totalEnergyRequirement<= this.totalEnergy)
            {
                coalCollected= miners.Sum(m => m.CoalOutput);

                totalEnergy -= coalCollected;
                totalCollectedEnetgy += coalCollected;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A day has passed.");
            sb.AppendLine($"Energy Provided: { this.totalEnergy}.");
            sb.AppendLine($"Mined Coal: { coalCollected}");

            return sb.ToString().Trim();
        }
        public string Check(List<string> arguments)
        {
            string id = arguments[0];
            Provider provider = this.providers.FirstOrDefault(x => x.Id == id);
            string result = "";
            if (providers == null)
            {
                Miner miner = miners.FirstOrDefault(m => m.Id == id);
                if (miner != null)
                {
                    result = miner.ToString();
                }
                result = $"No element found with id – {id}";

            }
            else
            {
                result = provider.ToString();
            }

            return result;
        }
        public string ShutDown()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"System Shutdown");
            
            sb.Append($"Total Energy Stored: {totalEnergy}");
            sb.Append($"Total Mined Coal: {totalCollectedEnetgy}");

            return sb.ToString().Trim();
        }

    }
}

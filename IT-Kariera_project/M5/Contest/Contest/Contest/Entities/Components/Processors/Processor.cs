using CryptoMiningSystem.Entities.Components.Contracts;
using CryptoMiningSystem.Entities.Components.Processors.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.Processors
{
    public abstract class Processor : IComponent, IProcessor
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                model = value; 
            }
        }


        public decimal Price { get; set; }

        private int generation;

        public int Generation
        {
            get { return generation; }
            set { 
                if(value>9)
                {
                    throw new ArgumentException($"{GetType().Name} generation cannot be more than 9!");
                }
                generation = value; 
            }
        }


        public int LifeWorkingHours { get; set; }

        public int MineMultiplier { get; set; }

        protected Processor(string model,  int mineMultiplier, decimal price)
        {
            this.Model = model;
            this.MineMultiplier = mineMultiplier;
            this.Price = price;
            this.LifeWorkingHours = this.Generation * 100;
        }
    }
}

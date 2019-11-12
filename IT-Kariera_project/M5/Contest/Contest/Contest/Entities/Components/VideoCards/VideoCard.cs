using CryptoMiningSystem.Entities.Components.Contracts;
using CryptoMiningSystem.Entities.Components.VideoCards.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    public abstract class VideoCard : IComponent, IVideoCard
    {
        public decimal MinedMoneyPerHour { get; protected set; }

        public decimal Price { get; set; }

        public int Generation { get; set; }
        public int LifeWorkingHours { get; set; }

        private int ram;

        public int Ram
        {
            get { return ram; }
            private set
            {
                if(!((value>0)&&(value<=32)))
                {
                    throw new ArgumentException($"{GetType().Name} ram cannot less or equal to 0 and more than 32!");
                }
                ram = value; 
            }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }

                model = value;
            }
        }


        public VideoCard(string model, int ram,  int generation, decimal price)
        {
            this.Model = model;
            this.Ram = ram;
            this.Generation = generation;
            this.Price = price;
            this.MinedMoneyPerHour = this.Ram *  this.Generation / 10;
            this.LifeWorkingHours = this.Ram * this.Generation * 10;
            
        }


    }
}

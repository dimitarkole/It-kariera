using CryptoMiningSystem.Entities.Components.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components
{
    public abstract class Component : IComponent
    {
        private string model;

        public string Model
        {
            get { return model; }
            protected set
            { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                model = value;
            }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            protected set
            {
                if (!((value>=0)&&(value<= 10000)))
                {

                    throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000!");
                }
                price = value;
            }
        }


        private int generation;

        public int Generation
        {
            get { return generation; }
            protected set
            {
                if (value < 0)
                {

                    throw new ArgumentException("Generation cannot be 0 or negative!");
                }
                generation = value;
            }
        }

        public int LifeWorkingHours { get; set; }

        public Component(string model, decimal price, int generation, int lifeWorkingHours)
        {
            Model = model;
            this.Price = price;
            Generation = generation;
            LifeWorkingHours = lifeWorkingHours;
        }
    }
}

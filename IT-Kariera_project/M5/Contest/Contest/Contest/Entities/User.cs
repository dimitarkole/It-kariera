using CryptoMiningSystem.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities
{
    class User : IUser
    {
        public User(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Stars = (int)money / 100;
        }

        private string name;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username must not be null or empty!");
                }
                this.name = value;
            }
        }

        private int stars;

        public int Stars
        {
            get { return this.stars; }
            protected set { this.stars = value; }
        }

        private decimal money;

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("User's money cannot be less than 0!");
                }
                this.money = value;
            }
        }


        private Computer computer;

        public Computer Computer
        {
            get { return this.computer; }
            set { this.computer = value; }
        }
    }
}

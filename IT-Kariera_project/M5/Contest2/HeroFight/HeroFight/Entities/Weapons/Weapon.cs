namespace HeroFight.Entities.Weapons
{
    using Contracts;
    using System;
    using System.Text;


    public class Weapon : IWeapon
    {
        public Weapon(string name, int strength, int agility, int intelligence)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Intelligence = intelligence;
            this.Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null || value == "" || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Weapon name cannot be null, empty or whitespace.");
                }
                name = value;
            }
        }

        private int strength = 0;

        public int Strength
        {
            get { return strength; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Strength cannot be less than 0!");
                }
                this.strength = value;
            }
        }

        private int agility;

        public int Agility
        {
            get { return agility; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Agility cannot be less than 0!");
                }
                agility = value;
            }
        }

        private int intelligence;

        public int Intelligence
        {
            get { return intelligence; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Intelligence cannot be less than 0!");
                }
                this.intelligence = value;
            }
        }

    }
}

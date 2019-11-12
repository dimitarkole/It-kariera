namespace HeroFight.Entities.Heroes
{
    using HeroFight.Entities.Weapons;
    using Contracts;
    using System;
    using System.Text;

    public class Hero : IHero
    {

        public Hero(string name)
        {
            this.Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null || value == ""
                    || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Hero name cannot be null, empty or whitespace.");
                }
                name = value;
            }
        }


        private int level;

        public int Level
        {
            get { return level; }
            private set
            {
                level = value;
            }
        }


        private int experience;

        public int Experience
        {
            get { return experience; }
            set
            {
                experience += value;
                if (this.experience > 100)
                {
                    this.Level++;
                    this.experience -= 100;
                }
            }
        }


        private Weapon weapon;

        public Weapon Weapon
        {
            get { return weapon; }
            set
            {
                weapon = value;
                var strength = value.Strength;
                var agility = value.Agility;
                var intelligence = value.Intelligence;
                this.Power = (strength + agility + intelligence) / 3;
            }
        }

        private double power;

        public double Power
        {
            get { return power; }
            private set
            {
                power = value * PowerIncreases;
            }
        }

        private double powerIncreases;

        protected double PowerIncreases
        {
            private get { return powerIncreases; }
            set
            {
                powerIncreases = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}: {this.Name} - Level: {this.Level}");
            sb.AppendLine($"Experience: {this.Experience}");
            Weapon weapon = this.Weapon;
            if (weapon != null)
            {
                sb.AppendLine($"{weapon.GetType().Name}: {weapon.Name}");
                sb.AppendLine($"  *Strength: {weapon.Strength}");
                sb.AppendLine($"  *Agility: {weapon.Agility}");
                sb.AppendLine($"  *Intelligence: {weapon.Intelligence}");
            }
            sb.AppendLine($"Power: {this.Power:f2}");

            return sb.ToString().Trim();
        }
    }
}
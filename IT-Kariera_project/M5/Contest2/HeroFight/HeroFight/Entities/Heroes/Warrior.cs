namespace HeroFight.Entities.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name)
            : base(name)
        {
            base.PowerIncreases = 4;
        }
    }
}

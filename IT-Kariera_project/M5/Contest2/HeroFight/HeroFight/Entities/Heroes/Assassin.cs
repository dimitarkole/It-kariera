namespace HeroFight.Entities.Heroes
{
    public class Assassin : Hero
    {
        public Assassin(string name) 
            : base(name)
        {
            base.PowerIncreases = 6;
        }
    }
}

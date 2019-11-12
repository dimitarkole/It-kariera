namespace HeroFight.Entities.Heroes
{
    public class Priest : Hero
    {
        public Priest(string name)
            : base(name)
        {
            base.PowerIncreases = 8;
        }
    }
}

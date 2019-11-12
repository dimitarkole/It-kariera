using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Dog : IAnimal
    {


        /*
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }
        public override string ExplainMyself()
        {
            return base.ExplainMyself()+Environment.NewLine+"Meew";
        }*/
        public string MakeNoise()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";

        }

        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }

    /* : Animal
{
    public Dog(string name, string favouriteFood) : base(name, favouriteFood)
    {
    }
    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}*/
}

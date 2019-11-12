using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Cat : IAnimal
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
            return "Meow!";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";

        }

        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}

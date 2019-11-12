using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Doggi",3);
            Cat cat = new Cat("Pisi", 2);
            Dog dog2 = new Dog("Dog", 1);

            var animals = new List<Animal>() { dog, cat,dog2 };
            var zoo = new ZooPark(animals);

            foreach (var item in zoo)
            {
                Console.WriteLine(item.Name+" "+item.Age);
            }

        }
    }
}

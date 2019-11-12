using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name{ get; set; }
        public int Age { get; set; }

    }
}

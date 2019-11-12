using System;
using System.Collections.Generic;
using System.Text;

namespace Exeption
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "value",
                        "The first name cannot be null or emty.");
                }
                name = value;
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "value",
                        "The last name cannot be null or emty.");
                }
                lastName = value;
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {

                if (value<=0 || 120>= value)
                {
                    throw new ArgumentException(
                        "value",
                        "Age should be in the range [0 ... 120 ].");
                }
                age = value;
            }
        }

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        
    }
}

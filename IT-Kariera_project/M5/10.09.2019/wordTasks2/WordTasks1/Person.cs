using System;
using System.Collections.Generic;
using System.Text;

namespace WordTasks1
{
    class Person : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y);

        }

        private int age;
        private string name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}

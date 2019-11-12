using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WordTasks1
{
    class Family
    {


        private List<Person> people;

        public Family()
        {
            this.People = new List<Person>();
        }

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public void Print()
        {
            List<Person> sortedPerson = People.OrderBy(x=>x.Name).Reverse().ToList();

            foreach (var person in sortedPerson)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }

        public void Print2()
        {
            List<Person> sortedPerson = People.Where(x=>x.Age>30).OrderBy(x => x.Name).ToList();

            foreach (var person in sortedPerson)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }


    }
}

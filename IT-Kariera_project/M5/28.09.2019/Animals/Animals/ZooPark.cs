using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class ZooPark : IEnumerable<Animal>
    {
        private List<Animal> animals;

        public ZooPark(List<Animal> animals)
        {
            this.animals = animals;
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            return new AnimalIterator(animals);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

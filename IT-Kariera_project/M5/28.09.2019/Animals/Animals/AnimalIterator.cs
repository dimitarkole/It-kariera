using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class AnimalIterator: IEnumerator<Animal>
    {
        private IReadOnlyList<Animal> animals;

        public AnimalIterator(IReadOnlyList<Animal> animals)
        {
            this.animals = animals;
            Reset();
        }

        private int index;

        public Animal Current => animals[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index--;
            return index >-1;
        }

        public void Reset()
        {
            index = this.animals.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; //показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; //показва поредният индекс, на който можем да поставим елемент

        public Pair[] Items { get => items; set => items = value; }
        public int NextIndex { get => nextIndex; set => nextIndex = value; }
        public int StartIndex { get => startIndex; set => startIndex = value; }

        public int Count
        {
            get;
            private set;
        }

        public Pair SumIntervalPairs()
        {
            //TODO: сумирайте двойките от startIndex до nextIndex
            Pair result = new Pair(0, 0);
            for (int i = 0; i < items.Length; i++)
            {
                if(!Items[i].IsCombinated)
                {
                    result.First += this.Items[i].First;
                    result.Last += this.Items[i].Last;
                }
            }
            return result;
        }

        public Pair Sum()
        {
            //TODO: сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
            Pair result = new Pair(0, 0);
            for (int i = 0; i < items.Length; i++)
            {
                if (Items[i].IsCombinated)
                {
                    result.First += this.Items[i].First;
                    result.Last += this.Items[i].Last;
                }
            }
            return result;
        }

        public void Add(Pair item)
        {
            if (this.Count == this.items.Length)
            {
                var combinedPair = SumIntervalPairs();
                items[startIndex] = combinedPair;
                items[startIndex].IsCombinated = false;
                startIndex++;
                for (int i = startIndex; i < items.Length; i++)
                {
                    Items[i] = null;
                }
                Items[startIndex] = item;
                Count = startIndex + 1;
                nextIndex = startIndex + 1;

            }
            else
            {
                Items[nextIndex] = item;
                nextIndex++;
                Count++;
            }
        }



        public CapacityList(int capacity = InitialCapacity)
        {
            this.Items = new Pair[capacity];

        }

        
       
       

       

       

      

        public void PrintCurrentState()
        {
            //TODO: отпечатайте всички двойки от 0 до nextIndex
            for (int i = 0; i < this.Items.Length; i++)
            {
                Console.WriteLine(Items[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}

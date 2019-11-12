using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Pair
    {
        public int First { get; set; }
        public int Last { get; set; }
        public bool IsCombinated { get => isCombinated; set => isCombinated = value; }

        private bool isCombinated;
        public Pair(int first, int last)
        {
            this.First = first;
            this.Last = last;
            //TODO: Add code
        }

        public override string ToString()
        {
            //TODO: Add code
            return $"({this.First},{this.Last})";
        }

        public int Difference()
        {
            //TODO: Add code
            int diff = Math.Abs(this.Last - this.First);
            return diff;
        }
        

    }
}

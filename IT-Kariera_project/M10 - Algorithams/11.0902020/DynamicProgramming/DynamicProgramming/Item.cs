using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class Item
    {
        public int Weight { get; set; }

        public int Value { get; set; }

        public override string ToString()
        {
            return "Value: "+this.Value + "; Weight: " + this.Weight;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class ActivityInputModel
    {
        public ActivityInputModel()
        {
        }

        public ActivityInputModel(string name, int start, int end)
        {
            Name = name;
            Start = start;
            End = end;
        }

        public string Name{ get; set; }

        public int Start { get; set; }

        public int End { get; set; }

        public override string ToString()
        {
            return this.Name + " " + this.Start + " " + this.End;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class WorkInputModel
    {
        public WorkInputModel()
        {
        }

        public WorkInputModel(int index, int day, int money)
        {
            Index = index;
            Day = day;
            Money = money;
        }

        public int Index { get; set; }

        public int Day { get; set; }

        public double Money { get; set; }

        public override string ToString()
        {
            return "j" + this.Index;
        }
    }
}

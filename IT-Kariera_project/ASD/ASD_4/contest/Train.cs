using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contest
{
    public class Train
    {
        private int number, cars;
        private string name, type;
        public Train(int number, string name, string type, int cars)
        {
            this.Cars = cars;
            this.Number = number;
            this.Name = name;
            this.Type = type;
        }

        public int Cars { get => cars; set => cars = value; }
        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            return $"{this.Number} {this.Name} {this.Cars} {this.Type}";
        }
    }
}

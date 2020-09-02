using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class ProgramInputModel
    {
        public ProgramInputModel()
        {
        }

        public ProgramInputModel(string name, int length, double probability)
        {
            Name = name;
            Length = length;
            Probability = probability;
        }

        public string Name { get; set; }

        public int Length { get; set; }

        public double Probability { get; set; }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}

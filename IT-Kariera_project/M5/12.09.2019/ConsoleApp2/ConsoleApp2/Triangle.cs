using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Triangle : ColoredFigure
    {
        public Triangle(string color, int size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            double S=0;
            S = Math.Pow(base.size, 2)/4 * Math.Sqrt(3);

            return S;
        }

        public override string GetName()
        {
            return "Triangle";
        }
    }
}

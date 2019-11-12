using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Circle : ColoredFigure
    {
        public Circle(string color, int size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            double S = Math.PI*Math.Pow(base.size,2);
            return S;
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}

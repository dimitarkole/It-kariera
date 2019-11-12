using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Square : ColoredFigure
    {
        public Square(string color, int size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            double S = Math.Pow(base.size,2);
            return S;
        }

        public override string GetName()
        {
            return "Square";
        }
    }
}

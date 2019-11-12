using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Circle : Shape
    {
        public double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        

        public Circle(double radius)
        {
            this.Radius= radius;
        }
        

        public override double CalculateArea()
        {
            double S = Math.PI * Math.Pow( this.Radius,2);
            return S;
        }

        public override double CalculatePerimeter()
        {
            double P = 2 * Math.PI * this.Radius;
            return P;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}

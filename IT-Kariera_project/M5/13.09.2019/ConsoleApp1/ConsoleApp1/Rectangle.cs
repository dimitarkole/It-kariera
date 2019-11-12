using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle : Shape
    {
        public double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double CalculateArea()
        {
            double S = this.Height*this.Width;
            return S;
        }

        public override double CalculatePerimeter()
        {
            double P = (this.Height + this.Width)*2;

            return P;
        }

        public override string Draw()
        {
            return base.Draw()+ "Rectangle";
        }
    }
}

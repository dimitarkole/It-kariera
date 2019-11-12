using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Shape
    {
        public int a { get; set; }

        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();


        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}

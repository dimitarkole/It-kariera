using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class ColoredFigure
    {
        protected string color;

        protected int size;

        protected ColoredFigure(string color, int size)
        {
            this.color = color;
            this.size = size;
        }

        public void Show()
        {
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Color: {this.size}");
        }

        public abstract string GetName();
        public abstract double GetArea();

    }
}

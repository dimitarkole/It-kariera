using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Box
    {
        private double length, width, height;

        public Box(double length,double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public void Volume()
        {
            double length = this.Length;
            double width = this.Width;
            double height = this.Height;
            double result= length * width * length;
            Console.WriteLine($"Volume - {result:0.00}");
        }

        public void LateralSurfaceArea()
        {
            double length = this.Length;
            double width = this.Width;
            double height = this.Height;
            //2lh + 2wh
            double result = 2 * length * height + 2 * width * height;
            Console.WriteLine($"Lateral Surface Area - {result:0.00}");

        }

        public void SurfaceArea()
        {
            double length = this.Length;
            double width = this.Width;
            double height = this.Height;
            double result = 2 *( length * width +  length * height+  width*height);
            Console.WriteLine($"Surface Area - {result:0.00}");
        }

        private double Length
        {
            get { return length; }
            set { length = value; }
        }

        private double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double Height
        {
            get { return height; }
            set { height = value; }
        }
    }
}

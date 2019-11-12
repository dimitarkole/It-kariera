using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Rectangle: Drawable
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public void Draw()
        {
            for (int i = 0; i < this.Height; i++)
            {
                Console.WriteLine(new string('*', this.Width));

            }
        }
    }
}

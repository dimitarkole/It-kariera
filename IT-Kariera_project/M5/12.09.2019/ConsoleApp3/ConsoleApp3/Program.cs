using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 3);
            rectangle.Draw();
            Console.WriteLine();
            Console.WriteLine();
            Circle circle = new Circle(5);
            circle.Draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            floatTask5();
        }

        static void floatTask1()
        {
            double num1 = 3.141592653589793238;
            float num2 = 1.60217657F;
            decimal num3 = 7.8184261974584555216535342341M;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

        }

        static void floatTask2()
        {
            double r = Double.Parse(Console.ReadLine());
            Console.WriteLine("{0:12F}",r*r*Math.PI);
        }

        static void floatTask3()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0.0m;
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}", sum);
        }

        static void floatTask4()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("{0}", (a + b) * 2);
            Console.WriteLine("{0}", a * b);
            Console.WriteLine("{0}", Math.Sqrt((double)(a * a + b * b)));
        }

        static void floatTask5()
        {
            float meter = float.Parse(Console.ReadLine());
            float hour = float.Parse(Console.ReadLine());
            float min = float.Parse(Console.ReadLine());
            float sec = float.Parse(Console.ReadLine());
            double allSec = sec + (min + hour * 60) * 60;
            double meterSec = meter / allSec;
            Console.WriteLine("{0:0.000000}", meterSec);
            Console.WriteLine("{0:0.000000}", meterSec*3.6);
            Console.WriteLine("{0:0.000000}", meterSec*3.6/ 1.609);
        }


        static void convertValueTask1()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }

        static void convertValueTask2()
        {
            string one = "Software University";
            char two = 'B';
            char tree = 'y';
            char four = 'e';
            string five = "I love programming";

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(tree);
            Console.WriteLine(four);
            Console.WriteLine(five);
        }

        static void convertValueTask3()
        {
            string hello = "Hello";
            string world = "World";

            object message = hello + " " + world;
            string messageStr = (string)message;
            Console.WriteLine(messageStr);
        }

        static void convertValueTask4()
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char tree = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}", tree,two,one);
        }

        static void convertValueTask5()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string number = Console.ReadLine();
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Age:  {age}");
            Console.WriteLine($"Gender: {sex}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {number}");
        }

        static void convertValueTask6()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            double heigth = double.Parse(Console.ReadLine());
            double V = (length + width + heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);

        }
    }
}

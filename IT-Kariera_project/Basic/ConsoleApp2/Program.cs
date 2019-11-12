using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            sixthTask();
        }

        static void firstTask()
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 1) Console.WriteLine("one");
            else if (number == 2) Console.WriteLine("two");
            else if (number == 3) Console.WriteLine("three");
            else if (number == 4) Console.WriteLine("four");
            else if (number == 5) Console.WriteLine("five");
            else if (number == 6) Console.WriteLine("six");
            else if (number == 7) Console.WriteLine("seven");
            else if (number == 8) Console.WriteLine("eight");
            else if (number == 9) Console.WriteLine("nine");
            else  Console.WriteLine("number too big");
        }

        static void secondTask()
        {
            int point = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (point <= 100) bonus+=5;
            if (point >= 1000) bonus += point*0.1;
            else if(point >= 100) bonus += point * 0.2;
            if (point%2==0) bonus += 1;
            if (point % 10 == 5) bonus += 2;
            Console.WriteLine(bonus);
            Console.WriteLine(point+bonus);
        }

        static void trirdTask()
        {
            int second1 = int.Parse(Console.ReadLine());
            int second2 = int.Parse(Console.ReadLine());
            int second3= int.Parse(Console.ReadLine());
            int sumSecond = second1 + second2 + second3;
            int min = 0;
            min += sumSecond / 60;
            sumSecond %= 60;
            Console.WriteLine("{0}:{1:00}",min,sumSecond);
        }

        static void fourthTask()
        {
            double numberFrom = double.Parse(Console.ReadLine());
            string valueFrom = Console.ReadLine();
            string valueTo = Console.ReadLine();
            if (valueFrom == "mm") numberFrom /= 1000;
            else if (valueFrom == "cm") numberFrom /= 100;
            else if (valueFrom == "mi") numberFrom /= 0.000621371192;
            else if (valueFrom == "in") numberFrom /= 39.3700787;
            else if (valueFrom == "km") numberFrom /= 0.001;
            else if (valueFrom == "ft") numberFrom /= 3.2808399;
            else if (valueFrom == "yd") numberFrom /= 1.0936133;
            if (valueTo == "mm") numberFrom = numberFrom*1000;
            else if (valueTo == "cm") numberFrom =numberFrom* 100;
            else if (valueTo == "mi") numberFrom = numberFrom * 0.000621371192;
            else if (valueTo == "in") numberFrom = numberFrom * 39.3700787;
            else if (valueTo == "km") numberFrom = numberFrom*0.001;
            else if (valueTo == "ft") numberFrom = numberFrom* 3.2808399;
            else if (valueTo == "yd") numberFrom = numberFrom*1.0936133;

            Console.WriteLine("{0} {1}",numberFrom, valueTo);
        }

        static void fifthTask()
        {
            int number = int.Parse(Console.ReadLine());
            if (number<100)Console.WriteLine("Less than 100");
            else if ((number > 100)&& (number < 200)) Console.WriteLine("Between 100 and 200");
            else  Console.WriteLine("Greater than 200");

        }

        static void sixthTask()
        {
            double number = double.Parse(Console.ReadLine());
            if (number <= 10) Console.WriteLine("slow");
            else if ((number >= 10) && (number <= 50)) Console.WriteLine("average");
            else if ((number >= 50) && (number <= 150)) Console.WriteLine("fast");
            else if ((number >= 150) && (number <= 1000)) Console.WriteLine("ultra fast");
            else Console.WriteLine("extremely fast");

        }
    }
}

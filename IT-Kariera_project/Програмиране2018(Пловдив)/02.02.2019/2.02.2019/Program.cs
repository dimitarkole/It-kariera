using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._02._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            task5();
        }
        static void task1()
        {
            ushort inputCentury = ushort.Parse(Console.ReadLine());
            uint year = (uint)(inputCentury * 100);
            uint days = (uint)(year * 365.2422);
            Int64 hours = days * 24;
            ulong min = days * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", inputCentury, year, days, hours, min);
        }

        static void task2()
        {
            sbyte num1 = -100;
            byte num2 = 128;
            short num3 = -3540;
            ushort num4 = 64876;
            uint num5 = 2147483648;
            long num6 = -1141583228;
            string num7 = "-1223372036854775808";
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
        }

        static void task3()
        {
            string number16 = Console.ReadLine();
            int number10 = Convert.ToInt32(number16, 16);
            Console.WriteLine(number10);
        }

        static void task4()
        {
            byte a = 5, b=10;
            Console.WriteLine("Before:");
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}", b);

            byte c = a;
            a=b;
            b = c;
            Console.WriteLine("After:");
            Console.WriteLine("a={0}", a);
            Console.WriteLine("b={0}", b);
        }

        static void task5()
        {
            int number10=int.Parse(Console.ReadLine());
            int number2=int.Parse(Convert.ToString(number10, 2));
            string number16 = Convert.ToString(number10, 16);
            number16 = number16.ToUpper();
            Console.WriteLine("{0}", number16);
            Console.WriteLine("{0}", number2);

        }

        static void task6()
        {
            ushort n = ushort.Parse(Console.ReadLine());
            int sum = 0;
            for (short i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                sum += (number1 % number2);
            }
            Console.WriteLine(sum);
        }

    }
}

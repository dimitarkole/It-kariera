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
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        static void Task1()
        {
            PrintReceipt();
        }

        static void Task2()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void Task3()
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        static void Task4()
        {
            PrintSquere(int.Parse(Console.ReadLine()));
        }

        static void Task5()
        {
            double farenhait = double.Parse(Console.ReadLine());
            double celsium = FarenhaitToCelsium(farenhait);
            Console.WriteLine("{0:F2}", celsium);
        }

        static void Task6()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double s = GetTriangleArea(width, height);
            Console.WriteLine("{0:F2}", s);
        }

        static void Task7()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double ab = APowB(a, b);
            Console.WriteLine(ab);
        }

        static void Task8()
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int sumOfOddDigits = GetSumOfOddDigits(number);
            int sumOfEvenDigits = GetSumOfEvenDigits(number);
            Console.WriteLine(sumOfEvenDigits*sumOfOddDigits);
        }

        static void Task9()
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max=GetMaxInt(first, second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max= GetMaxChar(first, second);
                Console.WriteLine(max);
            }

            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMaxString(first, second);
                Console.WriteLine(max);
            }
        }

        static int GetMaxInt(int first,int second)
        {
            return Math.Max(first, second);
        }

        static char GetMaxChar(char first, char second)
        {
            if (first > second) return first;
            else return second;
        }

        static string GetMaxString(string first, string second)
        {
            if (first.CompareTo(second)==1) return first;
            else return second;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while(number>0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0) sum += lastDigit;
                number /= 10;
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 1) sum += lastDigit;
                number /= 10;
            }
            return sum;
        }

        static double APowB(int a,int b)
        {
            double ab = Math.Pow(a, b);
            return ab;
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFoot();
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceiptFoot()
        {
            Console.WriteLine("------------------------------");
            Console.Write("© SoftUni");
            Console.WriteLine();
        }

        static void PrintSign(int number)
        {
            if (number > 0) Console.WriteLine("The number {0} is positive", number);
            else if (number < 0) Console.WriteLine("The number {0} is negative.", number);
            else Console.WriteLine("The number {0} is zero.", number);
        }

        static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLineOfTriangle(i);
            }
            for (int i = number - 1; i > 0; i--)
            {
                PrintLineOfTriangle(i);
            }
        }

        static void PrintLineOfTriangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

        static void PrintSquere(int number)
        {
            PrintHeaderLineSquere(number);
            for (int i = 0; i < number - 2; i++)
            {
                PrintMidlleLineSquere(number);
            }
            PrintHeaderLineSquere(number);
        }

        static void PrintHeaderLineSquere(int number)
        {
            Console.WriteLine(new string('-',number*2));          
        }

        static void PrintMidlleLineSquere(int number)
        {
            Console.Write('-');
            for (int i = 0; i < number-1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static double FarenhaitToCelsium(double farenhait)
        {
            double celsium = (farenhait - 32) * 5 / 9;
            return celsium;
        }

        static double GetTriangleArea(double width, double height)
        {
            double s = width * height / 2;
            return s;
        }
    }
}

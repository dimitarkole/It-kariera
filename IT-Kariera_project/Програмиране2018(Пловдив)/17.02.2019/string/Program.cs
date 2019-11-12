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
            task5();
        }

        static void task1()
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = inputNumbers[0];
            int number10 = inputNumbers[1];
            Stack<int> numberN = new Stack<int>();
            while (number10 > 0)
            {
                int ch = number10 % n;
                number10 /= n;
                numberN.Push(ch);
            }
            Console.WriteLine(string.Join("", numberN));
        }

        static void task2()
        {
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = inputNumbers[0];
            int numberN = inputNumbers[1];
            List<int> num = new List<int>();
            while (numberN > 0)
            {
                int ch = numberN % 10;
                numberN /= 10;
                num.Add(ch);
            }
            num.Reverse();
            int number10 = 0;
            for (int i = 0; i < num.Count(); i++)
            {
                number10 = number10 * n + num[i];
            }
            Console.WriteLine(number10);
        }

        static void task3()
        {
            string inputString = Console.ReadLine();
            string newString = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                newString += inputString[i];
            }
            Console.WriteLine(newString);
        }

        static void task4()
        {
            string inputString = Console.ReadLine();
            for (int i = 0; i < inputString.Length; i++)
            {
                char letter = inputString[i];
                string escape = "\\u" + ((int)letter).ToString("X").PadLeft(4, '0');
                Console.Write(escape);
            }
            Console.WriteLine();
        }

        static void task5()
        {
            string[] inputSring = Console.ReadLine().Split(' ').ToArray();
            string firstSring = inputSring[0];
            string secondSring = inputSring[1];
            int sum =task6MultiplicationStrings(firstSring, secondSring);
            Console.WriteLine(sum);
        }

        static int task6MultiplicationStrings(string firstSting, string secondSting)
        {
            int sum = 0;
            int maxLength = Math.Max(firstSting.Length, secondSting.Length);
            for (int i = 0; i < maxLength; i++)
            {
                int multiplication = 1;
                if (i < firstSting.Length) multiplication *= (int)(firstSting[i]);
                if (i < secondSting.Length)  multiplication *= (int)(secondSting[i]);
                sum += multiplication;
            }
            return sum;
        }


        static void task6()
        {
            string inputSring = Console.ReadLine();
            char[] reverseSringArr = inputSring.ToCharArray().Reverse().ToArray();
            string reverseSring = new string(reverseSringArr);
            Console.WriteLine(reverseSring);
            if (inputSring==reverseSring) Console.WriteLine("Palindrom");
            else Console.WriteLine("No palindrom");
        }

    }
}
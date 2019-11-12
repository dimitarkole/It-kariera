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
            task3();
        }

        static void task1()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average());
        }

        static void task2()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            numbers= numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }

        static void task3()
        {
            string input = Console.ReadLine().ToLower();
            List<string> allWords = input.Split(' ','.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?').ToList();

        }
    }
}

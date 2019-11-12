using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctualDeveloper2Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Task5();
        }

        static void Task2()
        {
            int[] number = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(number.Count());
            Console.WriteLine(number.Sum());
        }
        static void Task3()
        {
            string[] allWords = Console.ReadLine()
                 .Split(" ")
                 .ToArray();
            string[] uppercaseWords = allWords
                .Where(w => w[0] == w.ToUpper()[0])
                .Select(w => w).ToArray();
            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }
        }

        static void Task4()
        {
            Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n * 1.2)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:F2}"));

        }

        static void Task5()
        {
            int n=int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ',' })
                    .ToArray();
                string ageS = input[1];
                ageS= ageS.Substring(1, ageS.Length-1);
                int inputAge = int.Parse(ageS);
                people.Add(input[0], inputAge);

            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Dictionary<string, int> returnPeople = new Dictionary<string, int>();

            if (condition== "younger")
            {
                returnPeople = people
                    .Where(p => p.Value < age)
                    .ToDictionary(p => p.Key, p => p.Value);

            }
            else
            {
                returnPeople = people
                    .Where(p => p.Value >= age)
                    .ToDictionary(p => p.Key, p => p.Value);
            }

            foreach (var human in returnPeople)
            {
                if (format == "name") Console.WriteLine(human.Key);
                else if (format == "age") Console.WriteLine(human.Value);
                else Console.WriteLine($"{human.Key} - {human.Value}");
            }
        }
    }
}


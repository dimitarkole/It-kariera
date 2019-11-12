using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void Problem1()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Search(numbers,searchNumber)); 
        }

        static int Search(int[] collection, int searchNumber)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == searchNumber) return i;

            }
            return -1;
        }


        static void Problem2()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchNumber = int.Parse(Console.ReadLine());
            int index = BinarySearch.IndexOf(numbers, searchNumber);
            Console.WriteLine(index);
        }

        static void Problem3()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchNumber = int.Parse(Console.ReadLine());
            int index = FibonacciSearch.IndexOf(numbers, searchNumber);
            Console.WriteLine(index);
        }

    }
}

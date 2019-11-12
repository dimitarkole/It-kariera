using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_4._1WordFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
        }

        static void Problem1()
        {
            int[] inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SelectionSort.SortUp(inputList);
            Console.WriteLine(string.Join(" ", inputList));
        }

        static void Problem2()
        {
            int[] inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SelectionSort.SortDown(inputList);
            Console.WriteLine(string.Join(" ", inputList));
        }

        static void Problem3()
        {
            int[] inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SelectionSort.SortDown(inputList);
            int[] searchStudent = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"{inputList[searchStudent[0]-1]} {inputList[searchStudent[1]-1]}");
        }

        static void Problem4()
        {
            int[] inputList1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] inputList2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length1 = inputList1.Length;
            int length2 = inputList2.Length;

            int[] allRecord = new int[length1 + length2];
            for (int i = 0; i < inputList1.Length; i++)
            {
                allRecord[i] = inputList1[i];
            }

            for (int i = 0; i < inputList2.Length; i++)
            {
                allRecord[length1+i] = inputList2[i];
            }
            SelectionSort.SortUp(allRecord);

            Console.WriteLine(string.Join(" ", allRecord));
        }

    }
}

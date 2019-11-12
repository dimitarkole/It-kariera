using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem4();
        }

        static void Problem1()
        {
            int[] inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BubbleSort.SortUp(inputList);
            Console.WriteLine(string.Join(" ", inputList));
        }

        static void Problem2()
        {
            int[] inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            InsertSort.SortUp(inputList);
            Console.WriteLine(string.Join(" ", inputList));
        }

        static void Problem3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstNumber = new int[n / 2];
            int[] secondNumber = new int[n / 2];
            for (int i = 0; i < n/2; i++)
            {
                firstNumber[i] = inputList[i];
                secondNumber[i] = inputList[i+n/2];
            }

            BubbleSort.SortUp(secondNumber);
            BubbleSort.SortDown(firstNumber);

            Console.WriteLine("{0} {1}", string.Join(" ", firstNumber), string.Join(" ", secondNumber));
        }

        static void Problem4()
        {
            int[] inputData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int R = inputData[0];
            int C = inputData[1];
            int S = inputData[2];



            SortMatrix matrix = new SortMatrix();
            for (int i = 0; i <R; i++)
            {
                List<int> newRow = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                matrix.AddRow(newRow[S - 1], newRow);
            }
            matrix.SortDown();
            Console.WriteLine(matrix.ToString());

        }
    }
}

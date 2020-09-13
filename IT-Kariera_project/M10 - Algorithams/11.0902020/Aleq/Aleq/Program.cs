using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Aleq
{
    class Program
    {
        static int n = 5;
        static int k = 3;
        static int[] taken = new int[n];
        static List<List<int>> takenCollections = new List<List<int>>();

        static int[] elements = new int[] { 2, 1, 3 };
        static void Main(string[] args)
        {
            variate(0, elements);
            printAllCollecton();
        }

        static void print(int i)
        {

            int l, s = 0;

            List<int> nov = new List<int>();

            for (l = 0; l < taken.Length - 1; l++)
            {
                s += taken[l];
                if (s<= n)
                {
                    nov.Add(taken[l]);
                }

            }

            if (nov.Sum() == n)
            {
                takenCollections.Add(nov);
            }
        }

        static void variate(int i, int[] elements) /* рекурсия */
        {
            if (i >= n)
            {
                print(i);
                return;
            }

            for (int j = 0; j < k; j++)
            {
                taken[i] = elements[j];
                variate(i + 1, elements);
            }
        }

        static void printAllCollecton()
        {
            for (int i = 0; i < takenCollections.Count(); i++)
            {
                var collection = takenCollections[i];
                if (i == 0) Console.WriteLine(string.Join(" ", collection));
                else
                {
                    if (collection.EqualsEx(takenCollections[i - 1]) == false)
                    {
                        Console.WriteLine(string.Join(" ", collection));
                    }
                }
            }
        }      
    }

    public static class Extention
    {
        public static bool EqualsEx(this List<int> numbers, List<int> numbers2)
        {
            if (numbers.Count != numbers2.Count) return false;
            else
            {
                var flag = true;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] != numbers2[i])
                    {
                        flag = false;
                        break;
                    }

                }
                return flag;
            }
        }
    }
}

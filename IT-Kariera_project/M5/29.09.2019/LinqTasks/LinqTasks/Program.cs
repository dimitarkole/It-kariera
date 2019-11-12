using System;
using System.Linq;

namespace LinqTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Count() / 4;
            var firstMasiv = input.Take(k).Reverse().ToArray();
            var secondMasiv = input.Skip(k).Take(2 * k).ToArray();
            var treeMasiv = input.TakeLast(k).Reverse().ToArray();

            int[] sums = new int[2*k];
            for (int i = 0; i < 2*k; i++)
            {
                if (i < k)
                {
                    sums[i] = firstMasiv[i] + secondMasiv[i];
                }
                else
                {
                    sums[i] = treeMasiv[i-k] + secondMasiv[i];
                }
            }

            Console.WriteLine(string.Join(" ", sums));

        }
    }
}

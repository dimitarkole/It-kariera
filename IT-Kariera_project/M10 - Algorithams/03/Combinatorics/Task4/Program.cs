using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50;
            Gen(n, n/2, new List<int>());
        }

        static void Gen(int n, int x, List<int> numbers)
        {
            if ((numbers.Count() != 1) && (n == 1))
            {
                Console.WriteLine(string.Join("*", numbers));
            }

            for (int i = x; i > 1; i--)
            {
                if (n % i == 0)
                {
                    var nums = new List<int>(numbers);
                    nums.Add(i);
                    Gen(n/i, i, nums);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Gen(n, n, new List<int>());
        }

        static void Gen(int n, int x, List<int> numbers)
        {
            if((numbers.Count()!=1) && (numbers.Sum()==n))
            {
                Console.WriteLine(string.Join("+", numbers));
            }

            for (int i = x; i >0; i--)
            {
                var nums = new List<int>(numbers);
                nums.Add(i);
                if ((numbers.Count() ==0) ||((numbers.Count() > 0) && (numbers.Last()>= i)))
                {
                    Gen(n, x - i, nums);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public static class Fibonaci
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int[] f = new int[n];
            f[0] = 1;
            f[1] = 1;
            for (int i = 2; i < n; i++)
            {
                f[i] = f[i - 2] + f[i - 1];
            }
            Console.WriteLine(string.Join(" ", f));
        }
    }
}

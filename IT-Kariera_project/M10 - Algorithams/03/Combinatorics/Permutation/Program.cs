using System;

namespace Permutation
{
    class Program
    {
       static int n = 4;
       static int[] elements = { 1, 2, 3, 4};
        static bool[] used = new bool[n];
       static int[] perm = new int[n];

        static void Main(string[] args)
        {
           Gen(0);
        }
        public static void Gen(int index)
        {
            if (index >= elements.Length)
                Console.WriteLine(string.Join(" ", perm));
            else
                for (int i = 0; i < elements.Length; i++)
                    if (!used[i])
                    {
                        used[i] = true;
                        perm[index] = elements[i];
                        Gen(index + 1);
                        used[i] = false;
                    }
        }
    }
}

using System;

namespace binomCoef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
             Console.Write(binom(n,i)+" ");
            }
            

        }
       static int binom(int n, int k)
        {
            if (n == k || k == 0) return 1;
            return binom(n - 1, k) + binom(n - 1, k - 1);
        }
        


    }
}

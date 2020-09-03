using System;

namespace Fibonaci
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 5;

            int fibN = Fib(n);

            Console.WriteLine(fibN);
        }

        public static int Fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);
        }

    }
}

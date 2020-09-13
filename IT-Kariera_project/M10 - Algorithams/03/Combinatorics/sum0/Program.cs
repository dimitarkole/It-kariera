using System;

namespace sum0
{
    class Program
    {
        static int n = 8;
        static int[] elem = { 1,2,3,4,5,6,7,8};
        static int sum = 0;
        static void Main(string[] args)
        {
            variate(0);
        }
        static void checkSol()
        {
            int tempSum = 0;
            for (int i = 0; i < n; i++)
            {
                tempSum += elem[i];
            }
            if (tempSum == sum)
            {

                for (int j = 0; j < n; j++)
                {
                    if (elem[j] > 0)
                    {
                        Console.Write("+" + elem[j] + " ");
                    }
                    else 
                    {
                        Console.Write( elem[j] + " ");
                    }
                }Console.WriteLine("="+" "+tempSum);
            }
            
        }
        static void variate(int i)
        {
            if (i >= n)
            {
                checkSol();
                return;
            }
            elem[i] = Math.Abs(elem[i]); variate(i + 1);
            elem[i] = -Math.Abs(elem[i]); variate(i + 1);
        }
    }
}

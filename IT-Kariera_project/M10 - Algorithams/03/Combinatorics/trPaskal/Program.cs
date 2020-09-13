using System;

namespace trPaskal
{
    class Program
    { static int n = 10;
        static int[,] tr=new int[n,n];
        static void Main(string[] args)
        {
            generate();
            print();
        }
        static void print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(tr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void generate()
        {
            tr[0, 0] = 1;
            tr[1, 0] = 1;tr[1, 1] = 1;
            for (int j = 0; j < n; j++)
            {
                tr[j, 0] = 1;
                tr[j, j] = 1;
            }
            for (int i=2 ; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    tr[i, j] = tr[i - 1, j] + tr[i - 1, j - 1];
                }
            }
        }
    }
}

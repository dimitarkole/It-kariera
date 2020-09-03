using System;

namespace EightQeen
{
    class Program
    {
        static int n=8;
        static int maxN = 100;
        static bool[] col= new bool[maxN];
        static bool[] rd = new bool[2*maxN-1];
        static bool[] ld = new bool[2 * maxN];
        static int[] queens = new int[maxN];
        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
            {
                col[i] = true;
            }
            for (int i = 0; i < 2*n-1; i++)
            {
                rd[i] = true;
            }
            for (int i = 0; i < 2*n; i++)
            {
                ld[i] = true;
            }
            generate(0);
        }
        static void printBoard()
        {

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    if (queens[i] == j)
                    {
                        Console.Write("x  ");
                    }
                    else
                    {
                        Console.Write(".  ");
                    }
                }
                Console.WriteLine();
            }Console.WriteLine("Variant " );
        }
        static void generate(int i)
        {

            if (i == n )
            {
                printBoard();
            }
            for (int j = 0; j < n; j++)
            {
                if (col[j] && rd[i + j] && ld[n + i - j])
                {
                    col[j] = false; 
                    rd[i + j] = false;
                    ld[n + i - j] = false;
                    queens[i] = j;
                    generate(i + 1);
                    col[j] = true;
                    rd[i + j] = true;
                    ld[n + i - j] = true;
                }


            }
        }
        
    }
}

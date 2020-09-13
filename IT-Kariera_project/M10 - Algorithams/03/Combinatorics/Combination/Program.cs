using System;

namespace Combination
{
    class Program
    {static int n = 4, k = 2;
       static int[] combination = new int[k];
        static void Main(string[] args)
        {
            int[] elem = {1,2,3,4,5};
            comb(1, 0);
        }
        
        static void comb(int i, int after) 
        {
            
            if (i>k )
            {
                return;
            }
           
               
                for (int j = after+1; j <= n; j++)
                {
                    combination[i-1] = j;
                if (i == k)
                {
                    Console.WriteLine(string.Join(" ", combination));
                    
                }
                    comb(i + 1, j);
                }
                
                 
            
        }
    }
}

using System;

namespace NOD
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateNod(15, 21);
        }
        static void calculateNod(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("Nod=" + a);
            }
            else
            {
                if (a > b)
                {
                    calculateNod(a - b, b);
                }
                else
                {
                    calculateNod(a, b - a);
                }
            }
        }
    }
}

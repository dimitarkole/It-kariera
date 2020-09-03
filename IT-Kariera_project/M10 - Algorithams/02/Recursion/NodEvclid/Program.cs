using System;

namespace NodEvclid
{
    class Program
    {
        static void Main(string[] args)
        {
            calculateNod(20,15);
        }
        static void calculateNod(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Nod=" + a);
            }
            else
            {

                calculateNod(b, a % b);

            }
        }
    }
}

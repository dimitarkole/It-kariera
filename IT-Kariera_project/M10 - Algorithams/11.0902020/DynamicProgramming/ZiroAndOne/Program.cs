using System;

namespace ZiroAndOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3; // int.Parse(Console.ReadLine());

            //с цикъл
            int  b1 = 2;
            int b = 0;
            if(n>1)
            {
                int b2 = 3;
                b = b2;
                if(n>2)
                {
                    for (int i = 3; i <= n; i++)
                    {
                        b = b2 + b1;
                        b1 = b2;
                        b2 = b;
                    }
                }               
            }
           
            Console.WriteLine(b);

        }
    }
}

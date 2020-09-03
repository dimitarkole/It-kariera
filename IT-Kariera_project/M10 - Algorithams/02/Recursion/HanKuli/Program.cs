using System;

namespace HanKuli
{
    class Program
    {
        static int n = 4;
        static void Main(string[] args)
        {
            Console.WriteLine($"Broj diskove: {n}");
            honoy('A','C','B',n);
        }
        static void diskMove(int n, char a, char b)
        {
            Console.WriteLine($"Premestete disk {n} ot {a} na {b}");

        }
        static void honoy(char a, char c, char b, int numb)
        {
            if (numb == 1)
            {
                diskMove(1, a, c);
            }
            else 
            {
                honoy(a, b, c, numb - 1);
                diskMove(numb,a,c);
                honoy(b,c,a,numb-1);
            }
        }
    }
}

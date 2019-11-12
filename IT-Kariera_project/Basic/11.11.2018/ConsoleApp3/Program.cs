using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Diamond();
        }

        static void RectangleOf10x10Stars()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new String('*',10));
            }
        }

        static void RectangleOfNxNStars()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new String('*', n));
            }
        }

        static void SquareOfNxNStars()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine('*');
                for (int J = 0; J < n; J++)
                {
                    Console.Write(" *");
                }
            }
        }

        static void TriangleOfDollar()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine('*');
                for (int J = 0; J < i; J++)
                {
                    Console.Write(" *");
                }
            }
        }

        static void SquareFrame()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
        }

        static void DiamondOfStars()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new String(' ',n-i-1));
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(new String(' ', n - i - 1));
                Console.WriteLine();
            }

            for (int i = n-2; i >=0; i--)
            {
                Console.Write(new String(' ', n - i - 1));
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(new String(' ', n - i - 1));
                Console.WriteLine();
            }
        }

        static void ChristmasTree()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}|{0}",new String(' ',n+1));
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new String(' ', n + 1-i), new String('*', i));
            }
        }

        static void SunGlasses()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new String('*', n * 2 ), new String(' ', n ));
            for (int i = 0; i < n-2; i++)
            {
                char simvol = ' ';
                if ((n - 1) / 2 - 1 == i) simvol = '|';
                Console.WriteLine("*{0}*{1}*{0}*", new String('/', n * 2-2), new String(simvol, n));
            }
            Console.WriteLine("{0}{1}{0}", new String('*', n * 2), new String(' ', n));
        }

        static void House()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new String('-', (n -(2-n % 2 ))/2), new String('*', 2-n%2));
            for (int i = 1; i <= (n + 1) / 2-1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new String('-', (n - (2 - n % 2)-i*2) / 2), new String('*', 2 - n % 2+i*2));
            }
            for (int i = 1; i <= (n + 1) / 2 - 1; i++)
            {
                Console.WriteLine("|{0}|",  new String('*', n-2));
            }
        }

        static void Diamond()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{0}", new String('-', (n - 1)/2));
            for (int i = 1; i < n/2+1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new String('-', (n - i - 2)/2), new String('-', i*2-1));
            
            }
            for (int i = n / 2 -1; i >0; i--)
            {
                Console.WriteLine("{0}*{1}*{0}", new String('-', (n - i - 2) / 2), new String('-', i * 2 - 1));

            }
            Console.WriteLine("{0}*{0}", new String('-', (n - 1) / 2));
        }
    }
}

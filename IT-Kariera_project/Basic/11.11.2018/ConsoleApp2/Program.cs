using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            tenth();
        }
        static void first()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void second()
        {
            for (int i = 7; i <= 1000; i += 10)
            {
                Console.WriteLine(i);
            }
        }

        static void tird()
        {
            for (char i = 'a'; i <= 'z'; i ++)
            {
                Console.WriteLine(i);
            }
        }

        static void fourth()
        {
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <n; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }

        static void fifth()
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for (int i = 0; i < n; i++)
            {
                number[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine(number.Max());
        }

        static void sixth()
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(number.Min());
        }

        static void seventh()
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            int sum1=number.Sum();
            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            int sum2 = number.Sum();
            if (sum1 == sum2) Console.WriteLine("Yes, sum = {0}",sum1);
            else Console.WriteLine("No, diff = {0}",Math.Abs( sum1-sum2));
        }

        static void nineth()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd=0, sumEven=0;

            for (int i = 0; i < n; i++)
            {
                if (i%2==0) sumOdd += int.Parse(Console.ReadLine());
                else sumEven += int.Parse(Console.ReadLine());
            }
            if (sumOdd == sumEven) Console.WriteLine("Yes, sum = {0}", sumEven);
            else Console.WriteLine("No, Diff = {0}", Math.Abs(sumOdd - sumEven));
        }

        static void tenth()
        {
            int n = int.Parse(Console.ReadLine());
            int maxDiff = 0;
            int sum1 = 0, sum2 = 0, flag = 0;
            for (int i = 0; i < n; i++)
            {
                int a= int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (i >=1)
                {
                    if (i==1) sum2 = sum1;
                    if (sum2!=sum1)
                    {
                        if (maxDiff<sum1-sum2)
                        {

                        }
                    }
                }
                sum1=a+b;
                
            }
           
            if (flag == 0) Console.WriteLine("Yes, value={0}", sums[0]);
            else Console.WriteLine("No, maxdiff={0}", sums.Max() - sums.Min());

        }
    }
}

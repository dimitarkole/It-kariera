using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            task2();
        }
        
        static void task1()
        {
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Min = {0}",masiv.Min());
            Console.WriteLine("Max = {0}", masiv.Max());
            Console.WriteLine("Sum = {0}", masiv.Sum());
            Console.WriteLine("Average = {0}", masiv.Average());
        }

        static void task2()
        {
            ushort[] masiv = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int maxCount=0, maxNumber=0;
            for (int i = 0; i < masiv.Length; i++)
            {
                int count = 0;
                count++;
                for (int j = 0; j < masiv.Length; j++)
                {
                    if (masiv[i] == masiv[j]) count++;

                }
                if (count > maxCount) { maxCount = count - 1; maxNumber = masiv[i]; }
                else if (count == maxCount)
                {
                    //todo
                }
            }
            Console.WriteLine(maxNumber);
        }

        static void task3()
        {
            string masiv = Console.ReadLine();
            for (int i = 0; i < masiv.Length; i++)
            {
                char letter = masiv[i];
                Console.WriteLine("{0} -> {1}", letter,(int)(letter)-97);
            }
        }

        static void task4()
        {
            ushort[] nums = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int number = nums[0];
            while (nums.Length > 1)
            {
                ushort[] condensed = new ushort[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    condensed[i] = (ushort)(nums[i] + nums[i + 1]);
                }
                number = condensed[0];
                nums = condensed;
            } 
            Console.WriteLine(number);
        }
    }
}


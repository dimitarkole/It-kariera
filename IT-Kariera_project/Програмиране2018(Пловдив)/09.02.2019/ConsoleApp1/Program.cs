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
            task4();
        }

        static void task1()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine("list[{0}] = {1}", index, list[index]);
            }
        }

        static void task2()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {

                    Console.Write("{0} ", list[i]);
                }
            }

        }

        static void task3()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            List<int> min = new List<int>();
            List<int> max = new List<int>();
            foreach (int number in list)
            {
                if (number == list.Min()) min.Add(number);
                else if (number == list.Max()) max.Add(number);
            }
            Console.WriteLine("{0} {1}", string.Join(" ", min), string.Join(" ", max));
        }

        static void task4()
        {
            List<ushort> list = Console.ReadLine().Split(' ').Select(ushort.Parse).ToList<ushort>();
            ushort maxCount = 0, maxNumber=0;
            for(int i=0; i<list.Count; i++)
            {
                ushort count = 0;
                ushort number = list[i];
                
                while ((number == list[i])|| (i < list.Count - 1))
                {
                    count++;
                    i++;
                }
                Console.WriteLine("{0} {1}", number, count);
                if (count > maxCount)
                {
                    maxCount++;
                    maxNumber = number;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(maxNumber);
            }            
        }

        static void task5()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            int sum = 0;
            for (int i = 0; i < list.Count ; i++)
            {
                int numberOfList = list[i], newNumber = 0;
                do
                {
                    newNumber = newNumber * 10 + numberOfList % 10;
                    numberOfList /= 10;
                } while (numberOfList>0);
                sum += newNumber;
            }
            Console.WriteLine(sum);
        }

        static void task7()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            int removeNum = list[list.Count - 1];
            while (list.Remove(removeNum)==true)
            {

            }
            Console.WriteLine(string.Join(" ", list));
        }

        static void task8()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList<int>();
            List<int> newList = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] > 0) newList.Add(list[i]);
            }
            if (newList.Count > 0) Console.WriteLine(string.Join(" ", newList));
            else Console.WriteLine("Empty");
        }

        static void task9()
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            lists.Reverse();
            List<int> result = new List<int>();
            foreach (string list in lists)
            {
                List<int> intList = list.Split(' ').Select(int.Parse).ToList();
                for (int j = 0; j < intList.Count; j++)
                {
                    result.Add(intList[j]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        static void task10()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));
        }

        static void task11()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            foreach (int number in numbers)
            {
                if (Math.Sqrt(number) == (int)Math.Sqrt(number)) result.Add(number);
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }

        static void task12()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            var pos = 0;
            while (pos < nums.Count)
            {
                int num = nums[pos], count = 1;
                while (pos + count < nums.Count &&
                  nums[pos + count] == num)
                    count++;
                pos = pos + count;
                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}

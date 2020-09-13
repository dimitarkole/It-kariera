using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonaci.Run();
            Console.WriteLine("Capacity: ");
            int capasity = int.Parse(Console.ReadLine());
            Console.WriteLine("Count items: ");
            int countItems = int.Parse(Console.ReadLine());
            List<Item> items = new List<Item>();
            for (int i = 0; i < countItems; i++)
            {
                var newItem = new Item();
                newItem.Value = int.Parse(Console.ReadLine());
                newItem.Weight = int.Parse(Console.ReadLine());
                items.Add(newItem);
            }

            var result = items.FillKnapsack(capasity);

            Console.WriteLine("Sum of Value:" + result.Sum(x => x.Value));
            Console.WriteLine("Sum of Weight:" + result.Sum(x => x.Weight));
            Console.WriteLine(string.Join("\n", result));
        }
    }
}

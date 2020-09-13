
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public static class Extention
    {
        public static List<Item> FillKnapsack(this List<Item> items, int capacity)
        {
            int[,] maxValues = new int[items.Count + 1, capacity + 1];
            bool[,] itemIncluded = new bool[items.Count + 1, capacity + 1];

            // Calculate maxValues
            for (int i = 0; i < items.Count; i++)
            {
                for (int currCapacity = 1; currCapacity <= capacity; currCapacity++)
                {
                    if (items[i].Weight > currCapacity) continue;
                    int valueIncluded = items[i].Value + maxValues[i, currCapacity - items[i].Weight];
                    if (valueIncluded > maxValues[i, currCapacity])
                    {
                        maxValues[i + 1, currCapacity] = valueIncluded;
                        itemIncluded[i + 1, currCapacity] = true;
                    }
                    else
                        maxValues[i + 1, currCapacity] = maxValues[i, currCapacity];
                }
            }

            // Return the items in the knapsack
            // return the taken items in the knapsack
            List<Item> takenItems = new List<Item>();
            for (int i = items.Count; i > 0; i--)
            {
                if (!itemIncluded[i, capacity]) continue;

                Item item = items[i - 1];
                takenItems.Add(item);

                capacity -= item.Weight;
            }

            return takenItems;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_4._2
{
    class InsertSort
    {
        public static void SortUp<T>(T[] collection) where T : IComparable<T>
        {   
            int n = collection.Length;
            for (int i = 1; i < n; ++i)
            {
                T key = collection[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while((j >= 0) && (collection[j].CompareTo(key)>0))
                {
                    collection[j + 1] = collection[j];
                    j = j - 1;
                }
                collection[j + 1] = key;
            }

        }

    }
}

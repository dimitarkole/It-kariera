using System;
using System.Collections.Generic;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_4._1WordFile
{
    class SelectionSort
    {
        public static void SortUp<T>(T[] collection)  where T: IComparable<T>
        {
            for (int index = 0; index < collection.Length; index++)
            {
                int min = index;
                for (int curr = index + 1; curr < collection.Length; curr++)
                {

                    if (collection[curr].CompareTo(collection[min])<0)
                    {
                        min = curr;
                    }
                }
                Swap(collection, index, min);
            }
            
        }

        public static void SortDown<T>(T[] collection) where T : IComparable<T>
        {
            for (int index = 0; index < collection.Length; index++)
            {
                int min = index;
                for (int curr = index + 1; curr < collection.Length; curr++)
                {
                    if (Less((IComparable)collection[curr],(IComparable) collection[min])==false)
                    {
                        min = curr;
                    }
                }
                Swap(collection, index, min);
            }

        }

        static void Swap<T>(T[] collection, int from, int to) where T : IComparable<T>
        {
            T a = collection[to];
            collection[to] = collection[from];
            collection[from] = a;
        }


        static bool Less(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

    }
}

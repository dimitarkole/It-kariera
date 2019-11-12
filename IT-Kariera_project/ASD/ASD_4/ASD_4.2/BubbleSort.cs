using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_4._2
{
    class BubbleSort
    {
        public static void SortUp<T>(T[] collection) where T : IComparable<T>
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int index = 0; index < collection.Length - 1; index++)
                {
                    for (int curr = collection.Length - 1; curr > 0; curr--)
                    {

                        if (Less((IComparable)collection[curr - 1], (IComparable)collection[curr]))
                        {
                            Swap(collection, curr - 1, curr);
                            flag = true;
                        }
                    }
                }
            }

        }

        public static void SortDown<T>(T[] collection) where T : IComparable<T>
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int index = 0; index < collection.Length - 1; index++)
                {
                    for (int curr = collection.Length - 1; curr > 0; curr--)
                    {
                        if (Less((IComparable)collection[curr - 1], (IComparable)collection[curr]) == false)
                        {
                            Swap(collection, curr - 1, curr);
                            flag = true;
                        }
                    }
                }

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

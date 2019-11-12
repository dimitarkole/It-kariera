using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_5
{
    class BinarySearch
    {
        public static int IndexOf(int[] collection, int key)
        {
            int lo = 0;
            int hi = collection.Length - 1;
            while (lo<=hi)
            {
                int mid = (lo + hi) / 2;
                if(key< collection[mid])
                {
                    hi = mid - 1;
                }
                else if(key > collection[mid])
                {
                    lo = mid + 1;
                }
                 else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}

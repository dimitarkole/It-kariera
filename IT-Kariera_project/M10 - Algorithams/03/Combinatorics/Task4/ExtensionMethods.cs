using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public static class ExtensionMethods
    {
        public static double Multiplication(this List<int> numbers)
        {
            var result = 1.0;
            foreach (var number in numbers)
            {
                result *= number;
            }
            return result;
        }

        public static bool IsDo(this List<int> numbers, int n, int i) =>
            (n % i == 0) && ((numbers.Count() == 0)) || (numbers.Count() > 0);

    }
}

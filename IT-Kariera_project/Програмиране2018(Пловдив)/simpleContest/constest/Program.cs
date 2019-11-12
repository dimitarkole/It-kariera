using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constest
{
    class Program
    {

        static void Main(string[] args)
        {
            task1();
        }

        static void task1()
        {
            short n = short.Parse(Console.ReadLine());
            List<decimal> birds= new List<decimal>();
            for (int i = 0; i < n; i++)
            {
                long totalLength= long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long wingLength = long.Parse(Console.ReadLine());
                decimal decimalResult = totalWidth - (int)totalWidth;
                string stringResult = decimalResult.ToString();
                int length = stringResult.Substring(stringResult.IndexOf(",")).Length;

                decimal totalsYear = ((decimal)Math.Pow(totalLength, 2)) * (totalWidth + 2 * wingLength);
                totalsYear = Math.Round(totalsYear, length);
                birds.Add(totalsYear);
            }

            Console.WriteLine("{0} phoenixes:",n);
            foreach(var bird in birds)
            {
                Console.WriteLine(bird);
            }
        }
    }
}

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
            string input = Console.ReadLine().ToLower();
            double[] numbers = input.Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var num in numbers)
            {
                if (counts.ContainsKey(num)) counts[num]++;
                else counts[num] = 1;
            }
            foreach (var pair in counts)
            {
                Console.WriteLine("{0} -> {1}",pair.Key,pair.Value);
            }
        }

        static void task2()
        {
            string input = "";
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            do
            {
                input = Console.ReadLine();
                if (input == "END") break;
                if (input == "ListAll")
                {
                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                    }
                }
                else
                {
                    string[] results = input.Split(' ');
                    if (results[0] == "A") phonebook[results[1]] = results[2];
                    else
                    {
                        if (phonebook.ContainsKey(results[1]))
                        {

                            Console.WriteLine("{0} -> {1}", results[1], phonebook[results[1]]);
                        }
                        else Console.WriteLine("Contact {0} does not exist.", results[1]);
                    }
                }
            } while (input!="END");
        }
    }
}

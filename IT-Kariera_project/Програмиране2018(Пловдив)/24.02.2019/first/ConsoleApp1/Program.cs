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
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word)) counts[word]++;
                else counts[word] = 1;
            }
            List<string> results = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1) results.Add(pair.Key);
            }

            Console.WriteLine(string.Join(", ", results));
        }

        static void task2()
        {
            string input = "";
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            do
            {
                input = Console.ReadLine();
                if (input == "END") break;
                string[] results = input.Split(' ');
                if(results[0]=="A") phonebook[results[1]] = results[2];
                else
                {
                    if (phonebook.ContainsKey(results[1]))
                    {

                        Console.WriteLine("{0} -> {1}", results[1], phonebook[results[1]]);
                    }
                    else Console.WriteLine("Contact {0} does not exist.", results[1]);
                }


            } while (input!="END");
        }


        static void task3()
        {
           
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "stop") 
            {
                int quantity = int.Parse(Console.ReadLine());
                if (resourses.ContainsKey(input)) resourses[input]+= quantity;
                else resourses[input] = quantity;
                input = Console.ReadLine();
            }

            foreach (var resourse in resourses)
            {
                Console.WriteLine("{0} -> {1}", resourse.Key, resourse.Value);
            }
        }

        static void task4()
        {
            Dictionary<string, double[]> resourses = new Dictionary<string, double[]>();
            string input = Console.ReadLine();
            while (input != "stocked") 
            {
                string[] info = input.Split(' ');
                double[] arr = { double.Parse(info[1]), double.Parse(info[2])};
                if (resourses.ContainsKey(info[0])) resourses[info[0]]=arr;
                else resourses[info[0]] = arr;
                input = Console.ReadLine();
            } 
            double sum = 0;
            foreach (var resourse in resourses)
            {
                double[] values = resourse.Value;
                double price = values[0] * values[1];
                sum += price;
                Console.WriteLine("{0}: ${1:0.00} * {2} = ${3:0.00}", resourse.Key, values[0], values[1],price);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Grand Total: ${0:0.00}",sum);
        }
    }
}

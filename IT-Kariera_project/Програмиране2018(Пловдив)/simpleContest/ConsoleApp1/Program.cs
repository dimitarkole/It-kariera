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
            task4_2(); 
        }

        static void task1()
        {
            decimal priceBitcoin = decimal.Parse(Console.ReadLine());
            decimal priceEthereum = decimal.Parse(Console.ReadLine());
            decimal priceLitecoin = decimal.Parse(Console.ReadLine());
            int countInvestition = int.Parse(Console.ReadLine());
            decimal availableFunds = 0M;
            for (int i = 0; i < countInvestition; i++)
            {
                int countАssets = int.Parse(Console.ReadLine());
                string valute = Console.ReadLine();
                string method = Console.ReadLine();
                decimal price = 0M;
                if (valute== "Bitcoin")price = countАssets * priceBitcoin;
                else if (valute == "Litecoin")price=countАssets* priceLitecoin;                    
                else price = countАssets * priceEthereum;

                price = price - price * 0.073456764216789345M;

                if (method == "Bay") availableFunds -= price;
                else availableFunds += price;
            }
            Console.WriteLine("{0:0.0000000000000000}", availableFunds);
        }

        static void task2()
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string command = Console.ReadLine();
            while(command!= "print")
            {
                string[] arrCommand = command.Split(' ');
                if (arrCommand[0] == "push") numbers.Add(int.Parse(arrCommand[1]));
                else if (arrCommand[0] == "pop")
                {
                    Console.WriteLine(numbers[numbers.Count - 1]);
                    numbers.RemoveAt(numbers.Count - 1);
                }
                else if (arrCommand[0] == "shift")
                {
                    long number = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                    numbers[0] = number;
                }
                else if (arrCommand[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(arrCommand[1]));
                }
                else if(arrCommand[0]== "addMany")
                {
                    int startPosition = int.Parse(arrCommand[1]);
                    int endPosition = startPosition+ arrCommand.Length-2;
                    if(startPosition<numbers.Count)
                    {
                        for (int i = 2; i < arrCommand.Length; i++)
                        {
                            numbers.Add(0);
                            for (int j = numbers.Count - 2; j >= startPosition; j--)
                            {
                                numbers[j+1] = numbers[j];
                            }
                            numbers[startPosition] = int.Parse(arrCommand[i]);
                            startPosition++;
                        }
                       
                    }
                    
                }
                command = Console.ReadLine();
            }

            numbers.Reverse();
            Console.WriteLine(string.Join(", ",numbers));           
        }

        static void task3()
        {
            string input = Console.ReadLine();
            string shablon = Console.ReadLine();
            do
            {
                int lastIndexOfShablon = input.LastIndexOf(shablon);
                if (lastIndexOfShablon > -1)input=input.Remove(lastIndexOfShablon,shablon.Length);
                else break;
                shablon = shablon.Substring(0, shablon.Length / 2) + shablon.Substring(shablon.Length/2 + 1);
            } while (shablon.Length>0);
            Console.WriteLine(input);

        }


        static void task4()
        {
            SortedDictionary <string, string> inputCitis = new SortedDictionary<string, string>();
            Dictionary<string, int> countCountries = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] paramitars = input.Split(' ').ToArray();
                if (paramitars[0] == "Add")
                {
                    inputCitis[paramitars[2]]=paramitars[1];
                    if (countCountries.ContainsKey(paramitars[1])) countCountries[paramitars[1]] += 1;
                    else countCountries[paramitars[1]] = 1;
                }
                else if (paramitars[0] == "Remove")
                {
                    if (inputCitis.ContainsKey(paramitars[1])) inputCitis.Remove(paramitars[1]);
                    else Console.WriteLine("City {0} not found", paramitars[1]);
                }

                input = Console.ReadLine();
            }

            countCountries = countCountries.OrderBy(pair => pair.Value).Reverse().ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var countri in countCountries)
            {
                List<string> citisInCountry = inputCitis.Where(pair => pair.Value==countri.Key).Select(pair => pair.Key).ToList();
                Console.Write("{0} has {1} cities and they are: ",
                    countri.Key, citisInCountry.Count);
                Console.Write(string.Join(", ", citisInCountry));
                Console.WriteLine();
            }

        }

        static void task4_2()
        {
            Dictionary<string, List<string>> touristDistination = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                Console.WriteLine(command);
                string[] commandArgs = command.Split(' ').ToArray();
                if (commandArgs[0] == "Add")
                {
                    string countryName = commandArgs[1];
                    string cityName = commandArgs[2];
                    if (!touristDistination.ContainsKey(countryName))
                    {
                        touristDistination.Add(countryName, new List<string>());
                    }
                    touristDistination[countryName].Add(cityName);
                }
                else if (commandArgs[0] == "Remove")
                {
                    string cityName = commandArgs[1];
                    bool cityIsRemove = false;
                    foreach (List<string> citys in touristDistination.Values)
                    {
                        if (citys.Contains(cityName))
                        {
                            citys.Remove(cityName);
                            cityIsRemove = true;
                            break;
                        }

                    }
                    if (!cityIsRemove)
                    {
                        Console.WriteLine($"City {cityName} not found");
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in touristDistination.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} has {item.Value.Count} cities and they are: {string.Join(", ", item.Value.OrderBy(x => x))}");
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
        }

        static void task1()
        {
            string[] inputStrings = Console.ReadLine().Split(' ').ToArray();
            string firstString = inputStrings[0];
            string secondString = inputStrings[1];
            bool flag = false;

            if (firstString.Length==secondString.Length)
            {
                flag = true;
                Dictionary<char, char> letters = new Dictionary<char, char>();
                letters.Add(firstString[0], secondString[0]);
                for (int i = 1; i < firstString.Length; i++)
                {
                    if(letters.ContainsKey(firstString[i])==true)
                    {
                        char value = letters[firstString[i]];
                        if (value != secondString[i])
                        {
                            flag = false;
                            break;
                        }
                    }
                    else
                    {
                        if (letters.ContainsValue(secondString[i]) == true)
                        {
                            flag = false;
                            break;
                        }
                        letters.Add(firstString[i], secondString[i]);
                    }

                }
            }
            Console.WriteLine(flag);

        }
    }
}

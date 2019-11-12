    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp2
    {
        class Program
        {
            static void Main(string[] args)
            {
                EvenNumberWithCheck();
            }
        
            static void EvenNumberWithCheck()
            {
                int n=0;
                do
                {
                    string line = Console.ReadLine();
                    try
                    {
                        number = int.Parse(line);
                        if (number % 2 == 0){
                             Console.WriteLine("{0}", number);
                             break;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                } while (true);
            }
        }
    }

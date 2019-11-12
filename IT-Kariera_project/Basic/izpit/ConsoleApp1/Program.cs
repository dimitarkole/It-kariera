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
            UniqueCombinations();
        }

        static void GoSkiing()
        {
            double countSkiors = double.Parse(Console.ReadLine());
            double priceQketa = double.Parse(Console.ReadLine())*120;
            double priceKaski = double.Parse(Console.ReadLine())*75;
            double priceObuvki = double.Parse(Console.ReadLine())*299.90;
            double sum = priceKaski+priceObuvki+priceQketa;
            Console.WriteLine(countSkiors*sum*1.2);
        }

        static void Pets()
        {
            int days = int.Parse(Console.ReadLine());
            double foodLeft = double.Parse(Console.ReadLine());
            double foodForCat1 = double.Parse(Console.ReadLine());
            double foodForCat2 = double.Parse(Console.ReadLine());
            double sumFoodForCats = (foodForCat1 + foodForCat2)* days;
            if (foodLeft>=sumFoodForCats)
            {
                Console.WriteLine("The cats are well fed.");
                Console.WriteLine("{0} kilos of food left.", Math.Ceiling(foodLeft-sumFoodForCats));
            }
            else
            {
                Console.WriteLine("The cats are hungry.");
                Console.WriteLine("{0} more kilos of food are needed.", Math.Floor(sumFoodForCats- foodLeft));
            }
        }

        static void Hotel()
        {
            int days = int.Parse(Console.ReadLine());
            string stay = Console.ReadLine();
            double sum = 0;
            if (stay == "apartment") {
                sum = days * 70;
                if (days < 10) sum *= 0.7;
                if ((days >= 10)&&(days <=15)) sum *= 0.65;
                if (days > 15) sum *= 0.50;
            }
            else
            {
                sum = days * 125;

                if (days < 10) sum *= 0.9;
                if ((days >= 10) && (days <= 15)) sum *= 0.85;
                if (days > 15) sum *= 0.80;
            }
            Console.WriteLine(sum);
        }

        static void TakingCare()
        {
            double foodLeft = double.Parse(Console.ReadLine()) * 1000;
            int days = int.Parse(Console.ReadLine());
            for (int i = 0; i < days; i++)
            {
                foodLeft -= int.Parse(Console.ReadLine());
            }
            if (foodLeft >= 0) Console.WriteLine("Food is enough! Leftovers: {0} grams.", foodLeft);
            else Console.WriteLine("Food is not enough. You need {0} grams more.", foodLeft*(-1));

        }

        static void UniqueCombinations()
        {
            int inputA = int.Parse(Console.ReadLine());
            int inputB = int.Parse(Console.ReadLine());
            for (int A = inputA; A < 123; A++)
            {
                for (int B = inputB; B < 123; B++)
                {
                    for (int x = 1; x <= 9; x++)
                    {
                        for (int y = 1; y <= 9; y++)
                        {
                            if ((B > A)&&(x + y == 9))
                            {
                                Console.Write("{0}{1}{2}{3} ", (char)A, (char)B,x,y);
                            }
                        }
                    }
                }
            }
        }
    }
}

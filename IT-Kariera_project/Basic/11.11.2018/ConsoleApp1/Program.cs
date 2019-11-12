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
            ninethTask();
        }

        static void fistTask()
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            if (sex=="m"){
                if (age >= 16) Console.WriteLine("Mr.");
                else Console.WriteLine("Master");      
            }
            else{
                if (age >= 16) Console.WriteLine("Ms.");
                else Console.WriteLine("Miss");
            }
        }

        static void secondTask()
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0;
            if (city== "Sofia"){
                if (product == "coffee") price = 0.5;
                else if (product == "water") price = 0.8;
                else if (product == "beer") price = 1.2;
                else if (product == "sweets") price = 1.45;
                else price = 1.6;
            }
            else if (city == "Plovdiv"){
                if (product == "coffee") price = 0.40;
                else if (product == "water") price = 0.7;
                else if (product == "beer") price = 1.15;
                else if (product == "sweets") price = 1.30;
                else price = 1.5;
            }
            else{
                if (product == "coffee") price = 0.45;
                else if (product == "water") price = 0.7;
                else if (product == "beer") price = 1.10;
                else if (product == "sweets") price = 1.35;
                else price = 1.55;
            }
            Console.WriteLine(price*count);
        }

        static void teardTask()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double xT = double.Parse(Console.ReadLine());
            double yT = double.Parse(Console.ReadLine());
            if (xT >= x1 && xT <= x2 && yT >= y1 && yT <= y2) Console.WriteLine("Inside");
            else Console.WriteLine("Outside");
        }

        static void foutrthTask()
        {
            string[] fruit = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] vegetable = { "tomato", "cucumber", "pepper", "carrot" };
            string product = Console.ReadLine();
            int flag = 0;
            for (int i = 0; i < fruit.Length; i++)
            {
                if (product== fruit[i])
                {
                    Console.WriteLine("fruit");
                    flag = 1;
                }
            }

            for (int i = 0; i < vegetable.Length; i++)
            {
                if (product == vegetable[i])
                {
                    Console.WriteLine("vegetable");
                    flag = 1;
                }
            }
            if (flag == 0) Console.WriteLine("unknown");
        }

        static void fiftTask()
        {
            int number = int.Parse(Console.ReadLine());
            var inRange = (number >= 100 && number <= 200) || number==0;
            if (!inRange) Console.WriteLine("Invalid");
           
        }

        static void sixthTask()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double xT = double.Parse(Console.ReadLine());
            double yT = double.Parse(Console.ReadLine());
            if ((xT == x1 || xT == x2) && (yT >= y1) && (yT <= y2)) Console.WriteLine("Border");
            else if ((yT == y1 || yT == y2) && ((xT >= x1) && (xT <= x2))) Console.WriteLine("Border");
            else Console.WriteLine("Inside / Outside");
        }

        static void sevethTask()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Error" };
            int day = int.Parse(Console.ReadLine());
            if (day >= 1 && day <= 7) Console.WriteLine(days[day-1]);
            else Console.WriteLine(days[7]);
        }

       static void eigthTask()
        {
            string animal =Console.ReadLine();
            switch (animal)
            {
                case "dog": Console.WriteLine("mammal");break;
                case "crocodile":
                case "tortoise":
                case "snake": Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown");break;
            }
        }

        static void ninethTask()
        {
            string vid =Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 12;
            if (vid == "Normal") price = 7.50;
            else if (vid == "Discount") price = 5;
            Console.WriteLine("{0:0.00}", price*r*c);
        }
    }
}

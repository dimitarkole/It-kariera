using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            sixTask();
        }

        static void sixTask()
        {
            int[] data = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            DateTime myDate = new DateTime(data[2], data[1], data[0]);
            myDate = myDate.AddDays(999);
            Console.WriteLine(string.Format("{0:00}", myDate.Day) + "+");
            Console.Write(string.Format("{0:00}", myDate.Month) + "-");
            Console.Write("{0:0000}", myDate.Year);
        }

        static void sevetTask()
        {
            double w = double.Parse(Console.ReadLine()) * 100;
            double h = double.Parse(Console.ReadLine()) * 100;
            double row = Math.Floor(w / 120);
            double coll = (Math.Floor((h - 100) / 70));
            double countWork = row * coll - 3;
            Console.WriteLine(countWork);
        }

        static void eithinTask()
        {
            double kgVegetables = double.Parse(Console.ReadLine());
            double priceVegetables = double.Parse(Console.ReadLine());
            double kgFruts = double.Parse(Console.ReadLine());
            double priceFruts = double.Parse(Console.ReadLine());
            double curencyFruts = kgFruts * priceFruts;
            double curencyVegetables = kgVegetables * priceVegetables;
            double price = curencyFruts + curencyVegetables;
            Console.WriteLine(string.Format("{0:0.00}", price * 1.96));
        }

        static void nine()
        {
            double n = double.Parse(Console.ReadLine());
            double SPloshadka = n * n;
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double SPlochka = w*l;
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());
            double SPejka = m * o;
            double countPlochki = (SPloshadka- SPejka)/ SPlochka;
            Console.WriteLine(countPlochki);
            Console.WriteLine(countPlochki*0.2);
        }

        static void tenTask()
        {
            int bitkoin = int.Parse(Console.ReadLine());
            double una = double.Parse(Console.ReadLine());
            double comisionna = double.Parse(Console.ReadLine());
            double lv = bitkoin * 1168 + una * 0.15 * 1.76;
            Console.WriteLine(string.Format("{0:0.00}",lv* 1.95));
        }

        static void elevenTask()
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double danak = double.Parse(Console.ReadLine());
            double brutoSelary = n * m * 14.5;
            double netoSelary = brutoSelary*(100-danak)/100;
            Console.WriteLine(string.Format("{0:0.00}", netoSelary/365));
        }
    }
}

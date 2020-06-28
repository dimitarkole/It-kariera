using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC1.Views
{
    public class Display
    {
        public Display()
        {
            Distance = 0;
            When = "";
            this.GetValues();
        }

        public int Distance { set; get; }
        public string When { set; get; }

        public double TotalPrice { set; get; }


        public void GetValues()
        {
            Console.WriteLine("Enter the distance:");
            this.Distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the When you travel day/night");
            this.When = Console.ReadLine();
        }

        public void ShowResult()
        {
            Console.WriteLine(this.TotalPrice);
        }
        
    }
}

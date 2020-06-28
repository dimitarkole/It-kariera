using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMVC1.Views
{
    public class Display
    {
        public Display()
        {
            Percent = 0;
            Amaunt = 0;
            Total = 0;
            TipAmaunt = 0;
        }

        public double Percent { set; get; }
        public double Amaunt { set; get; }
        public double Total { set; get; }
        public double TipAmaunt { set; get; }

        public void GetValues()
        {
            Console.WriteLine("Enter the amaunt of meal:");
            this.Amaunt = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the persent you want to tip:");
            this.Percent = double.Parse(Console.ReadLine());
        }

        public void ShowTipAndTotal()
        {
            Console.WriteLine("Your trip is {0:C}", this.TipAmaunt);
            Console.WriteLine("The total will be {0:C}", this.Total);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class BaseTruck
    {
        public BaseTruck(double amountOfFuel, double fuelConsumption, double distance, double rechargedOfFuel)
        {
            AmountOfFuel = amountOfFuel;
            FuelConsumption = fuelConsumption;
            Distance = distance;
            RechargedOfFuel = rechargedOfFuel;
        }

        public double AmountOfFuel { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }
        public double RechargedOfFuel { get; set; }

        public virtual void Drive(double distance)
        {
            double fuel = distance * this.FuelConsumption;
            if(fuel<= AmountOfFuel)
            {
                this.AmountOfFuel -= fuel;
                Console.Write($" ravelled {distance} km");
            }
            else Console.Write($" needs refueling");
        }

        public virtual void Refuel(double liters)
        {
            
            this.AmountOfFuel += liters;
        }

        public virtual void LostFuel(double liters)
        {
            Console.Write(this.AmountOfFuel);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Truck : BaseTruck
    {
        public Truck(double amountOfFuel, double fuelConsumption, double distance, double rechargedOfFuel)
            : base(amountOfFuel, fuelConsumption + 1.6, distance, rechargedOfFuel*0.95)
        {
        }

        public override void Drive(double distance)
        {
            Console.WriteLine("Truck");
            base.Drive(distance);
        }

        public override void LostFuel(double liters)
        {
            Console.WriteLine("Truck: ");
            base.LostFuel(liters);
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
        }
    }
}

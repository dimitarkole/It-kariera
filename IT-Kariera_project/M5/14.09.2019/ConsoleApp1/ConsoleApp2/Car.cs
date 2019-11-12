using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Car : BaseTruck
    {
        public Car(double amountOfFuel, double fuelConsumption, double distance, double rechargedOfFuel) 
            : base(amountOfFuel, fuelConsumption+0.9, distance, rechargedOfFuel)
        {
        }

        public override void Drive(double distance)
        {
            Console.WriteLine("Car");
            base.Drive(distance);
        }

        public override void LostFuel(double liters)
        {
            Console.WriteLine("Car: ");
            base.LostFuel(liters);            
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
        }
    }
}

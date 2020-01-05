using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
namespace StorageMaster.Entities.Storage
{
    public class AutomatedWarehouse : Storage
    {
        private const int AutomatedWarehouseCapacity = 1;
        private const int AutomatedWarehouseGarageSlots = 2;
        private static Vehicle[] AutomatedWarehouseCenterVehicle =
        {
           new Truck(),
        };


        public AutomatedWarehouse(string name)
            : base(name,
                  AutomatedWarehouseCapacity,
                  AutomatedWarehouseGarageSlots,
                  AutomatedWarehouseCenterVehicle)
        {
        }
    }
}

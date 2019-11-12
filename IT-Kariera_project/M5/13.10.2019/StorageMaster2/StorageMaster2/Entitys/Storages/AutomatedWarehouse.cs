using StorageMaster.Entitys.Vehicles;

namespace StorageMaster.Entitys.Storages
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class AutomatedWarehouse : Storage
    {
        private const int AutomatedWarehouseCapacity = 1;
        private const int AutomatedWarehouseGarageSlots = 2;
        private static Vehicle[] AutomatedWarehouseVehicle =
        {
            new Truck()
        };


        public AutomatedWarehouse(string name) 
            : base(name,
                  AutomatedWarehouseCapacity,
                  AutomatedWarehouseGarageSlots,
                  AutomatedWarehouseVehicle)
        {
        }
    }
}

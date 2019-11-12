using StorageMaster.Entitys.Vehicles;

namespace StorageMaster.Entitys.Storages
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Warehouse : Storage
    {
        private const int WarehouseCapacity = 10;
        private const int WarehouseSlots = 10;
        private static Vehicle[] WarehouseVehicle =
        {
            new Semi(),
            new Semi(),
            new Semi(),
        };

        public Warehouse(string name) 
            : base(name,
                  WarehouseCapacity,
                  WarehouseSlots,
                  WarehouseVehicle)
        {
        }
    }
}

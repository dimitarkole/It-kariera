using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
namespace StorageMaster.Entities.Storage
{ 

    public class DistributionCenter  : Storage
    {
        private const int DistributionCenterCapacity = 3;
        private const int DistributionCenterGarageSlots = 5;
        private static Vehicle[] DistributionCenterVehicle =
        {
            new Van(),
            new Van(),
            new Van()
        };


        public DistributionCenter(string name) 
            : base(name,
                  DistributionCenterCapacity,
                  DistributionCenterGarageSlots,
                  DistributionCenterVehicle)
        {
        }
    }
}

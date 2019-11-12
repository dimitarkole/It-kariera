using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entitys.Vehicles
{
    class DistributionCenter : Storage
    {
        public DistributionCenter(string name)
            : base(name, 2, 5, new List<Vehicle>()
            {new Van(),new Van(),new Van()}
            )
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entitys.Vehicles
{
    class Warehouse : Storage
    {
        public Warehouse(string name)
            : base(name, 10, 10, new List<Vehicle>()
            {new Semi(),new Semi(),new Semi()}
            )
        {
        }
    }
}

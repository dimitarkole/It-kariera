namespace StorageMaster.Entities.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SolidStateDrive : Product
    {
        public SolidStateDrive(double price)
            : base(price, 0.2)
        {

        }
    }
}

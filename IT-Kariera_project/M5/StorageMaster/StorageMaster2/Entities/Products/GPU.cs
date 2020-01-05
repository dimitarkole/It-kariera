namespace StorageMaster.Entities.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Gpu : Product
    {
        public Gpu(double price)
            : base(price, 0.7)
        {

        }
    }
}

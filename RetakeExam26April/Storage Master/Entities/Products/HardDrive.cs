using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class HardDrive : Product
    {
        protected HardDrive(double price)
            : base(price, 1)
        {
        }
    }
}

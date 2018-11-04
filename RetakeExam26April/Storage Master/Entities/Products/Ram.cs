using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class Ram : Product
    {
        protected Ram(double price)
            : base(price, 0.1)
        {
        }
    }
}
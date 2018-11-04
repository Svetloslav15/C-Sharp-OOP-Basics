using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Entities.Products
{
    public class Gpu : Product
    {
        protected Gpu(double price)
            : base(price, 0.7)
        {
        }
    }
}

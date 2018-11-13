using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class AutomatedWarehouse : Storage
    {
        public AutomatedWarehouse(string name)
            : base(name, 1, 2, new List<Vehicle>() { new Truck()})
        {
        }
    }
}

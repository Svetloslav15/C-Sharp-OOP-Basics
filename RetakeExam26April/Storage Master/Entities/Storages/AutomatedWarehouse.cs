using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private static readonly Vehicle[] DefaultVehicles =
        {
            new Van(),
        };
        public AutomatedWarehouse(string name, IEnumerable<Vehicle> vehicles)
            : base(name, 1, 2, vehicles: DefaultVehicles)
        {
        }
    }
}

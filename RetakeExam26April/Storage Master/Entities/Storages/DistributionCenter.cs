using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class DistributionCenter  : Storage
    {
        private static readonly Vehicle[] DefaultVehicles =
        {
            new Van(), new Van(), new Van()
        };
        public DistributionCenter(string name, IEnumerable<Vehicle> vehicles)
            : base(name, 2, 5, vehicles: DefaultVehicles)
        {
        }
    }
}
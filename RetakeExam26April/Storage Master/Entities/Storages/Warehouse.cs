using System;
using System.Collections.Generic;
using System.Text;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Entities.Storages
{
    public class Warehouse  : Storage
    {
        private static readonly Vehicle[] DefaultVehicles =
        {
            new Semi(), new Semi(), new Semi()
        };
        public Warehouse(string name, IEnumerable<Vehicle> vehicles)
            : base(name, 10, 10, vehicles: DefaultVehicles)
        {
        }
    }
}
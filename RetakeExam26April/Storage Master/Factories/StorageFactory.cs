﻿using StorageMaster.Models.Storages;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Factories
{
    public static class StorageFactory
    {
        public static Storage CreateStorage(string type, string name)
        {
            switch (type)
            {
                case "AutomatedWarehouse": return new AutomatedWarehouse(name);
                case "DistributionCenter": return new DistributionCenter(name);
                case "Warehouse": return new Warehouse(name);
                default: throw new InvalidOperationException("Invalid storage type!");
            }
        }
    }
}
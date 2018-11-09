using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public interface IVehicle
    {
        double FuelQuantity { get; set; }
        double FuelConsumption { get; set; }

        string Driving(double distance);
        void Refuel(double quantity);
    }
}

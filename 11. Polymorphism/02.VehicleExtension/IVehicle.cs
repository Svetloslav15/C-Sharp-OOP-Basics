using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public interface IVehicle
    {
        double FuelQuantity { get; }

        double FuelConsumptionPerKm { get; }

        double TankCapacity { get; }

        string Drive(double distance);

        void Refuel(double quantity);
    }
}

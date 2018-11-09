using StorageMaster.Models.Storages;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Models
{
    public static class ErrorTracker
    {
        public static void FullVehicle(Vehicle vehicle)
        {
            if (vehicle.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
        }
        public static void EmptyVehicle(Vehicle vehicle)
        {
            if (vehicle.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
        }
        public static void InvalidGarageSlot(int garageSlots, int currentSlot)
        {
            if (currentSlot >= garageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
        }
        public static void EmptyGarageSlot(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
        }
        public static void AnyFreeGarageSlot(Vehicle[] garage)
        {
            if (garage.ToList().Select(x => x == null).Count() == 0)
            {
                throw new InvalidOperationException("No room in garage!");
            }
        }
        public static void FullGarage(Vehicle[] garage)
        {
            if (garage.Select(x => x == null).Count() == 0)
            {
                throw new InvalidOperationException("Storage is full!");
            }
        }
        public static void DestinationStorage(Storage destinationStorage)
        {
            if (destinationStorage == null)
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }
        }
        public static void SourceStorage(Storage sourceStorage)
        {
            if (sourceStorage == null)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }
        }
    }
}
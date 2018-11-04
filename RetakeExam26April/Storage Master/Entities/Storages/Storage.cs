using StorageMaster.Entities.Products;
using StorageMaster.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Storages
{
    public abstract class Storage
    {
        private readonly Vehicle[] garage;
        private readonly List<Product> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.garage = new Vehicle[garageSlots];
            this.products = new List<Product>();

            this.InitializeGarage(vehicles);
        }
        private void InitializeGarage(IEnumerable<Vehicle> vehicles)
        {
            var garageSlot = 0;
            foreach (var vehicle in vehicles)
            {
                this.garage[garageSlot++] = vehicle;
            }
        }
        public string Name { get; }
        public int Capacity { get; }
        public int GarageSlots { get; }
        public bool IsFull => this.products.Sum(p => p.Weight) >= this.Capacity;
        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);
        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();

        public Vehicle GetVehicle(int garageSlot)
        {
            if (this.garage.Length <= garageSlot)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            var currentVehicle = this.garage[garageSlot];
            if (currentVehicle == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            return currentVehicle;
        }
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);
            if (!deliveryLocation.Garage.Any(x => x == null))
            {
                throw new InvalidOperationException("No room in garage!");
            }
            this.garage[garageSlot] = null;

            var addedSlot = deliveryLocation.AddVehicle(vehicle);
            return addedSlot;
        }
        public int UnloadVehicle(int garageSlot)
        {
            if (!this.Garage.Any(x => x == null))
            {
                throw new InvalidOperationException("No room in garage!");
            }
            Vehicle vehicle = this.GetVehicle(garageSlot);
            var unloadedProductCount = 0;
            while (!vehicle.IsEmpty && !this.IsFull)
            {
                var crate = vehicle.Unload();
                this.products.Add(crate);

                unloadedProductCount++;
            }

            return unloadedProductCount;
        }
        private int AddVehicle(Vehicle vehicle)
        {
            var freeGarageSlotIndex = Array.IndexOf(this.garage, null);
            this.garage[freeGarageSlotIndex] = vehicle;

            return freeGarageSlotIndex;
        }
    }
}

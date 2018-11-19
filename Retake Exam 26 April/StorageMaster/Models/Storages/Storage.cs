using StorageMaster.Models.Products;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Models.Storages
{
    public abstract class Storage
    {
        public string Name { get; }
        public int Capacity { get; }
        public int GarageSlots { get; }
        private List<Product> products;
        private Vehicle[] garage;

        public IReadOnlyCollection<Vehicle> Garage => this.garage;
        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();
        public bool IsFull => this.Products.Select(x => x.Weight).Sum() >= this.Capacity;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.garage = new Vehicle[this.GarageSlots];
            this.products = new List<Product>();
            vehicles.ToArray().CopyTo(this.garage, 0);
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            ErrorTracker.InvalidGarageSlot(this.GarageSlots, garageSlot);
            ErrorTracker.EmptyGarageSlot(this.garage[garageSlot]);
            return this.garage[garageSlot];
        }

        private int AddVehicleToGarage(Vehicle vehicle)
        {
            int freeGarageSlotIndex = Array.IndexOf(this.garage, null);
            if (freeGarageSlotIndex == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }
            this.garage[freeGarageSlotIndex] = vehicle;
            return freeGarageSlotIndex;
        }
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);

            int index = deliveryLocation.AddVehicleToGarage(vehicle);
            this.garage[garageSlot] = null;

            return index;
        }

        public int UnloadVehicle(int garageSlot)
        {
            ErrorTracker.FullGarage(this.IsFull);
            ErrorTracker.InvalidGarageSlot(this.GarageSlots, garageSlot);
            ErrorTracker.EmptyGarageSlot(this.garage[garageSlot]);

            Vehicle currentVehicle = this.garage[garageSlot];
            int uploadedProducts = 0;
            
            while(!currentVehicle.IsEmpty && !this.IsFull)
            {
                Product currentProduct = currentVehicle.Unload();
                this.products.Add(currentProduct);
                uploadedProducts++;
            }
            return uploadedProducts;
        }
        public override string ToString()
        {
            return this.Name + ":\n" + "Storage worth: $" + this.products.Select(x => x.Price).Sum().ToString("F2");
        }
    }
}

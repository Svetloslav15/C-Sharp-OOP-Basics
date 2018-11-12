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

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            ErrorTracker.InvalidGarageSlot(this.GarageSlots, garageSlot);
            ErrorTracker.EmptyGarageSlot(this.garage[garageSlot]);
            Vehicle currentVehicle = this.garage[garageSlot];
            ErrorTracker.AnyFreeGarageSlot(this.garage);
            var temp = this.garage.First(x => x == null);
            int firstFreeSlot = this.garage.ToList().IndexOf(temp);
            this.garage[firstFreeSlot] = currentVehicle;
            return firstFreeSlot;
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

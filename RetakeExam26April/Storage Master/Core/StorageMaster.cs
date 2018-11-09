using StorageMaster.Factories;
using StorageMaster.Models;
using StorageMaster.Models.Products;
using StorageMaster.Models.Storages;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster
{
    public class StorageMaster
    {
        private List<Storage> storageRegistry;
        private List<Product> productsPool;
        private Vehicle currentVehicle;
        public StorageMaster()
        {
            this.storageRegistry = new List<Storage>();
            this.productsPool = new List<Product>();
            this.currentVehicle = null;
        }
        public string AddProduct(string type, double price)
        {
            Product product = ProductFactory.CreateProduct(type, price);
            this.productsPool.Add(product);
            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = StorageFactory.CreateStorage(type, name);
            this.storageRegistry.Add(storage);
            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storageRegistry.FirstOrDefault(x => x.Name == storageName);
            this.currentVehicle = storage.GetVehicle(garageSlot);
            return $"Selected {this.currentVehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            foreach (var name in productNames)
            {
                var contains = this.productsPool.Any(x => x.GetType().Name == name);
                if (contains == false)
                {
                    throw new InvalidOperationException($"{name} is out of stock!");
                }
            }

            return StartLoadingCurrentVehicle(productNames);
        }

        private string StartLoadingCurrentVehicle(IEnumerable<string> productNames)
        {
            var namesToArray = productNames.ToArray();
            var addedProductsCounter = 0;
            for (int i = 0; i < namesToArray.Length; i++)
            {
                var name = namesToArray[i];
                var product = this.productsPool.Last(x => x.GetType().Name == name);
                if (product != null && !this.currentVehicle.IsFull)
                {
                    this.currentVehicle.LoadProduct(product);
                    this.productsPool.Remove(product);
                    addedProductsCounter++;
                }
            }

            return
                $"Loaded {addedProductsCounter}/{namesToArray.Length} products into" +
                $" {this.currentVehicle.GetType().Name}";
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            Storage sourceStorage = this.storageRegistry.FirstOrDefault(x => x.Name == sourceName);
            Storage destinationStorage = this.storageRegistry.FirstOrDefault(x => x.Name == destinationName);

            ErrorTracker.SourceStorage(sourceStorage);
            ErrorTracker.DestinationStorage(destinationStorage);
            int destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);
            Vehicle vehicle = sourceStorage.GetVehicle(sourceGarageSlot);
            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storageRegistry.FirstOrDefault(x => x.Name == storageName);
            Vehicle vehicle = storage.GetVehicle(garageSlot);
            ErrorTracker.EmptyGarageSlot(vehicle);
            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);
            return $"Unloaded {unloadedProductsCount}/{vehicle.Trunk.Count} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storageRegistry.FirstOrDefault(x => x.Name == storageName);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(GetGroupedProducts(storage));
            stringBuilder.AppendLine(GetAllVehicles(storage));
            return stringBuilder.ToString().Trim();
        }

        public string GetSummary()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var store in this.storageRegistry.OrderByDescending(x => x.Products.Sum(p => p.Price)))
            {
                sb.AppendLine(store.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        private string GetAllVehicles(Storage storage)
        {
            List<string> vehicles = new List<string>();
            foreach (var vehicle in storage.Garage)
            {
                if (vehicle == null)
                {
                    vehicles.Add("empty");
                }
                else
                {
                    vehicles.Add(vehicle.GetType().Name);
                }
            }
            return $"Garage: [{string.Join("|", vehicles)}]";
        }

        private string GetGroupedProducts(Storage storage)
        {
            double storageProductsWeight = storage.Products.Select(x => x.Weight).Sum();
            int storageCapacity = storage.Capacity;
            var storageProducts = storage.Products
               .GroupBy(p => p.GetType().Name);
            List<string> products = new List<string>();
            foreach (var group in storageProducts
                .OrderByDescending(x => x.ToList().Count())
                .ThenBy(x => x.Key))
            {
                products.Add($"{group.Key} ({group.Count()})");
            }
            return $"Stock ({storageProductsWeight}/{storageCapacity}): [{string.Join(", ", products)}]";
        }
    }
}
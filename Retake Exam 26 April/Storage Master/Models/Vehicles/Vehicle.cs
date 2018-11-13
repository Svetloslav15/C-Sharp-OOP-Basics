using StorageMaster.Models.Products;
using System.Collections.Generic;
using System.Linq;

namespace StorageMaster.Models.Vehicles
{
    public abstract class Vehicle
    {
        public int Capacity { get; set; }
        private List<Product> trunk;

        public IReadOnlyCollection<Product> Trunk
        {
            get => this.trunk.AsReadOnly();
        }
        public bool IsFull => this.trunk.Select(x => x.Weight).Sum() >= this.Capacity;
        public bool IsEmpty => this.trunk.Count == 0;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new List<Product>();
        }

        public void LoadProduct(Product product)
        {
            ErrorTracker.FullVehicle(this);
            this.trunk.Add(product);
        }

        public Product Unload()
        {
            ErrorTracker.EmptyVehicle(this);
            Product lastProduct = this.trunk.Last();
            this.trunk.RemoveAt(this.trunk.Count - 1);
            return lastProduct;
        }
    }
}
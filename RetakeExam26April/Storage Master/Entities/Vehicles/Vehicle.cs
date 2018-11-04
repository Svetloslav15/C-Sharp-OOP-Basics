using StorageMaster.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private List<Product> trunk = new List<Product>();
        public int Capacity { get; set; }
        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();
        public bool IsFull => this.Trunk.Select(x => x.Weight).Sum() >= this.Capacity;
        public bool IsEmpty => this.Trunk.Count == 0;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
        }
        public void LoadProduct(Product product)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            this.trunk.Add(product);
        }
        public Product Unload()
        {
            if (this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            var last = this.trunk.Last();
            this.trunk.Remove(last);
            return last;
        }
    }
}

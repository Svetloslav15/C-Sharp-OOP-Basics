using System;

namespace StorageMaster.Models.Products
{
    public abstract class Product
    {
        private double price;
        private double weight;

        public double Price
        {
            get => this.price;
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Price cannot be negative!");
                }
                this.price = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            set { this.weight = value; }
        }
        protected Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }
    }
}
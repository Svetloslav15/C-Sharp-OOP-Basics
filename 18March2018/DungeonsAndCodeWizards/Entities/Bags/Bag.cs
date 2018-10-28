using DungeonsAndCodeWizards.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Entities.Bags
{
    public abstract class Bag
    {
        public int Capacity { get; set; }
        public List<Item> items { get; }
        private double load;
        public IReadOnlyCollection<Item> Items
        {
            get
            {
                return this.items.AsReadOnly();
            }
        }
        public double Load
        {
            get => this.load;
            set
            {
                this.load = this.Items.Select(x => x.Weight).Sum();
            }
        }
        public virtual void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            this.items.Add(item);
        }
        public virtual Item GetItem(string name)
        {
            if (this.Items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }
            var item = this.Items.FirstOrDefault(x => x.GetType().Name == name);
            if (item != null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }
            this.items.Remove(item);
            return item;
        }
        public Bag(int capacity = 100)
        {
            this.Capacity = capacity;
        }
    }
}

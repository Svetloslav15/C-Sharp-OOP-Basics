using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class AddCollection : IAddable
    {
        private List<string> collection { get; set; }

        public int Add(string item)
        {
            this.collection.Add(item);
            return this.collection.Count - 1;
        }
        public AddCollection()
        {
            this.collection = new List<string>();
        }
    }
}

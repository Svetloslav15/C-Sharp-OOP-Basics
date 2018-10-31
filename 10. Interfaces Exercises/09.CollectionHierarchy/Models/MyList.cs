using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class MyList : IAddable, IRemovable
    {
        private List<string> collection { get; set; }

        public int Add(string item)
        {
            this.collection.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string item = this.collection.First();
            this.collection.Remove(item);
            return item;
        }
        public int Used()
        {
            return this.collection.Count;
        }
        public MyList()
        {
            this.collection = new List<string>();
        }
    }
}
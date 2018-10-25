using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings
    {
        private List<string> list;
        public StackOfStrings()
        {
            this.list = new List<string>();
        }

        public void Push(string item)
        {
            this.list.Add(item);
        }

        public string Pop()
        {
            string item = this.list.Last();
            this.list.RemoveAt(this.list.Count - 1);
            return item;
        }

        public string Peek()
        {
            string item = list[this.list.Count - 1];
            return item;
        }

        public bool IsEmpty()
        {
            return this.list.Count == 0 ? true : false;
        }
    }
}

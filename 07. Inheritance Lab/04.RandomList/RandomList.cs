using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random randomGenerator { get; set; }

        public RandomList()
        {
            randomGenerator = new Random();
        }

        public string RandomString()
        {
            string result = "";
            if (this.Count > 0)
            {
                int index = randomGenerator.Next(0, Count - 1);
                result = this[index];
                this.RemoveAt(index);
            }
            return result;

        }
    }
}

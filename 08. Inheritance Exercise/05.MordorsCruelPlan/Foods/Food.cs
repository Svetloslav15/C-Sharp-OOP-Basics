using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Foods
{
    public class Food
    {
        public int Hapineness { get; private set; }

        public Food(int hapiness)
        {
            this.Hapineness = hapiness;
        }
    }
}

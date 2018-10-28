using DefiningClasses.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Player
    {
        public List<Food> FoodsEaten { get; set; }
        public int Hapiness { get; set; }

        public Player()
        {
            this.FoodsEaten = new List<Food>();
            this.Hapiness = 0;
        }
    }
}

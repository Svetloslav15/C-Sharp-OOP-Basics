using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Kitten : Animal 
    {
        public Kitten(string name, int age) : base(name, age)
        {
            this.Gender = "Female";
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}

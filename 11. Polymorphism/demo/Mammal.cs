using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    public class Mammal : IAnimal
    {
        public string Type { get; set; }
        public int Age { get; set; }

        public virtual void Climb()
        {
            Console.WriteLine("Climbing");
        }
        
        public virtual void Walk()
        {
            Console.WriteLine("Walking");
        }
    }
}

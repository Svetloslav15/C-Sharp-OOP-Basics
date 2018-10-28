using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender)
        {

        }
        public Cat(string name, int age) : base(name, age)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow meow");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age)
        {
            this.Gender = "Male";
        }
        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}

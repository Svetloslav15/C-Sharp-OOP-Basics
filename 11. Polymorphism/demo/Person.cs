using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    public class Person : Mammal
    {
        public void Speak()
        {
            Console.WriteLine("Speaking");
        }
        public Person(int age)
        {
            this.Age = age;
        }
    }
}

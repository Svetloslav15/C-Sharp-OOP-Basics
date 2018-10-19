using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public int engineSpeed;
        public int enginePower;

        public Engine()
        {

        }

        public Engine(int speed, int power)
        {
            this.engineSpeed = speed;
            this.enginePower = power;
        }
    }
}

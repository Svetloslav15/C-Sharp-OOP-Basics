using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Ferrari : ICar
    {
        public string Driver { get; set; }
        private string Model = "488-Spider";
        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }
        public override string ToString()
        {
            return $"{this.Model}/{this.Brakes()}/{this.GasPedal()}/{this.Driver}";
        }
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }
    }
}
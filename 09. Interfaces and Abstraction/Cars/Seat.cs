using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string v1;
        private string v2;

        public Seat(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Model { get; set; }
        public string Color { get; set; }

        public string Start()
        {
            return $"Engine start!";
        }

        public string Stop()
        {
            return $"Breaaak!";
        }
        public override string ToString()
        {
            return $"{this.Start()}\n{this.Stop()}\n{this.Color}Seat {this.Model}";
        }
    }
}
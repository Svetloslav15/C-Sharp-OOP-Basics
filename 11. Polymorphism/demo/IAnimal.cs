using System;
using System.Collections.Generic;
using System.Text;

namespace demo
{
    public interface IAnimal
    {
        string Type { get; set; }
        void Walk();
        void Climb();
    }
}

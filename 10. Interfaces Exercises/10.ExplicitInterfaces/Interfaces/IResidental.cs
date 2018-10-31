using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Interfaces
{
    public interface IResidental
    {
        string Name { get; }
        string Country { get; }
        string GetName();
    }
}

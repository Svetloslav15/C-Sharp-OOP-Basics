using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider CreateProvider(List<string> tokens)
    {
        string type = tokens[0];
        string id = tokens[1];
        double energyOutput = double.Parse(tokens[2]);

        switch (type)
        {
            case "Solar":
                return new SolarProvider(id, energyOutput);
            case "Pressure":
                return new PressureProvider(id, energyOutput);
            default:
                throw new ArgumentException($"Provider is not registered, because of it's Type!");
        }
    }
}
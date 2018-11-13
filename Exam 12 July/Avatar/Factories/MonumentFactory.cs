using System;
using System.Collections.Generic;

public static class MonumentFactory
{
    public static Monument CreateMonument(List<string> tokens)
    {
        string type = tokens[1];
        string name = tokens[2];
        int affinity = int.Parse(tokens[3]);

        switch (type)
        {
            case "Air":
                return new AirMonument(name, affinity);
            case "Earth":
                return new EarthMonument(name, affinity);
            case "Fire":
                return new FireMonument(name, affinity);
            case "Water":
                return new WaterMonument(name, affinity);
            default:
                throw new ArgumentException("Invalid Monument Type!");
        }
    }
}
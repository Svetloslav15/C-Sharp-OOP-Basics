using System;
using System.Collections.Generic;

public static class BenderFactory
{
    public static Bender CreateBender(List<string> tokens)
    {
        string type = tokens[1];
        string name = tokens[2];
        int power = int.Parse(tokens[3]);
        double secondaryParam = double.Parse(tokens[4]);

        switch (type)
        {
            case "Air":
                return new AirBender(name, power, secondaryParam);
            case "Earth":
                return new EarthBender(name, power, secondaryParam);
            case "Fire":
                return new FireBender(name, power, secondaryParam);
            case "Water":
                return new WaterBender(name, power, secondaryParam);
            default:
                throw new ArgumentException("Invalid Bender Type!");
        }
    } 
}
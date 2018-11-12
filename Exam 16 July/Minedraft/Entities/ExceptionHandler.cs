using System;
public static class ExceptionHandler
{
    public static void NagativeOreOutput(double value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
        }
    }

    public static void EnergyOutput(double value)
    {
        if (value < 0 || value > 10000)
        {
            throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
        }
    }
   
    public static void EnergyRequirement(double value)
    {
        if (value < 0 || value > 20000)
        {
            throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
        }
    }
}


using System;
using System.Collections.Generic;

public class HarvesterFactory
{
    public static Harvester CreateHarvester(List<string> tokens)
    {
        string type = tokens[0];
        string id = tokens[1];
        double oreOutput = double.Parse(tokens[2]);
        double energyRequirement = double.Parse(tokens[3]);

        switch (type)
        {
            case "Sonic":
                {
                    int sonicFactor = int.Parse(tokens[4]);
                    return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                }
            case "Hammer":
                {
                    return new HammerHarvester(id, oreOutput, energyRequirement);
                }
            default:
                throw new ArgumentException("Harvester is not registered, because of it's Type");
        }
    }
}
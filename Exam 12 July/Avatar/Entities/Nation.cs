using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> members;
    public IReadOnlyCollection<Bender> Members
    {
        get => this.members.AsReadOnly();
    }

    private List<Monument> monuments;
    public IReadOnlyCollection<Monument> Monuments
    {
        get => this.monuments.AsReadOnly();
    }

    public double TotalPower()
    {
        double totalMembersPower = this.members.Sum(x => x.Power);
        double totalMonumentsPower = this.CalculateMonumentsPower();
        if (totalMonumentsPower == 0)
        {
            return totalMembersPower;
        }
        return totalMembersPower * totalMonumentsPower / 100;
    }
    private double CalculateMonumentsPower()
    {
        double result = 0.0;
        foreach (var item in this.monuments)
        {
            if (item is AirMonument airMonument)
            {
                result += airMonument.AirAffinity;
            }
            if (item is WaterMonument waterMonument)
            {
                result += waterMonument.WaterAffinity;
            }
            if (item is EarthMonument earthMonument)
            {
                result += earthMonument.EarthAffinity;
            }
            if (item is FireMonument fireMonument)
            {
                result += fireMonument.FireAffinity;
            }
        }
        return result;
    }
    public void AddMember(Bender bender)
    {
        this.members.Add(bender);
    }
    public Nation()
    {
        this.members = new List<Bender>();
        this.monuments = new List<Monument>();
    }
    public void AddMonument(Monument monument)
    {
        this.monuments.Add(monument);
    }
    public void LoseWar()
    {
        this.members.Clear();
        this.monuments.Clear();
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        if (this.members.Count == 0)
        {
            result.AppendLine($"Benders: None");
        }
        else
        {
            result.AppendLine("Benders:");
            foreach (Bender member in this.members)
            {
                if (member is AirBender airBender)
                {
                    result.AppendLine($"###Air Bender: {airBender.Name}, Power: {airBender.Power}, Aerial Integrity: {airBender.AerialIntegrity:f2}");
                }
                if (member is WaterBender waterBender)
                {
                    result.AppendLine($"###Water Bender: {waterBender.Name}, Power: {waterBender.Power}, Water Clarity: {waterBender.WaterClarity:f2}");
                }
                if (member is EarthBender earthBender)
                {
                    result.AppendLine($"###Earth Bender: {earthBender.Name}, Power: {earthBender.Power}, Ground Saturation: {earthBender.GroundSaturation:f2}");
                }
                if (member is FireBender fireBender)
                {
                    result.AppendLine($"###Fire Bender: {fireBender.Name}, Power: {fireBender.Power}, Heat Aggression: {fireBender.HeatAggression:f2}");
                }
            }
        }
        if (this.monuments.Count == 0)
        {
            result.AppendLine($"Monuments: None");
        }
        else
        {
            result.AppendLine($"Monuments:");

            foreach (Monument monument in this.monuments)
            {
                if (monument is AirMonument airMonument)
                {
                    result.AppendLine($"###Air Monument: {airMonument.Name}, Air Affinity: {airMonument.AirAffinity}");
                }
                if (monument is WaterMonument waterMonument)
                {
                    result.AppendLine($"###Water Monument: {waterMonument.Name}, Water Affinity: {waterMonument.WaterAffinity}");
                }
                if (monument is EarthMonument earthMonument)
                {
                    result.AppendLine($"###Earth Monument: {earthMonument.Name}, Earth Affinity: {earthMonument.EarthAffinity}");
                }
                if (monument is FireMonument fireMonument)
                {
                    result.AppendLine($"###Fire Monument: {fireMonument.Name}, Fire Affinity: {fireMonument.FireAffinity}");
                }
            }
        }
        return result.ToString().TrimEnd();
    }
}
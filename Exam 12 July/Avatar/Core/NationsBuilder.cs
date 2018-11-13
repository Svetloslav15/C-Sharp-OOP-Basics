using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> issuedWars;
    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>();
        this.nations["Air"] = new Nation();
        this.nations["Water"] = new Nation();
        this.nations["Fire"] = new Nation();
        this.nations["Earth"] = new Nation();
        this.issuedWars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        Bender bender = BenderFactory.CreateBender(benderArgs);
        string benderName = bender.GetTypeName();
        this.nations[benderName].AddMember(bender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        Monument monument = MonumentFactory.CreateMonument(monumentArgs);
        string monumentName = monument.GetTypeName();
        this.nations[monumentName].AddMonument(monument);
    }

    public string GetStatus(string nationsType)
    {
        string output = nationsType + " Nation"+ "\n" + this.nations[nationsType].ToString();
        return output;
    }

    public void IssueWar(string nationsType)
    {
        int counter = 1;
        foreach (var nation in nations.OrderByDescending(x => x.Value.TotalPower()))
        {
            if (counter++ != 1)
            {
                nation.Value.LoseWar();
            }
        }
        this.issuedWars.Add(nationsType);
    }
    public string GetWarsRecord()
    {
        StringBuilder result = new StringBuilder();
        for (int index = 0; index < this.issuedWars.Count; index++)
        {
            result.AppendLine($"War {index + 1} issued by {this.issuedWars[index]}");
        }
        return result.ToString().TrimEnd();
    }
}
public class FireBender : Bender
{
    public double HeatAggression { get; private set; }
    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }
}
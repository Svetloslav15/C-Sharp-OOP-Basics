public class EarthBender : Bender
{
    public double GroundSaturation { get; private set; }
    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }
}
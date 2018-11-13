public class AirBender : Bender
{
    public double AerialIntegrity { get; set; }
    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }
}
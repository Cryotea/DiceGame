namespace diceGame.Stats;

public class Strength : IStat
{
    public double MaxStrength;
    public Strength (double maxStrength)
    {
        MaxStrength = maxStrength;
    }

    public double GetStat(IFighter fighter)
    {
        double Strength = MaxStrength;
        return Strength;
    }
}
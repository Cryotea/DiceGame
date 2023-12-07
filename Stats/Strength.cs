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
        double Strengthbuff = MaxStrength * (fighter.Effect.Strength.Item1 * 0.1);
        double Weaknessdebuff = MaxStrength * (fighter.Effect.Weakness.Item1 * 0.1);

        Strength = Strength + Strengthbuff - Weaknessdebuff;
        return Strength;
    }
}
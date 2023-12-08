using diceGame.Effects;

namespace diceGame.Stats;

public class Strength : BaseStat, IStat
{
    public Strength (double maxStrength)
    {
        Max = maxStrength;
    }

    public double GetStat(Effect effect)
    {
        double Strength = Max;
        double Strengthbuff = Max * (effect.Strength.Item1 * 0.1);
        double Weaknessdebuff = Max * (effect.Weakness.Item1 * 0.1);

        Strength = Strength + Strengthbuff - Weaknessdebuff;
        return Strength;
    }
}
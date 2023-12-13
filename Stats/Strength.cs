using diceGame.Effects;
using Spectre.Console;

namespace diceGame.Stats;

public class Strength : BaseStat, IStat
{
    public string Color = ColorManager.StrengthColor;
    public Strength (double maxStrength)
    {
        Id = "Strength";
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

    public override string ToString()
    {
        return $"{Color}Strength[/]";
    }
}
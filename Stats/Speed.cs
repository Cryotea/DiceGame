using diceGame.Effects;
using Spectre.Console;

namespace diceGame.Stats;

public class Speed : BaseStat, IStat
{
    public string Color = ColorManager.SpeedColor;
    public Speed (double maxSpeed)
    {
        Id = "Speed";
        Max = maxSpeed;
    }

    public double GetStat(Effect effect)
    {
        double Speed = Max;

        return Speed;
    }

    public override string ToString()
    {
        return $"{Color}Speed[/]";
    }
}
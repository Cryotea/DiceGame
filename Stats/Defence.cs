using diceGame.Effects;
using Spectre.Console;

namespace diceGame.Stats;

public class Defence : BaseStat, IStat
{
    public string Color = "[grey39]";
    
    public Defence(double maxDefence)
    {
        Id = "Defence";
        Max = maxDefence;
    }

    public double GetStat(Effect effect)
    {
        double Defence = Max;

        return Defence;
    }

    public override string ToString()
    {
        return $"{Color}Defence[/]";
    }
}


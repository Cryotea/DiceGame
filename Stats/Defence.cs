using diceGame.Effects;

namespace diceGame.Stats;

public class Defence : BaseStat, IStat
{
    public Defence(double maxDefence)
    {
        Max = maxDefence;
    }

    public double GetStat(Effect effect)
    {
        double Defence = Max;

        return Defence;
    }
}


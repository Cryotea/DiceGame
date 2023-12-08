using diceGame.Effects;

namespace diceGame.Stats;

public class Speed : BaseStat, IStat
{

    public Speed (double maxSpeed)
    {
        Max = maxSpeed;
    }

    public double GetStat(Effect effect)
    {
        double Speed = Max;

        return Speed;
    }
}
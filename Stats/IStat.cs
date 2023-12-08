using diceGame.Effects;

namespace diceGame.Stats;

public interface IStat
{
    public double GetStat(Effect effect);
}